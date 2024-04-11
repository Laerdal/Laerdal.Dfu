#!/bin/bash

# set -x # for debugging

function usage(){
    echo "usage: ./Laerdal.Version.sh [--master-branch master] [--develop-branch develop] [--major 1] [--minor 0] [--patch 0] [--revision 0] [--build-id 0] [--commit HEAD] [--branch branchname] [-o | --output version.txt] [-h | --help]"
    echo "parameters:"
    echo "  --master-branch [branch]           Name of the master branch (default is master)"
    echo "  --develop-branch [branch]          Name of the develop branch (default is develop)"
    echo "  --major [number]                   Major version override (default is 1)"
    echo "  --minor [number]                   Minor version override (default is 0)"
    echo "  --patch [number]                   Patch version override (default is 0)"
    echo "  --revision [number]                Revision version override (default is 0)"
    echo "  --build-id [number]                Build id override (default is 0)"
    echo "  --commit [hash]                    Commit hash override (default is HEAD)"
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
commit="HEAD"
output="version.txt"
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
        --commit )              shift
                                commit="$1"
                                commit_override=true
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

function warn () {
    if [ "${TF_BUILD:=}" != "" ]; then
        echo "##vso[task.logissue type=warning]$*"
    else
        echo "WARNING : $*"
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
    build_id=`git rev-list --count $commit`
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
    branch_name=`git rev-parse --abbrev-ref $commit | sed 's/refs\/heads\///g'`
fi
log "branch_name=$branch_name"

# First commit
first_commit=`git rev-list --max-parents=0 $commit`
log "first_commit=$first_commit"

# Suffix
suffix=`echo $branch_name | sed 's/\//-/'`
log "suffix=$suffix"

git fetch origin "$master_branch:$master_branch"   >/dev/null 2>&1  # its vital to do this silently otherwise the
git fetch origin "$develop_branch:$develop_branch" >/dev/null 2>&1  # output of this entire script will be malformed

if [ "$branch_name" == "$develop_branch" ]; then
    develop_master_point=`git rev-list $branch_prefix$master_branch --merges --before=\`git show -s --format=%ct $commit\` --first-parent --max-count=1`
    if [ -z $develop_master_point ]; then # has never been merged
        develop_master_point=`git merge-base $branch_prefix$master_branch $commit --fork-point`
    fi
    log "develop_master_point=$develop_master_point"

elif [ "$branch_name" != "$master_branch" ]; then
    head_develop_point=`git rev-list $branch_prefix$develop_branch --merges --before=\`git show -s --format=%ct $commit\` --first-parent --max-count=1`
    if [ -z $head_develop_point ]; then # has never been merged
        head_develop_point=$(git merge-base $branch_prefix$develop_branch $commit --fork-point)
    fi

    log "head_develop_point=$head_develop_point"
    develop_master_point=`git rev-list $branch_prefix$master_branch --merges --before=\`git show -s --format=%ct $head_develop_point\` --first-parent --max-count=1`
    if [ -z $develop_master_point ]; then # has never been merged
        develop_master_point=`git merge-base $branch_prefix$master_branch $head_develop_point --fork-point`
    fi
    log "develop_master_point=$develop_master_point"
fi


# Minor
if [ "$minor_override" != "true" ]; then
    if [ "$branch_name" == "$master_branch" ]; then
        minor=$( git rev-list "$first_commit..$commit" --count --first-parent --ancestry-path )
        
    elif [ "$branch_name" == "$develop_branch" ]; then
        minor=$( git rev-list "$first_commit..$develop_master_point" --count --first-parent --ancestry-path )
        
    else
        minor=$( git rev-list "$first_commit..$develop_master_point" --count --first-parent --ancestry-path )
    fi

else
    log "Minor version override: $minor"
fi

# Patch
if [ "$patch_override" != "true" ]; then
    if [ "$branch_name" == "$master_branch" ]; then
        patch=0

    elif [ "$branch_name" == "$develop_branch" ]; then
        declare -r before=$( git show -s --format=%ct "$develop_master_point" --first-parent --ancestry-path   )
        declare -r not=$(    git rev-list "$first_commit..$commit" --before=$before | head -n 750              )  # its vital to trim the number of parameters to around 750 otherwise we will get an error below
      
        patch=$(                                     \
            git                                      \
                rev-list                             \
                     "$first_commit..$commit"        \
                     --count                         \
                     --first-parent                  \
                     --ancestry-path                 \
                     --not $not  )  # do not doublequote $not as this will break the script

    else
        declare -r before=$( git show -s --format=%ct "$develop_master_point" --first-parent --ancestry-path     )
        declare -r not=$(    git rev-list "$first_commit..$head_develop_point" --before="$before" | head -n 750  )  # its vital to trim the number of parameters to around 750 otherwise we will get an error below

        patch=$(                                           \
          git  rev-list                                    \
                  "$first_commit..$head_develop_point"     \
                  --count                                  \
                  --first-parent                           \
                  --ancestry-path                          \
                  --not $not  )  # do not doublequote $not as this will break the script 
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
        revision=`git rev-list $head_develop_point..$commit --count`
    fi
else
    log "Revision version override: $revision"
fi

# Version extension
if [ "$branch_name" == "" ]; then
    version_extension=
elif [ "$branch_name" == "$master_branch" ]; then
    version_extension=
elif [ "$branch_name" == "$develop_branch" ]; then
    version_extension=
else
    version_extension="-$suffix-$revision.$build_id"
fi

version_core=$major.$minor.$patch
version_full=$version_core$version_extension
version_assembly=$version_core.$revision


log "Laerdal_Version_Major:$major"
log "Laerdal_Version_Minor:$minor"
log "Laerdal_Version_Patch:$patch"
log "Laerdal_Version_Suffix:$suffix"
log "Laerdal_Version_Revision:$revision"
log "Laerdal_Version_BuildId:$build_id"
log "Laerdal_Version_Core:$version_core"
log "Laerdal_Version_Extension:$version_extension"
log "Laerdal_Version_Full:$version_full"
log "Laerdal_Version_Assembly:$version_assembly"
log "Laerdal_Version_BranchName:$branch_name"
log "Laerdal_Version_ScriptCalled:true"

if [ "$output" != "" ]; then
    mkdir -p "$(dirname "$output")" && touch "$output" ;
    echo "Laerdal_Version_Major=$major" > $output
    echo "Laerdal_Version_Minor=$minor" >> $output
    echo "Laerdal_Version_Patch=$patch" >> $output
    echo "Laerdal_Version_Suffix=$suffix" >> $output
    echo "Laerdal_Version_Revision=$revision" >> $output
    echo "Laerdal_Version_BuildId=$build_id" >> $output
    echo "Laerdal_Version_Core=$version_core" >> $output
    echo "Laerdal_Version_Extension=$version_extension" >> $output
    echo "Laerdal_Version_Full=$version_full" >> $output
    echo "Laerdal_Version_Assembly=$version_assembly" >> $output
    echo "Laerdal_Version_BranchName=$branch_name" >> $output
fi

echo $version_full

exit 0
