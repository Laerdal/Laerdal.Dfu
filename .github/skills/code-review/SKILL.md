---
name: code-review
description: Use for reviewing pull requests on Laerdal.Dfu — checks the progress-scale gotcha, pinned binding-package versions, cross-platform DfuInstallation consistency, and license/attribution integrity.
---

# Code Review — Laerdal.Dfu

## Checklist for changes in this repo

- [ ] **Progress scale**: any change touching `DfuProgressChangedEventArgs` or progress
      reporting must keep the public `Progress` value on a `0.0`–`1.0` scale — the underlying
      Nordic native libraries (`Android-DFU-Library`, `IOS-Pods-DFU-Library`) report on a
      `0`–`100` scale. A PR that passes a native progress value straight through without
      dividing by 100 is a real, previously-seen bug, not a hypothetical.
- [ ] **Binding package versions stay pinned**: `Laerdal.Dfu.Bindings.Android` and
      `Laerdal.Dfu.Bindings.iOS`/`.MacCatalyst` package references should stay pinned to exact
      versions, not made floating. A prior packaging/`TargetPlatformVersion` mismatch here
      silently fell back to a placeholder implementation that threw `NotImplementedException` on
      Android — check the README's "Known issues" section before approving any change to how
      these versions are resolved.
- [ ] **Cross-platform `DfuInstallation` consistency**: a behavior change in one of
      `Platforms.Droid`, `Platforms.iOSandMacCatalyst`, or `Platforms.NetX` should either be
      mirrored in the others or have an explicit, documented reason it's platform-specific — the
      cross-platform surface in `Laerdal.Dfu/DfuInstallation.cs` should stay consistent.
- [ ] **`NordicDfuUuids` changes**: any edit to the GATT UUID constants must be checked against
      Nordic's actual DFU spec/upstream library, not guessed or typed from memory — this is the
      single source of truth other Laerdal repos (e.g. `Laerdal.Bluetooth`) rely on for DFU-mode
      detection.
- [ ] **License integrity**: this repo is intentionally BSD-3-Clause, not MIT like the
      `Plugin.*` repos in this org — because it wraps Nordic's BSD-3-Clause
      `Android-DFU-Library`/`IOS-Pods-DFU-Library`. Flag any PR that changes the license without
      a clear reason tied to the wrapped native libraries' own licensing.

## What to flag as a real risk, not a nit

- Any change here has no dedicated unit test project to catch regressions — this library is
  validated against real hardware (via `Laerdal.Dfu.Sample` and consuming apps). Weight review
  scrutiny accordingly; don't wave through a DFU-state-machine change just because CI is green.
