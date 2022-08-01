#!/bin/bash

echo
echo "### DOWNLOAD ANDROID SOURCE (via Maven) ###"
echo


output_folder="Android_Maven"
echo "output_folder = $output_folder"

mkdir -p $output_folder

echo
echo "-----------------------"
mvn -v
echo "-----------------------"
echo

artifact_group_id=no.nordicsemi.android
artifact_id=dfu
artifact_version=2.0.3
artifact_type=aar

echo "mvn dependency:get -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:$artifact_type -Dtransitive=false"
echo
mvn dependency:get -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:aar -Dtransitive=false
echo

echo "mvn dependency:copy -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:aar -DoutputDirectory=$output_folder -Dmdep.stripVersion=true"
echo
mvn dependency:copy -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:aar -DoutputDirectory=$output_folder -Dmdep.stripVersion=true
echo

dfu_release_aar=`find $output_folder -iname "dfu.aar" | head -n 1`
if [ ! -f "$dfu_release_aar" ]; then
    echo "Failed : $output_folder/dfu.aar does not exist"
    exit 1
fi

echo "Created :"
echo "  - $dfu_release_aar"