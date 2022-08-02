#!/bin/bash
 
master_branch="main"
develop_branch="develop"
if [ "$TF_BUILD" = "true" ]; then
    branch_name=$(Build.SourceBranchName)
else
    branch_name=$(git name-rev HEAD --name-only)
fi
first_commit=$(git rev-list --max-parents=0 HEAD)
major=1
minor=0
patch=0
suffix=
 
if [ "$branch_name" == "$master_branch" ]; then
    minor=$(git rev-list $first_commit..HEAD --count --first-parent --ancestry-path)
elif [ "$branch_name" == "$develop_branch" ]; then
 
    develop_master_point=$(git rev-list origin/$master_branch --merges --before=$(git show -s --format=%ct HEAD) --first-parent --max-count=1)
    if [ -z $develop_master_point ]; then
        # has never been merged,
        develop_master_point=$(git merge-base origin/$master_branch HEAD --fork-point)
    fi
 
    minor=$(git rev-list $first_commit..$develop_master_point --count --first-parent --ancestry-path)
    patch=$(git rev-list $first_commit..HEAD --count --first-parent --ancestry-path --not $(git rev-list $first_commit..HEAD --before=$(git show -s --format=%ct $develop_master_point --first-parent --ancestry-path)))
else
    head_develop_point=$(git rev-list origin/$develop_branch --merges --before=$(git show -s --format=%ct HEAD) --first-parent --max-count=1)
    if [ -z $head_develop_point ]; then
        # has never been merged,
        head_develop_point=$(git merge-base origin/$develop_branch HEAD --fork-point)
    fi
 
    develop_master_point=$(git rev-list origin/$master_branch --merges --before=$(git show -s --format=%ct $head_develop_point) --first-parent --max-count=1)
    if [ -z $develop_master_point ]; then
        # has never been merged,
        develop_master_point=$(git merge-base origin/$master_branch $head_develop_point --fork-point)
    fi
    commitCount=$(git rev-list $first_commit..HEAD --count --first-parent --ancestry-path --not $(git rev-list $first_commit..HEAD --before=$(git show -s --format=%ct $head_develop_point --first-parent --ancestry-path)))
    clean_branch_name=$(echo $branch_name | sed 's/\//_/')
 
    minor=$(git rev-list $first_commit..$develop_master_point --count --first-parent --ancestry-path)
    patch=$(git rev-list $first_commit..$head_develop_point --count --first-parent --ancestry-path --not $(git rev-list $first_commit..$head_develop_point --before=$(git show -s --format=%ct $develop_master_point --first-parent --ancestry-path)))
 
    suffix="-$clean_branch_name-$commitCount"
fi
 
echo "$major.$minor.$patch$suffix"
exit 0