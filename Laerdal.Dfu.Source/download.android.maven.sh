#!/bin/bash

# https://search.maven.org/artifact/no.nordicsemi.android/dfu
# Default values
artifact_group_id=no.nordicsemi.android
artifact_id=dfu
artifact_version=2.1.0
artifact_type=aar

echo
echo "### DOWNLOAD ANDROID AAR (via Maven) ###"
echo

if ! command -v mvn &> /dev/null
then
    echo "mvn could not be found"
    echo
    echo "Run 'brew install mvn' to install it with homebrew"
    exit 1
else
    mvn -v
    echo
fi

usage(){
    echo "usage: ./download.android.maven.sh [-v|--verbose] [-o|--output path]"
    echo "parameters:"
    echo "  -v | --verbose                          Enable verbose build details from msbuild and gradle tasks"
    echo "  --artifact_group_id                     Overrides artifact_group_id (default: $artifact_group_id)"
    echo "  --artifact_id                           Overrides artifact_id (default: $artifact_id)"
    echo "  --artifact_version                      Overrides artifact_version (default: $artifact_version)"
    echo "  --artifact_type                         Overrides artifact_type (default: $artifact_type)"
    echo "  -o | --output [path]                    Output path"
    echo "  -h | --help                             Prints this message"
}


while [ "$1" != "" ]; do
    case $1 in
        -o | --output )         shift
                                output_path=$1
                                ;;
        --artifact_group_id )   shift
                                artifact_group_id=$1
                                ;;
        --artifact_id )         shift
                                artifact_id=$1
                                ;;
        --artifact_version )    shift
                                artifact_version=$1
                                ;;
        --artifact_type )  shift
                                artifact_type=$1
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

temp_output_folder="Android_Maven"
rm -rf $temp_output_folder
mkdir -p $temp_output_folder

# Generates variables
echo "artifact_group_id = $artifact_group_id"
echo "artifact_id = $artifact_id"
echo "artifact_version = $artifact_version"
echo "artifact_type = $artifact_type"

echo
if [ "$verbose" = "1" ]; then
echo "mvn dependency:get -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:$artifact_type -Dtransitive=false"
echo
fi
mvn dependency:get -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:aar -Dtransitive=false
echo
if [ "$verbose" = "1" ]; then
echo "mvn dependency:copy -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:aar -DoutputDirectory=$temp_output_folder -Dmdep.stripVersion=true"
echo
fi
mvn dependency:copy -Dartifact=$artifact_group_id:$artifact_id:$artifact_version:aar -DoutputDirectory=$temp_output_folder -Dmdep.stripVersion=true
echo

dfu_release_aar=`find $temp_output_folder -iname "dfu.aar" | head -n 1`

if [ ! -f "$dfu_release_aar" ]; then
    echo "Failed : $temp_output_folder/dfu.aar does not exist"
    exit 1
fi

echo $artifact_version > "$temp_output_folder/version.txt"

echo "Created :"
echo "  - $dfu_release_aar"
echo "  - $temp_output_folder/version.txt"

if [ ! -z "$output_path" ]; then

    echo
    echo "### COPY FILES TO OUTPUT ###"
    echo

    mkdir -p $output_path
    cp -a $temp_output_folder/. $output_path

    echo "Copied files into $output_path"
    rm -rf $temp_output_folder
fi