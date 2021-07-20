#!/bin/bash

gradle_version=6.4.1

echo
echo "### DOWNLOAD ANDROID SOURCE ###"
echo

# find the latest ID here : https://api.github.com/repos/NordicSemiconductor/Android-DFU-Library/releases/latest
github_repo_owner=NordicSemiconductor
github_repo=Android-DFU-Library
github_release_id=34426039
github_info_file="$github_repo_owner.$github_repo.$github_release_id.info.json"
echo "github_repo_owner = $github_repo_owner"
echo "github_repo = $github_repo"
echo "github_release_id = $github_release_id"
echo "github_info_file = $github_info_file"

if [ ! -f "$github_info_file" ]; then
    echo
    echo "### DOWNLOAD GITHUB INFORMATION ###"
    echo
    github_info_file_url=https://api.github.com/repos/$github_repo_owner/$github_repo/releases/$github_release_id
    echo "Downloading $github_info_file_url to $github_info_file"
    curl -s $github_info_file_url > $github_info_file
fi

source_folder="Android/Source_$github_release_id"
echo "source_folder = $source_folder"

if [ ! -d "$source_folder" ]; then
    # Set version
    github_tag_name=`cat $github_info_file | grep '"tag_name":' | sed -E 's/.*"([^"]+)".*/\1/' `
    github_short_version=`echo "$github_tag_name" | sed 's/v//'`
    echo "github_tag_name = $github_tag_name"
    echo "github_short_version = $github_short_version"

    # Static configuration
    zip_folder="Android/Zips"
    zip_file_name="$github_short_version.zip"
    zip_file="$zip_folder/$zip_file_name"
    zip_url="http://github.com/$github_repo_owner/$github_repo/zipball/$github_tag_name"
    echo "zip_folder = $zip_folder"
    echo "zip_file_name = $zip_file_name"
    echo "zip_file = $zip_file"
    echo "zip_url = $zip_url"

    if [ ! -f "$zip_file" ]; then
        echo
        echo "### DOWNLOAD GITHUB RELEASE FILES ###"
        echo

        mkdir -p $zip_folder
        curl -L -o $zip_file $zip_url

        if [ ! -f "$zip_file" ]; then
            echo "Failed to download $zip_url into $zip_file"
            exit 1
        fi

        echo "Downloaded $zip_url into $zip_file"
    fi

    echo
    echo "### UNZIP SOURCE ###"
    echo

    unzip -qq -n -d "$source_folder" "$zip_file"
    if [ ! -d "$source_folder" ]; then
        echo "Failed"
        exit 1
    fi
    echo "Unzipped $zip_file into $source_folder"
else
    echo
    echo "Source folder $source_folder already exists, skipping download"
fi

echo
echo "### GRADLE BUILD ###"
echo

gradle_base_folder=$(dirname `find ./$source_folder/ -iname "gradlew" | head -n 1`)
if [ ! -d "$gradle_base_folder" ]; then
    echo "Can't find gradlew in ./$source_folder/"
    exit 1
fi
echo "sdk.dir=$HOME/Library/Developer/Xamarin/android-sdk-macosx" > $gradle_base_folder/local.properties

if [ -f "$gradle_base_folder/local.properties" ]; then
    echo "Created :"
    echo "  - $gradle_base_folder/local.properties"
    echo
else
    echo "Failed : Can't create '$gradle_base_folder/local.properties'"
    exit 1
fi

if [ ! "$gradle_version" = "" ]; then
    mv $gradle_base_folder/gradle/wrapper/gradle-wrapper.properties $gradle_base_folder/gradle/wrapper/gradle-wrapper.properties.old
    sed -E "s/gradle-.*-all.zip/gradle-$gradle_version-all.zip/" $gradle_base_folder/gradle/wrapper/gradle-wrapper.properties.old > $gradle_base_folder/gradle/wrapper/gradle-wrapper.properties
    echo "Edited :"
    echo "  - $gradle_base_folder/gradle/wrapper/gradle-wrapper.properties :"
    echo
    echo "-----------------------"
    cat $gradle_base_folder/gradle/wrapper/gradle-wrapper.properties
    echo "-----------------------"
    echo
fi

chmod +x $gradle_base_folder/gradlew
$gradle_base_folder/gradlew -version
$gradle_base_folder/gradlew assembleRelease -p $gradle_base_folder
gradle_output_file=`find ./$source_folder/ -ipath "*dfu/build/outputs/aar*" -iname "dfu-release.aar" | head -n 1`
echo

if [ -f "$gradle_output_file" ]; then
    echo "Created :"
    echo "  - $gradle_output_file"
    rm -rf $nuget_frameworks_folder
else
    echo "Failed : Can't find dfu-release.aar"
    exit 1
fi

echo
echo "### COPY AAR FILE ###"
echo

output_folder="Android/Output"
echo "Copying $gradle_output_file to $output_folder/dfu-release.aar"
rm -rf $output_folder/dfu-release.aar
mkdir -p $output_folder
cp $gradle_output_file $output_folder/dfu-release.aar

dfu_release_aar=`find $output_folder -iname "dfu-release.aar" | head -n 1`
if [ ! -f "$dfu_release_aar" ]; then
    echo "Failed : $output_folder/dfu-release.aar does not exist"
    exit 1
fi

echo "Created :"
echo "  - $dfu_release_aar"