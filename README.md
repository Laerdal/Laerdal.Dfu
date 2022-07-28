# Laerdal.Dfu

This is an Xamarin binding library for the Nordic Semiconductors Android library for updating the firmware of their devices over the air via Bluetooth Low Energy.

The Java library is located here: https://github.com/NordicSemiconductor/Android-DFU-Library

The native iOS Pod library is located here: https://github.com/NordicSemiconductor/IOS-Pods-DFU-Library

[![Build status](https://dev.azure.com/LaerdalMedical/Laerdal%20Nuget%20Platform/_apis/build/status/MAN-Laerdal.Dfu)](https://dev.azure.com/LaerdalMedical/Laerdal%20Nuget%20Platform/_build/latest?definitionId=121)

[![NuGet Badge](https://buildstats.info/nuget/Laerdal.Dfu?includePreReleases=true)](https://www.nuget.org/packages/Laerdal.Dfu/)

## Requirements

You'll need :

- **MacOS**
  - with **XCode**
  - with **Xamarin.iOS**
  - with **gradle**
  - with **Xamarin.Android**
  - [with **ObjectiveSharpie**] (optional)

```bash
brew cask install objectivesharpie
```

[More about Objective Sharpie](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started)

## Steps to build on Local-Dev

### 1) Checkout

```bash
git clone https://github.com/Laerdal/Laerdal.Dfu.git
```

### 2) Comment out in the .csproj files any mention of Git-related properties

### 3) Set the MSBuild version to 15.0 in Rider's settings (MSBuild 17.0+ won't build)

### 4) Run build script

There are 2 sources for the iOS package : via building the release code or using the CocoaPods.

To build the nuget via building the source code, run :

```bash
./build.sh
```

Otherwise, to download cocoapods xcframeworks :

```bash
./build.sh --use-carthage
```

You'll find the nuget in `Laerdal.Dfu.Output/`

### Known issues

- [**Invalid Swift support when submitted to the Apple AppStore**](https://github.com/Laerdal/Laerdal.Dfu.iOS/issues/3) |

Fix : https://github.com/Laerdal/Laerdal.Dfu.iOS/issues/3#issuecomment-783298581 | 

```shell
#!/usr/bin/env sh
xcode_lib_path="/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/lib/swift-5.0/iphoneos"
app_path=$1
app_name=<insert app name>
libs=("$app_path/Products/Applications/$app_name/Frameworks/"*.dylib)

for i in "${libs[@]}"
do
  cp "$xcode_lib_path/$(basename "$i")" "$app_path/SwiftSupport/iphoneos/"
  cp "$xcode_lib_path/$(basename "$i")" "$app_path/Products/Applications/$app_name/Frameworks/"
done
```

> -- Thanks [@OliverFlecke](https://github.com/OliverFlecke)

- [**ObjCRuntime.RuntimeException: Can't register the class XXX when the dynamic registrar has been linked away"**](https://github.com/Laerdal/Laerdal.Dfu.iOS/issues/1)

Fix : You might need to add "--optimize=-remove-dynamic-registrar" to your apps mtouch args.

