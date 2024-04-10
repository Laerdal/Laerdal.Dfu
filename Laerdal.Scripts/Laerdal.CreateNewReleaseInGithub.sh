#!/bin/bash

declare VERBOSE=0
declare TAG_VERSION=""

declare GIT_BRANCH=""
declare GITHUB_ACCESS_TOKEN=""
declare GITHUB_REPOSITORY_PATH=""

function parse_arguments() {
  while [[ $# -gt 0 ]]; do
    case $1 in

    -v | --log)
      VERBOSE=1
      shift
      ;;

    -r | --repository-path)
      GITHUB_REPOSITORY_PATH="$2"
      shift
      ;;

    -t | --tag-version)
      TAG_VERSION="$2"
      shift
      ;;

    -b | --git-branch)
      GIT_BRANCH="$2"
      shift
      ;;

    -a | --access-token)
      GITHUB_ACCESS_TOKEN="$2"
      shift
      ;;

    *)
      echo "Unknown option: $1"
      usage
      exit 1
      ;;

    esac
    shift
  done

  if [[ -z $GIT_BRANCH ]]; then
    echo "Missing git-branch."
    usage
    exit 1
  fi

  if [[ -z $GITHUB_REPOSITORY_PATH ]]; then
    echo "Missing github-repository."
    usage
    exit 1
  fi

  if [[ -z $GITHUB_ACCESS_TOKEN ]]; then
    echo "Missing github-access-token."
    usage
    exit 1
  fi

  validate_tag_format "$TAG_VERSION"
}

function validate_tag_format() {
  local -r tag="$1"
  local -r pattern='^[0-9]+\.[0-9]+(\.[0-9]+)?$'

  if ! [[ $tag =~ $pattern ]]; then
    exit_with_error "Tag format is invalid: '$tag'"
  fi
}

function usage() {
  local -r script_name=$(basename "$0")

  echo "Usage: $script_name [--verbose|-v] [--repository-path|-r]=<repository_path> [--git-branch|-b]=<branch> [--access-token|-a]=<token> [--tag-version|-t]=<version>"
}

function create_release_on_github() {
  # https://docs.github.com/en/rest/releases/releases?apiVersion=2022-11-28#create-a-release

  local eventual_tag_name=""
  local eventual_singleline_summary=""
  if [[ $GIT_BRANCH == "refs/heads/main" || $GIT_BRANCH == "refs/heads/master" ]]; then
    eventual_tag_name="v$TAG_VERSION" # builds targeting main have this simple and straightforward tag name
    eventual_singleline_summary="Release $eventual_tag_name"

  elif [[ $GIT_BRANCH == "refs/heads/develop" ]]; then # all builds that target develop are beta builds
    eventual_tag_name="v$TAG_VERSION-beta"
    eventual_singleline_summary="Beta $eventual_tag_name"

  else # all other builds that dont target main are alpha builds    should rarely happen in practice but just in case
    eventual_tag_name="v$TAG_VERSION-alpha"
    eventual_singleline_summary="Alpha $eventual_tag_name"
  fi

  local -r payload=$(
    cat <<EOF
{
  "tag_name": "$eventual_tag_name",
  "target_commitish": "$GIT_BRANCH",

  "name": "$eventual_singleline_summary",
  "generate_release_notes": true,

  "draft": false,
  "prerelease": false
}
EOF
  )

  local -r api_url="https://api.github.com/repos/$GITHUB_REPOSITORY_PATH/releases"

  echo "** Creating release on GitHub ..."

  local -r response=$(
    curl \
      -i \
      -sS \
      -X "POST" \
      -o /dev/null \
      -d "$payload" \
      -w "%{http_code}" \
      -H "Content-Type:application/json" \
      -H "Accept:application/vnd.github+json" \
      -H "Authorization: Bearer $GITHUB_ACCESS_TOKEN" \
      "$api_url"
  )
  local -r curl_exit_code=$?

  log "** api_url=$api_url"
  log "** payload=$payload"
  log "** response=$response"
  log "** curl_exit_code=$curl_exit_code"
  if [[ $curl_exit_code -ne 0 ]]; then
    exit_with_error "curl failed with exit code $?"
  fi

  local -r http_status_code="${response}"
  if [[ $http_status_code -ge 300 ]]; then
    exit_with_error "API returned HTTP status $http_status_code"
  fi
}

function log() {
  if [[ $VERBOSE -ne 0 ]]; then
    echo "$@"
  fi
}

function exit_with_error() {
  echo "Error: $1"
  exit 1
}

function main() {
  parse_arguments "$@"
  create_release_on_github
}

main "$@"
