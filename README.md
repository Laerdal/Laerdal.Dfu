# Laerdal.Dfu

This is an Xamarin binding library for the Nordic Semiconductors Android library for updating the firmware of their devices over the air via Bluetooth Low Energy.

The Java library is located here: https://github.com/NordicSemiconductor/Android-DFU-Library

The native iOS Pod library is located here: https://github.com/NordicSemiconductor/IOS-Pods-DFU-Library

[![Build status](https://dev.azure.com/LaerdalMedical/Laerdal%20Nuget%20Platform/_apis/build/status/MAN-Laerdal.Dfu)](https://dev.azure.com/LaerdalMedical/Laerdal%20Nuget%20Platform/_build/latest?definitionId=121)

[![NuGet Badge](https://buildstats.info/nuget/Laerdal.Dfu?includePreReleases=true)](https://www.nuget.org/packages/Laerdal.Dfu/)

## Building Locally

### 1) Checkout

```bash
git clone https://github.com/Laerdal/Laerdal.Dfu.git
```
### 2) Build

```bash
dotnet msbuild Laerdal.Scripts/Laerdal.Builder.targets /m:1 /p:Laerdal_Version=9.0.x.0 /p:Laerdal_Github_Access_Token=<place your github access token here - its needed by carthage>
```

## Known issues

- Trying to use the iOS/Android flavours of this library in desktop-simulators for iOS/Android will probably result in compilation errors. If you want to perform general purpose
  UI-testing on your desktop using such simulators you need to tweak your nuget references to use the `-force-dud` nuget of `Laerdal.Dfu` like so:

```xml
<PackageReference Include="Laerdal.Dfu" Version="x.y.z-force-dud">
    <NoWarn>$(NoWarn);NU1605</NoWarn>
</PackageReference>
```

Alternatively you can achieve the same result by overriding the reference to `Laerdal.Dfu.Bindings.iOS` like so (note: this solution is only applicable for iOS and will work only
for iOS sdk 18.x or below!):

```xml
<PackageReference Include="Laerdal.Dfu.Bindings.iOS" Version="x.y.z-ios-sim-arm64">
  <NoWarn>$(NoWarn);NU1605</NoWarn>
</PackageReference>
```
