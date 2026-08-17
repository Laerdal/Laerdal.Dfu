# Laerdal.Dfu

[![CI](https://img.shields.io/github/actions/workflow/status/Laerdal/Laerdal.Dfu/github-actions.yml?branch=main&logo=github&label=build)](https://github.com/Laerdal/Laerdal.Dfu/actions/workflows/github-actions.yml)
[![NuGet](https://img.shields.io/nuget/v/Laerdal.Dfu?logo=nuget&color=004880)](https://www.nuget.org/packages/Laerdal.Dfu/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Laerdal.Dfu?logo=nuget&color=004880)](https://www.nuget.org/packages/Laerdal.Dfu/)
[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/github/license/Laerdal/Laerdal.Dfu?color=blue)](LICENSE)

A .NET MAUI binding library wrapping Nordic Semiconductor's native DFU (Device Firmware Update)
SDKs for **Android** and **iOS/MacCatalyst**, giving you a single cross-platform API to update
Nordic-based Bluetooth Low Energy devices over the air.

Native libraries wrapped:

- **Android** — [Android-DFU-Library](https://github.com/NordicSemiconductor/Android-DFU-Library), via [`Laerdal.Dfu.Bindings.Android`](https://github.com/Laerdal/Laerdal.Dfu.Bindings.Android)
- **iOS / MacCatalyst** — [IOS-Pods-DFU-Library](https://github.com/NordicSemiconductor/IOS-Pods-DFU-Library), via [`Laerdal.Dfu.Bindings.iOS`](https://github.com/Laerdal/Laerdal.Dfu.Bindings.iOS)

## Platform Support

| Platform         | Supported |
|------------------|-----------|
| Android          | ✅        |
| iOS              | ✅        |
| MacCatalyst      | ✅        |
| Windows / other  | ⚠️ "dud" build only — compiles but throws at runtime; useful for desktop UI testing, see [Known issues](#known-issues) |

## Installation

```bash
dotnet add package Laerdal.Dfu
```

## Sample App

[`Laerdal.Dfu.Sample`](Laerdal.Dfu.Sample) in this repo is a working .NET MAUI app demonstrating
BLE scanning and a full firmware-update flow using this library.

## Building Locally

```bash
git clone https://github.com/Laerdal/Laerdal.Dfu.git
cd Laerdal.Dfu
dotnet build Laerdal.Dfu/Laerdal.Dfu.csproj
```

Building the Android/iOS/MacCatalyst targets requires the corresponding .NET MAUI workloads to be
installed locally; CI builds and publishes all targets on every push to `main`/`master` via
[`github-actions.yml`](.github/workflows/github-actions.yml).

## Known issues

- Using the iOS/Android flavours of this library from a desktop simulator (e.g. for general-purpose
  UI testing) will fail to compile. Work around it with the `-force-dud` build of `Laerdal.Dfu`:

  ```xml
  <PackageReference Include="Laerdal.Dfu" Version="x.y.z-force-dud">
      <NoWarn>$(NoWarn);NU1605</NoWarn>
  </PackageReference>
  ```

  Or, for iOS specifically (SDK 18.x and below only), override just the native binding instead:

  ```xml
  <PackageReference Include="Laerdal.Dfu.Bindings.iOS" Version="x.y.z-ios-sim-arm64">
    <NoWarn>$(NoWarn);NU1605</NoWarn>
  </PackageReference>
  ```

- [`Laerdal.Dfu.Bindings.Android`](https://github.com/Laerdal/Laerdal.Dfu.Bindings.Android) (a
  dependency of this package) hardcodes its own Android `TargetPlatformVersion` rather than
  floating it the way this project does — see that repo's own README "Known issues" for why that's
  a latent risk, not yet a live one. If an Android DFU build ever starts silently misbehaving after
  bumping either project's `TargetPlatformVersion`, check there first.

## License

[BSD 3-Clause](LICENSE)
