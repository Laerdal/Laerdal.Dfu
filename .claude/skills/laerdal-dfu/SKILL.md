---
name: laerdal-dfu
description: Use when writing, reviewing, or debugging code in this repo (Laerdal.Dfu — the cross-platform MAUI binding wrapping Nordic's Android/iOS DFU SDKs) or when consuming the Laerdal.Dfu NuGet package and hitting a version-bump or cross-repo binding issue. Routes to this repo's existing Copilot instructions instead of re-deriving them, and flags a versioning quirk that isn't written down anywhere else.
---

# Laerdal.Dfu orientation

.NET MAUI binding library wrapping Nordic Semiconductor's native Android/iOS DFU SDKs behind
one cross-platform C# API (`Laerdal.Dfu/DfuInstallation.cs`, split into platform partials).
Consumed by `Laerdal.Bluetooth.Firmware` and `fds-mobile-app` via NuGet, not project
references. Verify the paths below still exist before trusting them; if they don't, this skill
is stale, not the docs.

## Step 1 — do this now, before anything else

**Read `.github/copilot-instructions.md` in full, right now, before writing, reviewing, or
reasoning about any non-trivial code in this repo.** It covers project structure, build
commands, code organization, and a "Known Gotchas" section that already documents the two
biggest traps here: `DfuProgressChangedEventArgs.Progress` being on a `0.0`–`1.0` scale versus
Nordic's native `0`–`100` scale, and the binding package versions
(`Laerdal.Dfu.Bindings.Android`/`.iOS`) being pinned, not floating. Everything below this point
only adds what that file doesn't cover.

## What's not written down there — versioning

`.config/version.json` holds only `{ "major": ..., "minor": ... }`, hand-set by whoever bumps
the version. **Patch is generated per-build by the shared `reusable-version.yml` workflow
(`laerdal/github_actions`), not hand-edited and not derived from `x.y.0`.** There is no clean
`x.y.0` release to expect. Don't hand-bump `minor` for a purely additive change — check recent
tags first (`git tag --sort=-v:refname | head`) to see what CI actually produced last, rather
than assuming semver defaults apply.

## Cross-repo reminder

If Android DFU misbehaves after touching `TargetPlatformVersion` anywhere in this repo or in
`Laerdal.Dfu.Bindings.Android`, check both repos' pins together — a mismatch between them is
the historical root cause (see this repo's README "Known issues"). The same coordination
applies when bumping the wrapped Nordic native library version itself:
`Laerdal.Dfu.Bindings.Android` and `Laerdal.Dfu.Bindings.iOS` both need the native bump, and
this repo's `NordicDfuUuids` (Legacy/Secure DFU GATT constants) needs re-verifying against the
new native version before republishing.
