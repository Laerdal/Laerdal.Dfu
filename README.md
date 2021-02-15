# Laerdal.Xamarin.Dfu

This is an Xamarin binding library for the Nordic Semiconductors Android library for updating the firmware of their devices over the air via Bluetooth Low Energy.

The Java library is located here: https://github.com/NordicSemiconductor/Android-DFU-Library

The native iOS Pod library is located here: https://github.com/NordicSemiconductor/IOS-Pods-DFU-Library


[![Build status](https://dev.azure.com/LaerdalMedical/Laerdal%20Nuget%20Platform/_apis/build/status/MAN-Laerdal.Xamarin.Dfu.Android)](https://dev.azure.com/LaerdalMedical/Laerdal%20Nuget%20Platform/_build/latest?definitionId=110)

[![NuGet Badge](https://buildstats.info/nuget/Laerdal.Xamarin.Dfu?includePreReleases=true)](https://www.nuget.org/packages/Laerdal.Xamarin.Dfu/)

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

## Steps to build

### 1) Checkout

```bash
git clone https://github.com/Laerdal/Laerdal.Xamarin.Dfu.git
```

### 2) Run build script

There are 2 sources for the iOS package : via building the release code or using the CocoaPods.

To build the nuget via building the source code, run :

```bash
./build.sh
```

Otherwise, to download cocoapods xcframeworks :

```bash
./build.sh --use-carthage
```

You'll find the nuget in `Laerdal.Xamarin.Dfu.Output/`
