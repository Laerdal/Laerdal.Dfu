#!/bin/bash

# set -x

# this script is meant to be used only in our azure pipelines to setup the
# build environment for the xamarin bindings   its not meant to be used on localdev

# windows-2022 vmimages in azure have dotnet 8.0.100 preinstalled so we should be fine 


declare -r NUGET_FEED_URL="$1"
declare -r NUGET_FEED_USERNAME="$2"
declare -r NUGET_FEED_ACCESSTOKEN="$3"

declare -r ARTIFACTS_FOLDER_PATH="$4"

if [ -z "${NUGET_FEED_URL}" ]; then
  echo "##vso[task.logissue type=error]Missing 'NUGET_FEED_URL' which was expected to be parameter #1."
  exit 3
fi

if [ -z "${NUGET_FEED_USERNAME}" ]; then
  echo "##vso[task.logissue type=error]Missing 'NUGET_FEED_USERNAME' which was expected to be parameter #2."
  exit 5
fi

if [ -z "${NUGET_FEED_ACCESSTOKEN}" ]; then
  echo "##vso[task.logissue type=error]Missing 'NUGET_FEED_ACCESSTOKEN' which was expected to be parameter #3."
  exit 6
fi

if [ -z "${ARTIFACTS_FOLDER_PATH}" ]; then
  echo "##vso[task.logissue type=error]Missing 'ARTIFACTS_FOLDER_PATH' which was expected to be parameter #4."
  exit 7
fi


echo
echo "** Dotnet SDKs:"
dotnet --list-sdks
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Failed to list sdks."
  exit 15
fi

echo
echo "** Dotnet CLI:"
which    dotnet   &&   dotnet   --version
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Something's wrong with 'dotnet' cli."
  exit 20
fi

#
# we do our best to explicitly version-pin our workloads so as to preemptively avoid problems that
# would be bound to crop up sooner or later by blindly auto-upgrading to bleeding-edge workloads
#
cd "Laerdal.Dfu"
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Failed to cd to Laerdal.Dfu."
  exit 30
fi

# declare dotnet_8_workload_version="8.0.3"
dotnet                                \
             workload                 \
             install                  \
                 maui                 \
                 ios                  \
                 android
#                    --from-rollback-file=https://maui.blob.core.windows.net/metadata/rollbacks/${dotnet_8_workload_version}.json   # we need to install additional packages manually
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Failed to restore dotnet workloads."
  exit 40
fi

cd -
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Failed to cd back to the root folder."
  exit 50
fi

echo
echo "** Adding 'Artifacts' Folder as a Nuget Source (dotnet):"
mkdir -p "${ARTIFACTS_FOLDER_PATH}"   &&   dotnet   nuget   add   source   "${ARTIFACTS_FOLDER_PATH}"   --name "LocalArtifacts"
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Failed to add 'Artifacts' folder as a nuget source."
  exit 60
fi

echo
echo "** Adding 'Laerdal Nuget Feed' as a Nuget Source:"
# keep this after workload-restoration   otherwise we will run into problems    note that the 'store-password-in-clear-text'
# is necessary for azure pipelines   once we move fully over to github actions we can remove this parameter completely
dotnet   nuget   add                                \
    source      "${NUGET_FEED_URL}"                 \
    --name      "LaerdalMedical"                    \
    --username  "${NUGET_FEED_USERNAME}"            \
    --password  "${NUGET_FEED_ACCESSTOKEN}"
declare exitCode=$?
if [ $exitCode != 0 ]; then
  echo "##vso[task.logissue type=error]Failed to add 'Laerdal Nuget Feed' as a nuget source."
  exit 65
fi

dotnet nuget list source
