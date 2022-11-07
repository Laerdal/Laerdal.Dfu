#!/bin/bash

usage(){
    echo "usage: ./build.sh [-v|--verbose] [-o|--output path] [-ov|--output-version version] [--skip-download]"
    echo "parameters:"
    echo "  -v | --verbose                          Enable verbose build details from msbuild and gradle tasks"
    echo "  -o | --output [path]                    Output path"
    echo "  --skip-download                         Skip downloading the native libraries"
    echo "  -ov | --output-version [version]        Version of the Nuget package"
    echo "  -h | --help                             Prints this message"
}

while [ "$1" != "" ]; do
    case $1 in
        -o | --output )             shift
                                    output_path=$1
                                    ;;
        -ov | --output-version )    shift
                                    output_version=$1
                                    ;;
        -v | --verbose )            verbose=1
                                    ;;
        --skip-download )           skip_download=1
                                    ;;
        -h | --help )               usage
                                    exit
                                    ;;
        * )                         echo
                                    echo "### Wrong parameter: $1 ###"
                                    echo
                                    usage
                                    exit 1
    esac
    shift
done

echo ""
echo "### MSBUILD ###"
echo ""



msbuild_parameters=""
if [ "$verbose" = "1" ]; then
    msbuild_parameters="${msbuild_parameters}"
else
    msbuild_parameters="${msbuild_parameters} -nologo -verbosity:quiet"
fi

if [ "$skip_download" = "1" ]; then
    msbuild_parameters="${msbuild_parameters} -p:DownloadNativeFiles=false"
fi

msbuild_parameters="${msbuild_parameters} -restore:True"
msbuild_parameters="${msbuild_parameters} -p:Configuration=Release"
if [ ! "$output_version" = "" ]; then
    msbuild_parameters="${msbuild_parameters} -p:PackageVersion=$output_version"
fi
if [ ! "$output_path" = "" ]; then
    msbuild_parameters="${msbuild_parameters} -p:PackageOutputPath=$output_path"
fi

msbuild_parameters="${msbuild_parameters} -p:LaerdalPackageDescription=\"Xamarin wrapper around Nordic.Dfu for iOS (NordicSemiconductor:IOS-Pods-DFU-Library) and Android (no.nordicsemi.android:dfu).\""

echo "msbuild_parameters = $msbuild_parameters"
echo ""

msbuild Laerdal.Dfu/Laerdal.Dfu.csproj $msbuild_parameters
