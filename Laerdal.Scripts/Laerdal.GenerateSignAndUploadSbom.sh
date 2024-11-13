#!/bin/bash

# set -x

declare project_name=""
declare project_version=""

declare parent_project_name=""
declare parent_project_version=""

declare csproj_file_path=""
declare csproj_classifier=""
declare output_directory_path=""
declare output_sbom_file_name=""
declare sbom_signing_key_file_path=""

declare dependency_tracker_url=""
declare dependency_tracker_api_key_file_path=""

function parse_arguments() {

  while [[ $# -gt 0 ]]; do
    case $1 in
    
    --project-name)
      project_name="$2"
      shift
      ;;
    
    --project-version)
      project_version="$2"
      shift
      ;;
    
    --parent-project-name)
      parent_project_name="$2"
      shift
      ;;

    --parent-project-version)
      parent_project_version="$2"
      shift
      ;;

    --csproj-file-path)
      csproj_file_path="$2"
      shift
      ;;

    --csproj-classifier)
      csproj_classifier="$2"
      shift
      ;;

    --output-directory-path)
      output_directory_path="$2"
      shift
      ;;
    
    --output-sbom-file-name)
      output_sbom_file_name="$2"
      shift
      ;;

    --sbom-signing-key-file-path)
      sbom_signing_key_file_path="$2"
      shift
      ;;

    --dependency-tracker-url)
      dependency_tracker_url="$2"
      shift
      ;;

    --dependency-tracker-api-key-file-path)
      dependency_tracker_api_key_file_path="$2"
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

  if [[ -z ${project_name} ]]; then
    echo "Specifying --project-name is mandatory!"
    usage
    exit 1
  fi

  if [[ -z ${project_version} ]]; then
    echo "Specifying --project-version is mandatory!"
    usage
    exit 1
  fi

  # if [[ -z ${parent_project_name} ]]; then         this is optional
  #      ...

  # if [[ -z ${parent_project_version} ]]; then         this is optional
  #      ...
  
  # if [[ -n ${parent_project_name} && -z ${parent_project_version} ]]; then # nah   better not to enforce this
  #   echo "Specifying --parent-project-version is mandatory when --parent-project-name has been used!"
  #   usage
  #   exit 1    
  # fi

  if [[ -z ${csproj_file_path} ]]; then
    echo "Specifying --csproj-file-path is mandatory!"
    usage
    exit 1
  fi

  if [[ -z ${csproj_classifier} ]]; then
    echo "Specifying --csproj-classifier is mandatory!"
    usage
    exit 1
  fi

  if [[ -z ${output_directory_path} ]]; then
    echo "Specifying --output-directory-path is mandatory!"
    usage
    exit 1
  fi

  if [[ -z ${output_sbom_file_name} ]]; then
    echo "Specifying --output-sbom-file-name is mandatory!"
    usage
    exit 1
  fi
  
  if [[ -z ${sbom_signing_key_file_path} ]]; then
    echo "Specifying --sbom-signing-key-file-path is mandatory!"
    usage
    exit 1
  fi
  
  if [[ -z ${dependency_tracker_url} ]]; then
    echo "Specifying --dependency-tracker-url is mandatory!"
    usage
    exit 1
  fi

  if [[ -z ${dependency_tracker_api_key_file_path} ]]; then
    echo "Specifying --dependency-tracker-api-key-file-path is mandatory!"
    usage
    exit 1
  fi
}

function usage() {
  local -r script_name=$(basename "$0")

  echo "Usage: ${script_name}  --project-name  <name>   --project-version <version>   [--parent-project-name  <name>   --parent-project-version <version>]   --csproj-file-path <path>    --csproj-file-path <path>   --output-directory-path <path>  --output-sbom-file-name <name>   --sbom-signing-key-file-path <path>   --dependency-tracker-url <url>   --dependency-tracker-api-key-file-path <api_key>  "
}

function install_tools() {

  echo
  echo "** Installing CycloneDX as a dotnet tool:"
  dotnet   tool       \
           install    \
               --global   CycloneDX
  declare exitCode=$?
  if [ $exitCode != 0 ]; then
    echo "##vso[task.logissue type=error]Something went wrong with the CycloneDX tool for dotnet."
    exit 10
  fi

  echo
  echo "** CycloneDX:"
  which    dotnet-CycloneDX   &&   dotnet-CycloneDX   --version
  declare exitCode=$?
  if [ $exitCode != 0 ]; then
    echo "##vso[task.logissue type=error]Something's wrong with 'dotnet-CycloneDX'."
    exit 12
  fi

  # we need to install the CycloneDX tool too in order to sign the artifacts
  curl         --output cyclonedx    --url https://github.com/CycloneDX/cyclonedx-cli/releases/download/v0.26.0/cyclonedx-win-x64.exe \
    && chmod   +x       cyclonedx
  declare exitCode=$?
  if [ $exitCode != 0 ]; then
    echo "##vso[task.logissue type=error]Failed to install 'cyclonedx'."
    exit 13
  fi

}

function generate_sign_and_upload_sbom() {
  # set -x

  # GENERATE SBOM   we intentionally disable package restore because the packages are already restored at this point
  dotnet-CycloneDX      "${csproj_file_path}"             \
        --exclude-dev                                     \
        --disable-package-restore                         \
        --include-project-references                      \
                                                          \
        --output      "${output_directory_path}"          \
        --set-type    "${csproj_classifier}"              \
        --set-version "${project_version}"                \
                                                          \
        --filename "${output_sbom_file_name}"
  declare exitCode=$?
  if [ ${exitCode} != 0 ]; then
    echo "##vso[task.logissue type=error]Failed to generate the SBOM!"
    exit 20
  fi



  # SIGN SBOM     todo  figure out why this doesnt actually sign anything on windows even though on macos it works as intended
  declare -r bom_file_path="${output_directory_path}/${output_sbom_file_name}"
  ./cyclonedx  sign   bom             \
               "${bom_file_path}"     \
               --key-file   "${sbom_signing_key_file_path}"
  declare exitCode=$?
  if [ ${exitCode} != 0 ]; then
    echo "##vso[task.logissue type=error]Singing the SBOM failed!"
    exit 30
  fi
  #  echo -e "\n\n"
  #  tail "${bom_file_path}"
  #  echo -e "\n\n"



  # UPLOAD SBOM
  declare optional_parent_project_name_parameter=""
  if [[ -n ${parent_project_name} ]]; then
      optional_parent_project_name_parameter="--form parentName=${parent_project_name}"
  fi
  
  declare optional_parent_project_version_parameter=""
  if [[ -n ${parent_project_version} ]]; then
      optional_parent_project_version_parameter="--form parentVersion=${parent_project_version}"
  fi

  declare -r http_response_code=$(                                                                       \
      curl   "${dependency_tracker_url}"                                                                 \
                                --location                                                               \
                                --request "POST"                                                         \
                                                                                                         \
                                --header "Content-Type: multipart/form-data"                             \
                                --header "X-API-Key: $(cat "${dependency_tracker_api_key_file_path}")"   \
                                                                                                         \
                                --form "bom=@${bom_file_path}"                                           \
                                --form "autoCreate=true"                                                 \
                                                                                                         \
                                --form "projectName=${project_name}"                                     \
                                --form "projectVersion=${project_version}"                               \
                                                                                                         \
                                ${optional_parent_project_name_parameter}                                \
                                ${optional_parent_project_version_parameter}                             \
                                                                                                         \
                                -w "%{http_code}"                                                        \
  )
  declare exitCode=$?
  set +x
  
  echo "** Curl sbom-uploading HTTP Response Code: ${http_response_code}"
  
  if [ ${exitCode} != 0 ]; then
    echo "##vso[task.logissue type=error]SBOM Uploading failed!"
    exit 40
  fi
}

function main() {
  parse_arguments "$@"
  install_tools
  generate_sign_and_upload_sbom
}

main "$@"
