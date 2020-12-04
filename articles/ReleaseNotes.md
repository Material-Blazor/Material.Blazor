---
uid: A.ReleaseNotes
title: ReleaseNotes
---
# Release Notes

#### [2.0.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0)
99 November 2020

**Updates**

- Upgrade to [Material Components Web 8.0.0](https://github.com/material-components/material-components-web/tree/v8.0.0/packages).
- Upgraded build process to produce Material.Blazor with support for netstandard2.1 and net5.0.
- Full implementation of Material Components Web JS `destroy()` function calls for every component's `Dispose()` process.
- MBDataTable enhanced with pagination and linear progress implementation - no breaking changes.
- MBPaginator now uses Material Component Web 8.0.0's markup, with some minor modification - no breaking changes.
- Tooltips use Material Component Web 8.0.0 rather than preview packages - no breaking changes.
- Material.Blazor beginning to use `ILogger` to log warnings when validating component markup to help you during app development.
- General bug fixes.

**Breaking Changes**

- Material.Blazor 2.0.0 is only compatible with .NET 5.0 - if you require .NET Core 3.1 or .NET Standard 2.1 use Material.Blazor version 1.0.0.
- CDN packages now reference material components web 8.0.0, see [Installation article](xref:A.Installation).
- If you are building a theme from material components web SASS, you need to reference version 8.0.0.
- MBMenu `ToggleAsync()` is now return type `Task` rather than `Task<string>` in version 1.

<br />


#### [1.1.4](https://github.com/Material-Blazor/Material.Blazor/tree/1.1.4)
06 November 2020

- Repaired Release build.

<br />


#### [1.1.3](https://github.com/Material-Blazor/Material.Blazor/tree/1.1.3)
06 November 2020

- Removed dual runtimes due to an error in DocFx.

<br />


#### [1.1.2](https://github.com/Material-Blazor/Material.Blazor/tree/1.1.2)
02 November 2020

- Upgraded build process for DocFx.

<br />


#### [1.1.1](https://github.com/Material-Blazor/Material.Blazor/tree/1.1.1)
02 November 2020

- Upgraded build process to produce Material.Blazor with support for netstandard2.1 and net5.0.

<br />


#### [1.1.0](https://github.com/Material-Blazor/Material.Blazor/tree/1.1.0)
31 October 2020

- Added FABs (floating action buttons).
- Upgraded build process to skip node builds if npm isn't installed.
- Bug fixes.

<br />


#### [1.0.0](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0)
27 October 2020

- First full release of Material.Blazor!
- Minor changes to internal cascading values, setting `IsFixed="true"`.

<br />


#### [1.0.0-rc.6](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0-rc.6)
23 October 2020

- Rewrote two-way binding in response to [ASP.NET issue #24599](https://github.com/dotnet/aspnetcore/issues/24599#issuecomment-697588562) with Steve Sanderson's advisory note.
- Toasts dynamically respond to service configuration changes.
- Bug fixes.

<br />


#### [1.0.0-rc.5](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0-rc.5)
13 October 2020

- MS Build dependency check for SASS and Typescript files working.
- Github Actions updated to new path setting construct.
- Bug fixes.

<br />


#### [1.0.0-rc.4](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0-rc.4)
24 September 2020

- Build process uses npm directly rather than via docker (docker dependency removed).
- Typescript in localized files replaces single Javascript file.
- Themes upgraded.
- `ToastService.ShowToast` adds debug parameter, showing toast only in debug mode when true.
- Bug fixes.

<br />


#### [1.0.0-rc.3](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0-rc.3)
16 September 2020

- Material helper text added to text fields and associated derivatives.
- Blazor native validation integrated with Material Components Web's validation display mechanism.
- `HelperText`, `HelperTextPersistent` and `ValidationMessageFor` implemented on:
  - MBAutocompleteTextField
  - MBDebouncedTextField
  - MBNumericDoubleField
  - MBNumericIntField
  - MBTextArea
  - MBTextField
- Attribute splatting order checked and documentation provided for reserved attributes in relevant components' articles

<br />


#### [1.0.0-rc.2](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0-rc.2)
15 September 2020

- Corrects tooltip javascript initiation bug.
- Updates website to ASP.NET 5 rc 1.
- Re-enables autocomplete demonstration due to REGEX fix in ASP.NET 5 rc 1.
- Re-order attributes in MBButton to make `type=""` attribute splat correctly.
- Minor upgrades to red round and varied themes.

<br />


#### [1.0.0-rc.1](https://github.com/Material-Blazor/Material.Blazor/tree/1.0.0-RC.1)
14 September 2020

- First 1.0.0 release candidate having migrated from prior Blazor MDC previews.