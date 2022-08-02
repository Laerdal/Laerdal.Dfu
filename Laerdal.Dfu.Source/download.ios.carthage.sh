#!/bin/bash

# https://cocoapods.org/pods/iOSDFULibrary
# Default values
pod_author=NordicSemiconductor
pod_name=IOS-Pods-DFU-Library
pod_version=4.13.0

echo
echo "### DOWNLOAD IOS FRAMEWORK (via Carthage) ###"
echo

if ! command -v carthage &> /dev/null
then
    echo "carthage could not be found"
    echo
    echo "Run 'brew install carthage' to install it with homebrew"
    exit 1
else
    carthage_version=$(carthage version)
    echo "Carthage version : $carthage_version"
    echo
fi

usage(){
    echo "usage: ./download.ios.carthage.sh [-v|--verbose] [-o|--output path]"
    echo "parameters:"
    echo "  -v | --verbose                          Enable verbose build details from msbuild and gradle tasks"
    echo "  --pod_author                            Overrides pod_author (default: $pod_author)"
    echo "  --pod_name                              Overrides pod_name (default: $pod_name)"
    echo "  --pod_version                           Overrides pod_version (default: $pod_version)"
    echo "  -o | --output [path]                    Output path"
    echo "  -h | --help                             Prints this message"
}

while [ "$1" != "" ]; do
    case $1 in
        -o | --output )         shift
                                output_path=$1
                                ;;
        --pod_author )          shift
                                pod_author=$1
                                ;;
        --pod_name )            shift
                                pod_name=$1
                                ;;
        --pod_version )         shift
                                pod_version=$1
                                ;;
        -v | --verbose )        verbose=1
                                ;;
        -h | --help )           usage
                                exit
                                ;;
        * )                     echo
                                echo "### Wrong parameter: $1 ###"
                                echo
                                usage
                                exit 1
    esac
    shift
done

output_folder="iOS_Carthage"
temp_output_folder="$output_folder/.tmp"
rm -rf $temp_output_folder
mkdir -p $temp_output_folder

# Generates variables
echo "pod_author = $pod_author"
echo "pod_name = $pod_name"
echo "pod_version = $pod_version"

echo "github \"$pod_author/$pod_name\" == $pod_version" > $temp_output_folder/Cartfile
echo
( cd $temp_output_folder && carthage update --use-xcframeworks --platform iOS )
echo

function generate_fat_lib(){
    local xcframework=$1

    if [ ! -d "$xcframework" ]; then
        echo "Failed : generate_fat_lib takes one parameter : xcframework"
        exit 1
    fi

    local library_name=$(basename $xcframework .xcframework)

    local iphoneos_directory="$xcframework/ios-arm64_armv7"
    local iphoneos_framework="$iphoneos_directory/$library_name.framework"
    local iphoneos_framework_file="$iphoneos_framework/$library_name"

    local iphonesimulator_directory="$xcframework/ios-arm64_i386_x86_64-simulator"
    local iphonesimulator_framework="$iphonesimulator_directory/$library_name.framework"
    local iphonesimulator_framework_file="$iphonesimulator_framework/$library_name"

    local fat_directory="$xcframework/ios-fat"
    cp -r $iphoneos_directory $fat_directory
    local fat_framework="$fat_directory/$library_name.framework"
    local fat_framework_file="$fat_framework/$library_name"
    local fat_framework_symbols="$fat_directory/dSYMs/$library_name.framework.dSYM"
    rm -rf $fat_framework_file

    echo
    if [ "$verbose" = "1" ]; then
        (cd $(dirname $iphoneos_framework_file) && lipo -info $(basename $iphoneos_framework_file))
        echo "+"
        (cd $(dirname $iphonesimulator_framework_file) && lipo -info $(basename $iphonesimulator_framework_file))
        echo "="
    fi
    lipo -remove arm64 -output $iphonesimulator_framework_file $iphonesimulator_framework_file
    lipo -create -output $fat_framework_file $iphoneos_framework_file $iphonesimulator_framework_file
    (cd $(dirname $fat_framework_file) && lipo -info $(basename $fat_framework_file))

    mkdir -p $output_folder
    cp -r $fat_framework "$output_folder/$library_name.framework"
    cp -r $fat_framework_symbols "$output_folder/$library_name.framework.dSYM"
}

xcframeworks=`find $temp_output_folder -iname "*.xcframework"`

for i in $xcframeworks
do
    generate_fat_lib $i
done

rm -rf $temp_output_folder

echo
echo $pod_version > "$output_folder/version.txt"

echo "Created :"
for i in $output_folder/*
do
    echo "  - $i"
done

if [ ! -z "$output_path" ]; then

    echo
    echo "### COPY FILES TO OUTPUT ###"
    echo

    mkdir -p $output_path
    cp -a $output_folder/. $output_path

    echo "Copied files into $output_path"
    rm -rf $output_folder
fi