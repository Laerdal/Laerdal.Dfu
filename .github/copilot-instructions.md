# GitHub Copilot Instructions for Laerdal.Dfu

## Project Overview

**Laerdal.Dfu** is a .NET MAUI binding library wrapping Nordic Semiconductor's native DFU
(Device Firmware Update) SDKs, giving MAUI apps a single cross-platform API to update
Nordic-based Bluetooth Low Energy devices over the air.

Native libraries wrapped, via separate binding packages:
- **Android** — [Android-DFU-Library](https://github.com/NordicSemiconductor/Android-DFU-Library)
  via [`Laerdal.Dfu.Bindings.Android`](https://github.com/Laerdal/Laerdal.Dfu.Bindings.Android)
- **iOS / MacCatalyst** — [IOS-Pods-DFU-Library](https://github.com/NordicSemiconductor/IOS-Pods-DFU-Library)
  via [`Laerdal.Dfu.Bindings.iOS`](https://github.com/Laerdal/Laerdal.Dfu.Bindings.iOS)
- **Windows / other** — "dud" fallback implementation: compiles, but throws at runtime. Useful
  for desktop UI development/testing, not for real DFU.

## Technology Stack

- **Framework:** .NET MAUI, target framework `net10.0` (SDK `10.0.0`, see `global.json`)
- **Language:** C#
- **Package Management:** per-project `PackageReference`, not central package management
- **CI/CD:** GitHub Actions
- **License:** BSD-3-Clause — intentionally matches the license of the Nordic libraries this
  repo wraps (both `Android-DFU-Library` and `IOS-Pods-DFU-Library` are BSD-3-Clause), not a
  drift from the MIT license used by the `Plugin.*` repos in this org.

## Project Structure

```
Laerdal.Dfu/
├── .github/
│   ├── workflows/ci.yml
│   └── copilot-instructions.md        # This file
├── Laerdal.Dfu/                        # Main library
│   ├── DfuException.cs
│   ├── DfuInstallation.cs              # Shared/partial cross-platform surface
│   ├── Events.cs
│   ├── NordicDfuUuids.cs               # Legacy/Secure DFU GATT UUID constants
│   ├── Enums/                          # DfuError, DfuLogLevel, DfuServiceScope, DfuState
│   ├── EventArgs/                      # DfuErrorEventArgs, DfuMessageReceivedEventArgs,
│   │                                   # DfuProgressChangedEventArgs
│   ├── Helpers/TaskCompletionSource.cs
│   ├── Platforms.Droid/DfuInstallation.cs           # Android partial implementation
│   ├── Platforms.iOSandMacCatalyst/DfuInstallation.cs  # iOS/MacCatalyst partial implementation
│   └── Platforms.NetX/DfuInstallation.cs            # Windows/other "dud" fallback
└── Laerdal.Dfu.Sample/                 # Working MAUI sample app: BLE scan + full DFU install flow
```

No dedicated unit test project — this library wraps native platform SDKs, so it's validated
against real hardware (via the sample app / consuming apps) rather than with xUnit.

## Development Setup

### Prerequisites
- .NET SDK 10.0.0 or later (see `global.json`)
- MAUI workloads installed (`dotnet workload install maui`)
- For iOS builds: Xcode + a macOS host

### Build Commands
```bash
dotnet restore Laerdal.Dfu.Packages.slnx
dotnet build Laerdal.Dfu.Packages.slnx --configuration Release --no-restore
```

## Code Organization Patterns

- **`DfuInstallation` is split across platform folders** (`Platforms.Droid`,
  `Platforms.iOSandMacCatalyst`, `Platforms.NetX`) as partial classes/conditional compilation —
  the cross-platform surface in `Laerdal.Dfu/DfuInstallation.cs` stays platform-agnostic.
- **`NordicDfuUuids`** is the single source of truth for Legacy/Secure DFU GATT UUIDs — don't
  duplicate these constants in consuming code.
- **Events use the `EventArgs/` types**, not ad-hoc tuples or raw primitives, so consuming apps
  get a consistent event surface across platforms.

## Known Gotchas

- **`DfuProgressChangedEventArgs.Progress` is on a `0.0`–`1.0` scale**, whereas the underlying
  Nordic native libraries report progress on a `0`–`100` scale. Don't assume the two match — this
  has caused real bugs before (see git history / commit log around Little DFU validation,
  2026-08-03).
- **Binding package versions are pinned, not floating** (`Laerdal.Dfu.Bindings.Android`,
  `Laerdal.Dfu.Bindings.iOS`/`.MacCatalyst`) — see the README's "Known issues" section before
  changing `TargetPlatformVersion` handling; a prior packaging mismatch here silently fell back
  to a placeholder implementation that threw `NotImplementedException` on Android.

## Coding Standards

Follow this repo's `.editorconfig`. Prefer clarity over cleverness; avoid unnecessary
abstraction — this is a firm preference, not a suggestion.

## Commit Message Format

`type (scope): short imperative`, <= 72 characters. Body (if present): 1-2 factual sentences
(what/why) — no emojis, issue refs, or co-authors. Types: `feat`, `fix`, `refa`, `perf`, `docs`,
`ci`, `chore`, `test`, `build`.

## CI/CD Pipeline

`ci.yml` runs: version generation → build/pack → publish to NuGet.org (on `main`) → tag & GitHub
release.

## Useful Resources

- **Repository:** https://github.com/Laerdal/Laerdal.Dfu
- **NuGet Package:** https://www.nuget.org/packages/Laerdal.Dfu
- **Nordic Android-DFU-Library:** https://github.com/NordicSemiconductor/Android-DFU-Library
- **Nordic IOS-Pods-DFU-Library:** https://github.com/NordicSemiconductor/IOS-Pods-DFU-Library
