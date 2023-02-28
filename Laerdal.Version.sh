#!/bin/bash
usage(){
    echo "usage: ./Laerdal.Version.sh [--master-branch master] [--develop-branch develop] [--major 1] [--minor 0] [--patch 0] [--revision 0] [--build-id 0] [--branch branchname] [-o | --output CHANGELOG.md] [-h | --help]"
    echo "parameters:"
    echo "  --master-branch [branch]           Name of the master branch (default is master)"
    echo "  --develop-branch [branch]          Name of the develop branch (default is develop)"
    echo "  --major [number]                   Major version override (default is 1)"
    echo "  --minor [number]                   Minor version override (default is 0)"
    echo "  --patch [number]                   Patch version override (default is 0)"
    echo "  --revision [number]                Revision version override (default is 0)"
    echo "  --build-id [number]                Build id override (default is 0)"
    echo "  -o | --output [filename]           Name of the output file"
    echo "  -h | --help                        Prints this message"
    echo "  -v | --verbose                     Verbose mode"
}

master_branch="master"
develop_branch="develop"
major=1
minor=0
patch=0
revision=0
build_id=0
version_core=$major.$minor.$patch
version_extension=
version_full=$version_core$version_extension

while [ "$1" != "" ]; do
    case $1 in
        --master-branch )       shift
                                master_branch="$1"
                                ;;
        --develop-branch )      shift
                                develop_branch="$1"
                                ;;
        --major )               shift
                                major="$1"
                                major_override=true
                                ;;
        --minor )               shift
                                minor="$1"
                                minor_override=true
                                ;;
        --patch )               shift
                                patch="$1"
                                patch_override=true
                                ;;
        --revision )            shift
                                revision="$1"
                                revision_override=true
                                ;;
        --build-id )            shift
                                build_id="$1"
                                build_id_override=true
                                ;;
        -h | --help )           usage
                                exit
                                ;;
        -v | --verbose )        verbose=1
                                ;;
        -o | --output )         shift
                                output="$1"
                                ;;
         * )                    echo
                                echo "### Wrong parameter: $1 ###"
                                echo
                                usage
                                exit 1
    esac
    shift
done

function log () {
    if [[ $verbose -eq 1 ]]; then
        echo "$@"
    fi
}

# Azure DevOps build
if [ "${TF_BUILD:=}" != "" ]; then
    log "TF_BUILD is set, assuming Azure DevOps build"
    azure_dev_ops_build=1
else
    log "TF_BUILD is not set, assuming local build"
    azure_dev_ops_build=0
fi

# Branch prefix
if [[ $azure_dev_ops_build -eq 1 ]]; then
    branch_prefix="origin/"
else
    branch_prefix=""
fi

# Build id
if [[ $azure_dev_ops_build -eq 1 ]]; then
    build_id=${BUILD_BUILDID}
else
    build_id=`git rev-list --count HEAD`
fi
log "build_id=$build_id"

# Branch name
if [[ $azure_dev_ops_build -eq 1 ]]; then
    if [[ "${BUILD_REASON}" != "PullRequest" ]]; then
        branch_name=`echo ${BUILD_SOURCEBRANCH} | sed 's/refs\/heads\///g'`
    else
        branch_name=`echo ${SYSTEM_PULLREQUEST_SOURCEBRANCH} | sed 's/refs\/heads\///g'`
    fi
else
    branch_name=`git rev-parse --abbrev-ref HEAD | sed 's/refs\/heads\///g'`
fi
log "branch_name=$branch_name"

# First commit
first_commit=`git rev-list --max-parents=0 HEAD`
log "first_commit=$first_commit"

# Suffix
suffix=`echo $branch_name | sed 's/\//-/'`
log "suffix=$suffix"

if [ "$branch_name" == "$develop_branch" ]; then
    develop_master_point=`git rev-list $branch_prefix$master_branch --merges --before=\`git show -s --format=%ct HEAD\` --first-parent --max-count=1`
    if [ -z $develop_master_point ]; then
        # has never been merged,
        develop_master_point=`git merge-base $branch_prefix$master_branch HEAD --fork-point`
    fi
    log "develop_master_point=$develop_master_point"
elif [ "$branch_name" != "$master_branch" ]; then
    head_develop_point=`git rev-list $branch_prefix$develop_branch --merges --before=\`git show -s --format=%ct HEAD\` --first-parent --max-count=1`
    if [ -z $head_develop_point ]; then
        # has never been merged,
        head_develop_point=`git merge-base $branch_prefix$develop_branch HEAD --fork-point`
    fi
    log "head_develop_point=$head_develop_point"
    develop_master_point=`git rev-list $branch_prefix$master_branch --merges --before=\`git show -s --format=%ct $head_develop_point\` --first-parent --max-count=1`
    if [ -z $develop_master_point ]; then
        # has never been merged,
        develop_master_point=`git merge-base $branch_prefix$master_branch $head_develop_point --fork-point`
    fi
    log "develop_master_point=$develop_master_point"
fi


# Minor
if [ "$minor_override" != "true" ]; then
    if [ "$branch_name" == "$master_branch" ]; then
        minor=`git rev-list $first_commit..HEAD --count --first-parent --ancestry-path`
    elif [ "$branch_name" == "$develop_branch" ]; then
        minor=`git rev-list $first_commit..$develop_master_point --count --first-parent --ancestry-path`
    else
        minor=`git rev-list $first_commit..$develop_master_point --count --first-parent --ancestry-path`
    fi
else
    log "Minor version override: $minor"
fi

# Patch
if [ "$patch_override" != "true" ]; then
    if [ "$branch_name" == "$master_branch" ]; then
        patch=0
    elif [ "$branch_name" == "$develop_branch" ]; then
        patch=`git rev-list $first_commit..HEAD --count --first-parent --ancestry-path --not \`git rev-list $first_commit..HEAD --before=\\\`git show -s --format=%ct $develop_master_point --first-parent --ancestry-path\\\`\``
    else
        patch=`git rev-list $first_commit..$head_develop_point --count --first-parent --ancestry-path --not \`git rev-list $first_commit..$head_develop_point --before=\\\`git show -s --format=%ct $develop_master_point --first-parent --ancestry-path\\\`\``
    fi
else
    log "Patch version override: $patch"
fi

# Revision
if [ "$revision_override" != "true" ]; then
    if [ "$branch_name" == "$master_branch" ]; then
        revision=0
    elif [ "$branch_name" == "$develop_branch" ]; then
        revision=0
    else
        revision=`git rev-list $head_develop_point..HEAD --count`
    fi
else
    log "Revision version override: $revision"
fi

# Version extension
if [ "$branch_name" == "$master_branch" ]; then
    version_extension=
elif [ "$branch_name" == "$develop_branch" ]; then
    version_extension=
else
    version_extension="-$suffix-$revision.$build_id"
fi

version_core=$major.$minor.$patch
version_full=$version_core$version_extension
version_assembly=$version_core.$revision


log "Laerdal.Version.Major:$major"
log "Laerdal.Version.Minor:$minor"
log "Laerdal.Version.Patch:$patch"
log "Laerdal.Version.Suffix:$suffix"
log "Laerdal.Version.Revision:$revision"
log "Laerdal.Version.BuildId:$build_id"
log "Laerdal.Version.Core:$version_core"
log "Laerdal.Version.Extension:$version_extension"
log "Laerdal.Version.Full:$version_full"
log "Laerdal.Version.Assembly:$version_assembly"
log "Laerdal.Version.BranchName:$branch_name"
log "Laerdal.Version.ScriptCalled:true"


if [[ $azure_dev_ops_build -eq 1 ]]; then
    echo "##vso[task.setvariable variable=Laerdal.Version.Major;]$major"
    echo "##vso[task.setvariable variable=Laerdal.Version.Minor;]$minor"
    echo "##vso[task.setvariable variable=Laerdal.Version.Patch;]$patch"
    echo "##vso[task.setvariable variable=Laerdal.Version.Suffix;]$suffix"
    echo "##vso[task.setvariable variable=Laerdal.Version.Revision;]$revision"
    echo "##vso[task.setvariable variable=Laerdal.Version.BuildId;]$build_id"
    echo "##vso[task.setvariable variable=Laerdal.Version.Core;]$version_core"
    echo "##vso[task.setvariable variable=Laerdal.Version.Extension;]$version_extension"
    echo "##vso[task.setvariable variable=Laerdal.Version.Full;]$version_full"
    echo "##vso[task.setvariable variable=Laerdal.Version.Assembly;]$version_assembly"
    echo "##vso[task.setvariable variable=Laerdal.Version.BranchName;]$branch_name"
    echo "##vso[build.updatebuildnumber]$version_full"
    echo "##vso[task.setvariable variable=Laerdal.Version.ScriptCalled;]true"
fi

if [ "$output" != "" ]; then
    mkdir -p "$(dirname "$output")" && touch "$output" ;
    echo "Laerdal.Version.Major=$major" > $output
    echo "Laerdal.Version.Minor=$minor" >> $output
    echo "Laerdal.Version.Patch=$patch" >> $output
    echo "Laerdal.Version.Suffix=$suffix" >> $output
    echo "Laerdal.Version.Revision=$revision" >> $output
    echo "Laerdal.Version.BuildId=$build_id" >> $output
    echo "Laerdal.Version.Core=$version_core" >> $output
    echo "Laerdal.Version.Extension=$version_extension" >> $output
    echo "Laerdal.Version.Full=$version_full" >> $output
    echo "Laerdal.Version.Assembly=$version_assembly" >> $output
    echo "Laerdal.Version.BranchName=$branch_name" >> $output
fi

echo $version_full

exit 0
