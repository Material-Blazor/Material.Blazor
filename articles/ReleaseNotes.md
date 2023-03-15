﻿---
uid: A.ReleaseNotes
title: ReleaseNotes
---
# Release Notes

#### [4.0.0-preview.16](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.15)

Released 2023-03-15

**Updates**
- Dependabot updates, migrate MD3 projects to DotNet 8 Preview 2

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**
- Nuget does not know how to handle the mixed 
DN7 and DN8 environment. The easiest solution
is to update with 'prerelease' not selected
and then to copy the DN8 references from the
DN8 branch (MD3 projects only).

<br />

#### [4.0.0-preview.15](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.15)

Released 2023-02-17

**Updates**
- Dependabot updates, more website cleanup, publish MD3 pages

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.14](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.14)

Released 2023-02-09

**Updates**
- Fixed a bug preventing `MBLinearProgress` components' usage in dialogs.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.13](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.13)

Released 2023-02-04

**Updates**
- Website bug fixes.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.12](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.12)

Released 2023-02-03

**Updates**
- Bug fixes.

**New components**
- Added preview of Material Design 3 components:
	- MBIcon
	- MBSwitch

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.11](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.11)

Released 2023-02-03

**Updates**

**New components**
- Added preview of Material Design 3 components:
	- MBAnchor
	- MBFilledDecimalField
	- MBOutlinedDecimalField
	- MBFilledTextField
	- MBOutlinedTextField

**Breaking Changes**
- There are two configurations, 'Server' (replacing 'Debug') and 'WebAssembly' (replacing 'Release').
The choice of one or the other of these determines if the website is to run as a server side
application or
a web assembly application hosted by the server.

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.10](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.10)

Released 2023-01-26

**Updates**
- Fixed a potential bug dequeing JS Interop actions after components are disposed.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.9](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.9)

Released 2023-01-18

**Updates**
- Fixed a bug in `MBSlidingContent`.
- Update Packages.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.8](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.8)

Released 2023-01-18 - WITHDRAWN

<br />

#### [4.0.0-preview.7](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.7)

Released 2022-12-26

**Updates**
- SIGNIFICANT REFACTORING SUBJECT TO REVIEW
	- This release sees the first refactoring of how JS Interop calls are made to control (material-components-web)[https://github.com/material-components/material-components-web].
	- All calls are now fully awaited rather than Material.Blazor's previous "fire and forget" approach to setting values and disabled parameters.
	- Furthermore these calls are placed on a concurrent queue and executed sequentially in the order in which they were queued.
	- This has been necessary to enable `MBAutoCompletePagedField` to instantiate correctly, since it potentially receives a set of rapid-fire changes as it is first rendered.
	- We are stress testing this release in live deployed app environments. If we find issues we will fix these fast.

**New components**
- Added `MBAutoCompletePagedField` which is a single item select using asynchronous methods supplied as parameters to search for items matching user entered text. Behaves differently to `MBAutoCompleteSelectField` because
results are paged on a menu surface rather than being hidden in favour of a "too many results" message.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.6](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.6)

Released 2022-12-23

**Updates**

**New components**
- Added `MBAutoCompletePagedField` which is a single item select using asynchronous methods supplied as parameters to search for items matching user entered text. Behaves differently to `MBAutoCompleteSelectField` because
results are paged on a menu surface rather than being hidden in favour of a "too many results" message.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.5](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.5)

Released 2022-12-20

**Updates**

**New components**
- Added `MBAutoCompleteSelectField` which is a single item select using asynchronous methods supplied as parameters to search for items matching user entered text.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.4](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.4)

Released 2022-12-18

**Updates**
- Fixed `MBSlider` to use disabled markup in first render.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.3](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.3)

Released 2022-11-29

**Updates**
- Fix key generation on `MBList`.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [4.0.0-preview.2](https://github.com/Material-Blazor/Material.Blazor/tree/4.0.0-preview.2)

Released 2022-11-28

**Updates**
- Added multi-level list functionality.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.3.1](https://github.com/Material-Blazor/Material.Blazor/tree/3.3.1)

Released 2022-11-01

**Updates**
- Add `class`, `style` and other unmatched attributes to `MBTooltip`.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.3.0](https://github.com/Material-Blazor/Material.Blazor/tree/3.3.0)

Released 2022-10-31

**Updates**
- Add badges to `MBSegmentedButtonSingle` and `MBSegmentedButtonMulti`.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.2.1](https://github.com/Material-Blazor/Material.Blazor/tree/3.2.1)

Released 2022-10-18

**Updates**
- Improve `MBDragAndDropList` CSS.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.2.0](https://github.com/Material-Blazor/Material.Blazor/tree/3.2.0)

Released 2022-10-12

**Updates**

**New components**
- `MBIntSlider` added.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.1.2](https://github.com/Material-Blazor/Material.Blazor/tree/3.1.2)

Released 2022-10-11

**Updates**
- Migrated inline JavaScript in `MBDragAndDropList` to Typescript event listeners in order to pass strict Content Security Policies.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.1.1](https://github.com/Material-Blazor/Material.Blazor/tree/3.1.1)

Released 2022-10-11

**Updates**
- Improvements to layout of `MBDragAndDropList`.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.1.0](https://github.com/Material-Blazor/Material.Blazor/tree/3.1.0)

Released 2022-10-11

**Updates**
- Update packages via dependabot.

**New components**
- `MBDragAndDropList` added.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.1](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.1)

Released 2022-09-15

**Updates**
- Resolves github issues.
- Update packages via dependabot.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0)

Released 2022-09-02

**Updates**
- Delete deprecated `builder.Services.AddMBServices()` function that takes specific options as parameters.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.13](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.13)

Released 2022-08-30

**Updates**
- Add [ASP.NET options pattern](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-6.0) as the preferred way to pass options to the `builder.Services.AddMBServices()` function.
- Deprecate the existing `builder.Services.AddMBServices()` function that takes specific options as parameters. Will be deleted in future major Material.Blazor releases.
- Minor `MBFileUploadDragAndDrop` styling improvements.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.12](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.12)

Released 2022-08-29

**Updates**
- Improved UX and accessibility for `MBFormFieldDragAndDrop`.
- Removed `Accept` and `Multiple` parameters in favour of using attribute splatting to allow use of `accept` and `multiple` attributes for the `MBFormFieldButton` and `MBFormFieldDragAndDrop` components.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.11](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.11)

Released 2022-08-27

**Updates**
- Fixed `MBNumericDoubleField` bug.

**New components**
- File upload plus components added.
- `MBFileUploadButton` presents a standard `MBButton` that launches a file upload dialog.
- `MBFileUploadDragAndDrop` presents a styled `MBCard` that can have files dragged and dropped on to it, or can be clicked to launch a file upload dialog.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.10](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.10)

Released 2022-08-17

**Updates**
- Fixed null reference tooltip bug.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.9](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.9)

Released 2022-07-20

**Updates**
- Restored proper MB csproj.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.8](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.8)

Released 2022-07-19

Delisted 2022-07-19

**Updates**
- Removed redundant setting of 'LoggingLevel' in MBGrid & MBScheduler.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.7](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.7)

Released 2022-07-19

**Updates**
- Removed setting of 'LoggingLevel' in MBGrid & MBScheduler.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.6](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.6)

Released 2022-07-04

**Updates**
- Remove CSPROJ deletion of extraneous `node_modules` files from `@material/segmented-button` and `@material/tooltip`.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.5](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.5)

Released 2022-07-04

**Updates**
- Update Material Icons CSS references to latest standard.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.4](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.4)

Released 2022-06-25

**Updates**
- Applied the `<PageTitle>` component to the website to show the page name on browser tabs.
- Material.Blazor released only as a mechanism to release the website: there are no changes to the Material.Blazor package since preview 2.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.3](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.3)

Released 2022-06-25

**Updates**
- Applied [GoogleAnalytics.Blazor](https://github.com/Material-Blazor/GoogleAnalytics.Blazor) to the website to track page hits.
- Material.Blazor released only as a mechanism to release the website: there are no changes to the Material.Blazor package since preview 2.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

#### [3.0.0-preview.2](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.2)

<br />

Released 2022-05-26

**Updates**
- Repaired MBGrid's OnMouseClickInternal (Thanks go out to Steve Sanderson for finding this error)
- Throttled dependabot to a monthly check

**New components**

**Breaking Changes**
- Removed obsolete MBLinearProgressType.ReversedDeterminate
- Removed obsolete MBTooltipType

**Deprecated Components**

**Known issues**

<br />

#### [3.0.0-preview.1](https://github.com/Material-Blazor/Material.Blazor/tree/3.0.0-preview.1)

Released 2022-05-02

**Updates**
- Migration to [Material Components Web 14.0.0](https://github.com/material-components/material-components-web/tree/v14.0.0)
- `sass` npm package version remains at 1.39.2 - would prefer to update but compilation fails
- Other npm packages updated

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [2.5.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.5.0)

Released 2022-05-02

**Updates**

**New components**
- Scheduler.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [2.4.1](https://github.com/Material-Blazor/Material.Blazor/tree/2.4.1)

Released 2022-04-19

**Updates**
- CSS and accessibility improvements to MBCarousel.

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [2.4.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.4.0)

Released 2022-04-18

**Updates**
- node package update to remove audit risks.

**New components**
- MBCarousel added.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [2.3.1](https://github.com/Material-Blazor/Material.Blazor/tree/2.3.10)

Released 2022-03-29

**Updates**
- Updated Font Awesome & Sass versions
- Updated minimist.js version to 1.2.6 to mitigate Dependabot detected vulnerability

**New components**

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [2.3.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.3.0)

Released 2022-03-10

**Updates**
- SlidingContent improvements

**New components**

**Breaking Changes**
- MBDateTimeField brings simple text entry for dates & datetimes using an input component type of either 'date' or 'datetime-local'. This is a rename of MBDateField with an additional parameter of DateOnly. This field retains the 'Experimental' status.

**Deprecated Components**

**Known issues**

<br />

#### [2.2.2](https://github.com/Material-Blazor/Material.Blazor/tree/2.2.2)

Released 2022-03-10

Deprecated 2022-03-10

**Updates**

**New components**

**Breaking Changes**
- MBDateTimeField brings simple text entry for dates & datetimes using an input component type of either 'date' or 'datetime-local'. This is a rename of MBDateField with an additional parameter of DateOnly. This field retains the 'Experimental' status.

**Deprecated Components**

**Known issues**

2.2.1 added support for the html dropdowns in the date & time fields. What wasn't noted is that the addition of these dropdowns broke the reporting of text changes. Pending further investigation there is no graphic entry support.

<br />

#### [2.2.1](https://github.com/Material-Blazor/Material.Blazor/tree/2.2.1)

Released 2022-03-10

Deprecated 2022-03-10

**Updates**

**New components**

**Breaking Changes**
- MBDateTimeField brings simple text entry for dates & datetimes using an input component type of either 'date' or 'datetime-local'. This is a rename of MBDateField with an additional parameter of DateOnly. This field retains the 'Experimental' status.

**Deprecated Components**

**Known issues**

<br />

#### [2.2.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.2.0)

Released 2022-02-28

**Updates**

- The planned deprecation of MBToast is now deprecated. 

**New components**
- MBDateField brings simple text entry for dates using an input component type of 'date'.  This field is marked with the 'Experimental' status.

**Breaking Changes**

**Deprecated Components**

**Known issues**

<br />

#### [2.1.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.1.0)
Released 2021-12-21

**Updates**

- Fixes bug in `MBSlidingContent` whereby setting the item index parameter out of range selects the first item of content rather than throwing an exception.

**New components**

- `MBBadge` bring badges to HTML `<div>` elements and via parameters to `MBButton`, `MBIconButton` and `MBIconButtonToggle`.

<br />

#### [2.0.1](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.1)
Released 2021-12-04

- Fixes bug in MBPaginator where menu for number of items per pages doesn't open.
- Updates tooltip markup to be Material Components Web 12, fixing a bug where tooltips failed to close when the anchor loses hover state.

<br />

#### [2.0.0](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0)
Released 2021-11-10

**Updates**

- Material.Blazor is now built against .Net 6.0.0 GA

**New components**

**Breaking Changes**

**Deprecated Components**

- MBAnimatedNavigation is now deprecated.
- MBBatchingWrapper is now deprecated.
- MBToast is now deprecated in favor of the Material styled MBSnackbar. It will remain part of Material.Blazor 2.n, however no maintenance is planned during the Material.Blazor 2.n series of releases. It will be removed from the next major Material.Blazor release. 

**Known issues**

<br />

#### [2.0.0-rc.1](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-rc.1)
2021-10-29

**Updates**

**New components**

**Breaking Changes**

- MBBatchingWrapper is now deprecated.

**Known issues**

<br />

#### [2.0.0-preview.9](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.9)
2021-10-20

**Updates**

**New components**

**Breaking Changes**

- Animated Navigation is deprecated. It does not function in the MCW 12.0 environment
- All parameters with the word "Supress" are renamed "Suppress" - good spelling helps.

**Known issues**

<br />

#### [2.0.0-preview.8](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.8)
2021-09-20

**Updates**

- Migrated to [Material Components Web 12.0.0](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-switch).

**New components**

**Breaking Changes**

- `MBSwitch` no longer supports density, having been removed in Material Theme.
- `MBFloatingActionButton` re-implemented extended variant.

**Known issues**

<br />

#### [2.0.0-preview.7](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.7)
2021-08-19

**Updates**

- Added an internal logging service for M.B. It's logging level can be controlled using the AddMBServices service extension with the new loggingLevelServiceConfiguration parameter.

- Support PrimaryActions & SecondaryActions in MBList.

**New components**

**Breaking Changes**

- MBList Actions parameter is renamed to SecondaryActions.

- The names of the JavaScript & CSS resources have changed in this preview. See the installation article for details.

**Known issues**

- MBDatePicker does not render a value if it is started with a Value of default 

- MBBatchingWrapper does not work inside a dialog or with content that includes MBSlidingContent.
 This is an experimental component and we do not recommend its use.

<br />

#### [2.0.0-preview.6](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.6)
2021-04-26

**Updates**

- Added build task to deduplicate license comments in js file

- MBDialog initialization restructured in order to fix a race condition.

- MBSlidingContent initialization to account for 'late' creation of the Items list.

- MBTooltip anchor modified to fix a race condition

**New components**

**Breaking Changes**

<br />

#### [2.0.0-preview.5](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.5)
2021-04-19

**Updates**

- Fixed a regression in MBDatepicker where the state after user interaction was not displayed correctly.

**New components**

**Breaking Changes**

<br />


#### [2.0.0-preview.4](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.4)
2021-04-16


**Updates**

- MBDataTable enhanced with pagination and linear progress implementation - no breaking changes.
- MBGrid is now Phase 1 feature complete.
- MBSnackbar now supports a parameter of 'AdditionalClass' which is applied to the snackbar. See the Snackbar demo page for a simple example of styling for Error/Warning/Info/Success messages.
- MBToast now supports centerleft, centercenter, and centerright positions. It also had the fixed width removed and toasts adjust width dynamically.
- Material.Blazor beginning to use `ILogger` to log warnings when validating component markup to help you during app development.
- General bug fixes.
- Substantial GitHub workflow upgrade orientated towards quality assurance by @StefanLoerwald, including an automated diff of every page on the demo website resulting from a PR.


**New components**

- MBMenuSurface - a stripped back menu surface that accepts a render fragment for its contents (thanks @HannahKiekens).
- MBNumericDecimalField - a decimal variant of the existing numeric input fields.


**Breaking Changes**

- MBMenu `ToggleAsync()` is now return type `Task` rather than `Task<string>` in version 1.
- MBSelect and other single select components now allow for dynamic update of the `Items` parameter.
- MBSlider value changed to be of type decimal
- MBRadioButtonGroup `EnableTouchWrapper` obsolete and removed.
- `MBToastCloseMethod` enum renamed to `MBNotifierCloseMethod`, and enum value names have changed. This is now used by both toasts and snackbars.
- The names and content of the  css and js resources required for MaterialBlazor have changed. Please see [Installation article](xref:A.Installation) for details.
- The CSS utility class `mb-card__primary` was renamed to `mb-card__autostyled`. 

<br />


#### [2.0.0-preview.3](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.3)
2021-02-08


**Updates**

- General bug fixes.
- Additional functionality in MBGrid.


**New components**

- MBSnackbar - a core Material Theme snackbar component.

**Breaking Changes**


<br />


#### [2.0.0-preview.2](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.2)
2021-01-11


**Updates**

- General bug fixes.
- Animation improvements to MBBladeSet.
- Additional functionality in MBGrid.
- Upgrade to [Material Components Web 9.0.0](https://github.com/material-components/material-components-web/tree/v9.0.0/packages).
- Tooltips use Material Component Web 9.0.0 rather than preview packages - no breaking changes.
- MBPaginator now uses Material Component Web 9.0.0's markup, with some minor modification - no breaking changes.


**New components**

**Breaking Changes**

- CDN packages now reference material components web 9.0.0, see [Installation article](xref:A.Installation).
- If you are building a theme from material components web SASS, you need to reference version 9.0.0.


<br />


#### [2.0.0-preview.1](https://github.com/Material-Blazor/Material.Blazor/tree/2.0.0-preview.1)
2020-12-29


**Updates**

- General bug fixes.
- Material.Blazor 2.0.0 is compatible with .NET 5.0 only. If you need to build against older versions of .NET please continue to use Material.Blazor 1.1.4.


**New components**

- MBBladeSet - a blade implementation inspired by Microsoft Azure blades.
- MBChipsSelectMulti - a multi select variant of a chip set.
- MBChipsSelectSingle - a single select variant of a chip set.
- MBGrid (EXPERIMENTAL) - a capable grid component. This is not yet styled to look like Material Theme and we may or may not keep it in Material.Blazor. We recommend not using MBGrid for anything other than experiment or contributing to its development.
- MBSegmentedButtonMulti - a multi select variant of segmented buttons, which have been added to Material Components Web 9.0.0.
- MBSegmentedButtonSingle - a single select variant of segmented buttons, which have been added to Material Components Web 9.0.0.
- MBSlider - a continuous and discrete single-thumb slider.


**Breaking Changes**


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
