#!/bin/bash

usage(){
    echo "usage: ./build.sh [-r|--revision build_revision] [-c|--clean-output] [-v|--verbose] [-o|--output path]"
    echo "parameters:"
    echo "  -c | --clean-output                     Cleans the output before building"
    echo "  -v | --verbose                          Enable verbose build details from msbuild and gradle tasks"
    echo "  --use-carthage                          Use cocoa pods binary via carthage"
    echo "  -o | --output [path]                    Output path"
    echo "  -h | --help                             Prints this message"
}

while [ "$1" != "" ]; do
    case $1 in
        -o | --output )         shift
                                output_path=$1
                                ;;
        -c | --clean-output )   clean_output=1
                                ;;
        --use-carthage )        use_carthage=1
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

echo
echo "### INFORMATION ###"
echo

# Static configuration
nuget_project_folder="Laerdal.Xamarin.Dfu"
nuget_project_name="Laerdal.Xamarin.Dfu"
nuget_output_folder="$nuget_project_name.Output"
nuget_csproj_path="$nuget_project_folder/$nuget_project_name.csproj"
nuget_jars_folder="$nuget_project_folder/Droid/Jars"
nuget_frameworks_folder="$nuget_project_folder/iOS/Frameworks"

# Generates variables
echo "nuget_project_folder = $nuget_project_folder"
echo "nuget_output_folder = $nuget_output_folder"
echo "nuget_project_name = $nuget_project_name"
echo "nuget_csproj_path = $nuget_csproj_path"

if [ "$clean_output" = "1" ]; then
    echo
    echo "### CLEAN OUTPUT ###"
    echo
    rm -rf $nuget_output_folder
    echo "Deleted : $nuget_output_folder"
fi

pushd Laerdal.Xamarin.Dfu.Source
./download.android.sh
if [ "$use_carthage" = "1" ]; then
    ./download.ios.carthage.sh
else 
    ./download.ios.sh
fi
popd

if [ "$use_carthage" = "1" ]; then
    iOSDFULibrary_fat_framework=`find ./Laerdal.Xamarin.Dfu.Source/iOS_Carthage/Carthage/Build/iOSDFULibrary.xcframework/ios-fat -iname "iOSDFULibrary.framework" | head -n 1`
    if [ ! -d "$iOSDFULibrary_fat_framework" ]; then
        echo "Failed : iOSDFULibrary_fat_framework does not exist"
        exit 1
    fi
    iOSDFULibrary_fat_framework_dsym=`find ./Laerdal.Xamarin.Dfu.Source/iOS_Carthage/Carthage/Build/iOSDFULibrary.xcframework/ios-fat -iname "iOSDFULibrary.framework.dSYM" | head -n 1`
    if [ ! -d "$iOSDFULibrary_fat_framework_dsym" ]; then
        echo "Failed : iOSDFULibrary_fat_framework_dsym does not exist"
        exit 1
    fi
    ZIPFoundation_fat_framework=`find ./Laerdal.Xamarin.Dfu.Source/iOS_Carthage/Carthage/Build/ZIPFoundation.xcframework/ios-fat -iname "ZIPFoundation.framework" | head -n 1`
    if [ ! -d "$ZIPFoundation_fat_framework" ]; then
        echo "Failed : ZIPFoundation_fat_framework does not exist"
        exit 1
    fi
    ZIPFoundation_fat_framework_dsym=`find ./Laerdal.Xamarin.Dfu.Source/iOS_Carthage/Carthage/Build/ZIPFoundation.xcframework/ios-fat -iname "ZIPFoundation.framework.dSYM" | head -n 1`
    if [ ! -d "$ZIPFoundation_fat_framework_dsym" ]; then
        echo "Failed : ZIPFoundation_fat_framework_dsym does not exist"
        exit 1
    fi
else
    iOSDFULibrary_fat_framework=`find ./Laerdal.Xamarin.Dfu.Source/iOS/Frameworks -iname "iOSDFULibrary.framework" | head -n 1`
    if [ ! -d "$iOSDFULibrary_fat_framework" ]; then
        echo "Failed : iOSDFULibrary_fat_framework does not exist"
        exit 1
    fi
    iOSDFULibrary_fat_framework_dsym=`find ./Laerdal.Xamarin.Dfu.Source/iOS/Frameworks -iname "iOSDFULibrary.framework.dSYM" | head -n 1`
    if [ ! -d "$iOSDFULibrary_fat_framework_dsym" ]; then
        echo "Failed : iOSDFULibrary_fat_framework_dsym does not exist"
        exit 1
    fi
    ZIPFoundation_fat_framework=`find ./Laerdal.Xamarin.Dfu.Source/iOS/Frameworks -iname "ZIPFoundation.framework" | head -n 1`
    if [ ! -d "$ZIPFoundation_fat_framework" ]; then
        echo "Failed : ZIPFoundation_fat_framework does not exist"
        exit 1
    fi
    ZIPFoundation_fat_framework_dsym=`find ./Laerdal.Xamarin.Dfu.Source/iOS/Frameworks -iname "ZIPFoundation.framework.dSYM" | head -n 1`
    if [ ! -d "$ZIPFoundation_fat_framework_dsym" ]; then
        echo "Failed : ZIPFoundation_fat_framework_dsym does not exist"
        exit 1
    fi
fi

dfu_release_aar=`find ./Laerdal.Xamarin.Dfu.Source/Android/Output -iname "dfu-release.aar" | head -n 1`
if [ ! -f "$dfu_release_aar" ]; then
    echo "Failed : dfu_release_aar does not exist"
    exit 1
fi

echo "Created :"
echo "  - $dfu_release_aar"
echo "  - $iOSDFULibrary_fat_framework"
echo "  - $ZIPFoundation_fat_framework"
echo "  - $iOSDFULibrary_fat_framework_dsym"
echo "  - $ZIPFoundation_fat_framework_dsym"

echo ""
echo "### COPY NATIVE FILES ###"
echo ""

echo "Copying $dfu_release_aar to $nuget_jars_folder/dfu-release.aar"
rm -rf $nuget_jars_folder/dfu-release.aar
mkdir -p $nuget_jars_folder
cp $dfu_release_aar $nuget_jars_folder/dfu-release.aar

echo "Copying $iOSDFULibrary_fat_framework to $nuget_frameworks_folder/iOSDFULibrary.framework"
rm -rf $nuget_frameworks_folder/iOSDFULibrary.framework
mkdir -p $nuget_frameworks_folder/iOSDFULibrary.framework
cp -a $iOSDFULibrary_fat_framework/. $nuget_frameworks_folder/iOSDFULibrary.framework

echo "Copying $ZIPFoundation_fat_framework to $nuget_frameworks_folder/ZIPFoundation.framework"
rm -rf $nuget_frameworks_folder/ZIPFoundation.framework
mkdir -p $nuget_frameworks_folder/ZIPFoundation.framework
cp -a $ZIPFoundation_fat_framework/. $nuget_frameworks_folder/ZIPFoundation.framework

echo "Copying $iOSDFULibrary_fat_framework_dsym to $nuget_frameworks_folder/iOSDFULibrary.framework.dSYM"
rm -rf $nuget_frameworks_folder/iOSDFULibrary.framework.dSYM
mkdir -p $nuget_frameworks_folder/iOSDFULibrary.framework.dSYM
cp -a $iOSDFULibrary_fat_framework_dsym/. $nuget_frameworks_folder/iOSDFULibrary.framework.dSYM

echo "Copying $ZIPFoundation_fat_framework_dsym to $nuget_frameworks_folder/ZIPFoundation.framework.dSYM"
rm -rf $nuget_frameworks_folder/ZIPFoundation.framework.dSYM
mkdir -p $nuget_frameworks_folder/ZIPFoundation.framework.dSYM
cp -a $ZIPFoundation_fat_framework_dsym/. $nuget_frameworks_folder/ZIPFoundation.framework.dSYM

echo ""
echo "### MSBUILD ###"
echo ""

msbuild_parameters=""
if [ ! "$verbose" = "1" ]; then
    msbuild_parameters="${msbuild_parameters} -nologo -verbosity:quiet"
fi
msbuild_parameters="${msbuild_parameters} -t:Rebuild"
msbuild_parameters="${msbuild_parameters} -restore:True"
msbuild_parameters="${msbuild_parameters} -p:Configuration=Release"
echo "msbuild_parameters = $msbuild_parameters"
echo ""

rm -rf $nuget_project_folder/bin
rm -rf $nuget_project_folder/obj
msbuild $nuget_csproj_path $msbuild_parameters

if [ ! -z "$output_path" ]; then

    echo
    echo "### COPY FILES TO OUTPUT ###"
    echo

    mkdir -p $output_path
    cp -a $nuget_output_folder/. $output_path

    echo "Copied into $output_path"
fi