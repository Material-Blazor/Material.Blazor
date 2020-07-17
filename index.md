# BlazorMdc (1.0.0-Preview.1.4)

[![NuGet version](https://img.shields.io/nuget/v/BlazorMdc?logo=nuget&label=nuget%20version&style=flat-square)](https://www.nuget.org/packages/BlazorMdc/)
[![NuGet downloads](https://img.shields.io/nuget/dt/BlazorMdc?logo=nuget&label=nuget%20downloads&style=flat-square)](https://www.nuget.org/packages/BlazorMdc/)
[![Gitter](https://img.shields.io/gitter/room/egil/bunit?logo=gitter&style=flat-square)](https://gitter.im/BlazorMdc/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?logo=github&style=flat-square)](/LICENSE.md)
[![GitHub issues](https://img.shields.io/github/issues/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/issues)
[![GitHub forks](https://img.shields.io/github/forks/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/network/members)
[![GitHub stars](https://img.shields.io/github/stars/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/stargazers)
[![GitHub stars](https://img.shields.io/github/watchers/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/watchers)

[![GithubActionsMainPublish](https://img.shields.io/github/workflow/status/blazormdc/blazormdc/GithubActionsMainPublish?label=actions%20main&logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/actions?query=workflow%3AGithubActionsMainPublish)
[![GithubActionsDevelop](https://img.shields.io/github/workflow/status/blazormdc/blazormdc/GithubActionsDevelop?label=actions%20develop&logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/actions?query=workflow%3AGithubActionsDevelop)

## Lightweight Material Theme razor components for Blazor

BlazorMdc is a lightweight [Material Theme](https://material.io/) [web development platform](https://material.io/develop/web/) (version 7.0.0) component library for [ASP.NET Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) that is rigorously faithful to the Material Theme's design philosophy, markup and code usage. Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as BlazorMdc. This is available at https://www.nuget.org/packages/BlazorMdc.

BlazorMdc isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from [Telerik](https://www.telerik.com/blazor-ui), and [Syncfusion](https://blazor.syncfusion.com/); this is not an exhaustive list and there may be others. So why did we create BlazorMdc as yet another option? In building our Blazor applications using Material Theme we had some overriding objectives and to our taste this required a new library focussing on the following:

- Lightweight components that require the minimal possible setup or boilerplate Blazor coding and without intensive startup processing,
- An entirely native Blazor experience for BlazorMdc's consumer, using JavaScript Interop within BlazorMdc only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application,
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable,
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS. BlazorMdc keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. This requires you to manage your layout because BlazorMdc does not attempt to give you layout shortcuts. This is so you can decide what layout system to use? Material Theme, Bootstrap or as you wish. Other libraries take a different approach, and if you have a different requirement you may want to consider other options,
- Some added value components derived from core material theme components but that are not strictly material theme themselves. These include an autocomplete box, a confimration dialog and formatted numeric input fields. We also provide a date picker and paginator, each of which follow Material Theme specification in the absence of a Material Theme css/js implementation, and
- We aim for BlazorMdc to employ best practice for Blazor development. As a starting point this should be considered as being defined per [this video from NDC London, January 2020](https://www.youtube.com/watch?v=QnBYmTpugz0). We have plenty to do to arrive at that position.

BlazorMdc is still pre-release however we are close to version 1. The API is stable, we do not expect breaking changes and we believe that the project performs well, although we will conduct a code review prior to release. This project is owned by [Dioptra](https://dioptra.tech) and is provided as-is under the terms of the [MIT license](https://github.com/BlazorMdc/BlazorMdc/blob/main/LICENSE.md).

Note also that BlazorMdc has advanced making this documentation somewhat obsolete as we move towards automated documentation. Some of the component references here may be incorrect and we do not expect to maintain the detailed documentation found in this file for much longer.

Lastly if you want to contribute please note our [code of conduct](https://github.com/BlazorMdc/BlazorMdc/blob/main/CODE_OF_CONDUCT.md).

## Attribution

BlazorMdc is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting. At the present time we have revisited only a limited selection of components from RazorComponents.MaterialDesign - we are still under development.

We also want to acknowledge the work of 
* [Vladimir Samoilenko (@SamProf on Github)](https://github.com/SamProf) for his work on [MatBlazor](https://www.matblazor.com/). MatBlazor code was referenced and some small parts of the code were copied to be part of BlazorMdc (ClassMapper and StyleMapper).
* [Chris Sainty (@chrissainty on Github)](https://github.com/chrissainty) for his work on [Blazored/Toast](https://github.com/Blazored/Toast) which is the basis for MTToast.
* [ℳisterℳagoo (@mistermag00 on Twitter)](https://github.com/SQL-MisterMagoo/) for the `@:@{` construct used in MTPagedDataList and [Peter Morris (@mrpmorris on Github)](https://github.com/mrpmorris) for demonstrating this with code that we forked in [Blazor University](https://blazor-university.com/), christening it the "wig pig" - head to Blazor University to see why.

## Installation

Either fork this repo or use the Nuget package linked at the top of this document. Once the package is referenced in your project you will need to add the CSS and JS in your html (there are non-minified unbundled files for BlazorMdc.css & BlazorMds.js to reference if you need them for debugging purposes).
Reference the `BlazorMdc` namespace with `@using BlazorMdc` to your `_Imports.razor` file. There are two optional services in BlazorMdc:
- If you want to use toasts via `MTToastAnchor` add `services.AddMTToastService();` to your `ConfigureServices` function for Blazor Server or to the `Main()` function for Blazor WebAssembly, and
- If you want animated page navigation using `MTAnimationdNavigation` add `services.AddMTAnimatedNavigationManager();` to `ConfigureServices`.

**NOTE** - BlazorMdc works with [Material Components v7.0.0](https://github.com/material-components/material-components-web/blob/master/CHANGELOG.md#600-2020-04-22).

#### Directions for using our bundled CSS and JS

We bundle the Material Theme CSS and JS into BlazorMdc for your convenience along with [Material Icons](https://material.io/resources/icons/?style=baseline) which are essential for BlazorMdc. You will need to add two items to your index.html/_Host.cshtml file. Place this in the the `<head>` tag:
```html
<link href="_content/BlazorMdc/blazormdc-bundled.min.css" rel="stylesheet">
```
and at the end of `<body>`:
```html
<script src="_content/BlazorMdc/blazormdc-bundled.min.js"></script>
```
See the [Blazor WebAssembly demo index file](https://github.com/BlazorMdc/BlazorMdc/blob/main/BlazorMdc.Demo.WebServer/Pages/index_webassembly.cshtml) and [Blazor Server demo index file](https://github.com/BlazorMdc/BlazorMdc/blob/main/BlazorMdc.Demo.WebServer/Pages/index_server.cshtml) for examples. We also provide un-minified `blazormdc.css` and `blazormdc.js`.


## Demonstration website

We are not yet hosting a demonstration, but you can fork and download this project yourself. If you so so, set your default project to `BlazorMdc.Demo.WebServer`.

## Demonstration from local build

If you have cloned the repository and are building from source there is a project 'BlazorMDC.Demo.WebServer' that should be selected as the startup project.
 
Note that we compile, bundle and minify SASS/CSS and JS. In Visual Studio you will need to install the   [Bundler Minifier](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.BundlerMinifier) and [Web Compiler](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler)  extensions.

If you are experimenting with different versions of the Material Design Components you will need to build the BlazorMDC.MaterialComponents project. You need to install `libman` if you haven't already:
```console
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

There are four implemented solution configurations:

| Configuration | Notes |
| :------------ | :---- |
| `Debug_WebAssembly` | This is a debug build. It defines two constants, DEBUG, and BlazorWebAssembly. It executes using WebAssembly. |
| `Debug_Server` | Also a debug build, defines DEBUG and BlazorServer. It executes in the context of the web server and the the client being displayed through a SignalR connection. |
| `Release_WebAssembly` | The same as `Debug_WebAssembly` but built as release and replacing the DEBUG constant with RELEASE. |
| `Release_Server` | The same as `Debug_Server` but built as release and replacing the DEBUG constant with RELEASE. |

The home page of the demonstration application shows the execution environment as well as the build mode.

## Components

The following is a list of core Material Theme components.

| Component | Notes |
| :-------- | :---- |
| `MTButton` | A [Material Button](https://material.io/develop/web/components/buttons/). |
| `MTCard` | A [Material Card](https://material.io/develop/web/components/cards/). _Requires ripple effect._ |
| `MTCheckbox` | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| `MTCircularProgress` | A [Material Circular Progress indicator](https://material.io/develop/web/components/progress-indicator/). |
| `MTDataTable` | A [Material Data Table](https://material.io/develop/web/components/data-tables/) without row selection |
| `MTDialog` | A [Material Dialog](https://material.io/develop/web/components/dialogs/). Can set scrim and escape button actions. |
| `MTDrawer` | A [Material Drawer](https://material.io/develop/web/components/drawers/). _Awaits review_. |
| `MTIconButton` | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| `MTIconButtonToggle` | A toggle variant of the [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| `MTLinearProgress` | A [Material Linear Progress bar](https://material.io/develop/web/components/progress-indicator/). |
| `MTList` | A [Material List](https://material.io/develop/web/components/lists/). Implements Material Theme Web Components one and two line lists, plus a BlazorMdc interpretation of a three line list. |
| `MTMenu` | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| `MTNavLink` | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. _Awaits review_. |
| `MTRadioButton` | A [Material Radio Button](https://material.io/develop/web/components/input-controls/radio-buttons/). |
| `MTSelect` | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| `MTSwitch` | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| `MTTabBar` | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). |
| `MTTextArea` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Implements the full width variety, but still needs to disable floating labels in this instance to follow MT guidelines - indeed full width fields with a floating label render poorly. |
| `MTTextField` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| `MTTopAppBar` | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). _Partially reviewed_. |

## Plus Components

The following are extra or 'plus' components that extend the strict, core Material Theme `MTXxx` components with either additional functionality or in the case of `MTDatePicker` and `MTPaginator` implementing a specification that is yet to be implemented in the Material Theme CSS and JavaScript libraries.

| Component | Notes |
| :-------- | :---- |
| `MTAnimatedNavigation` | A component used by the `IMTAnimatedNavigationManager` service and place in the main layout surrounding your `@Body`. This is not needed if you don't use BlazorMdc animated navigation. |
| `MTAutocomplete` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) that drops a [menu](https://material.io/develop/web/components/menus/) for auto completion. Has parameters to allow blank results and for whitespace to be ignored in searches. Might consider forking and adapting [Blazored.Typeahead](https://github.com/Blazored/Typeahead) with MT styling. |
| `MTConfirmationDialog` | A special purpose wrapper around `MTDialog` that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| `MTDatePicker` | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. Does not implement date ranges. Date pickers are only implemented in Material Theme for Android, so we interpreted as closely as possible the specification with our own CSS. This is the only instance where we have created CSS for a component, because our goal is to use standard Material Theme styling throughout. The result seems a bit too dense and is within a couple of pixels of unstyled overflow content on the month selection menu for long month names in English; this is likely to overflow for languages with longer month names. We are therefore likely to relax the component's density, which should improve usability. We have deviated from the specification by adding an "undo" button to return to the current selected date. There is no "today" button, which is not in the Material Theme specification. |
| `MTDebouncedTextField` | A debounced version of `MTTextField` |
| `MTDivider` | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. | 
| `MTIcon` | Displays an icon from the specified icon foundry or the default foundry from `MTCascadingDefaults`. See `IconHelper`. |
| `MTNumericDoubleField` | Wraps `MTTextField` to format numeric entry of a `double`. The format is applied when the component lacks focus, at which point the field is a text field holding the formatted number as text. When the field gains focus it switches to a number field. Allows for percentages to be entered as a whole number, e.g. typing "12" will yield a `double` equal to '0.12' and displaying '12%' when lacking focus. We intend to find a similar way to handle [basis points](https://en.wikipedia.org/wiki/Basis_point). |
| `MTNumericIntField` | A wrapper for `MTpNumericDoubleField` for `int` variables. |
| `MTPagedDataList` | A templated component for paging generic data lists using `MTPaginator`. Uses the Wig Pig nested coding pattern and can either render list items one by one or wrap a component such as `MTList` or `MTDataTable`. |
| `MTPaginator` | An implementation of the [Material paginator specification](https://material.io/components/data-tables#behavior). |
| `MTRadioButtonGroup` | A group of `MTRadioButton`s. The ItemValidation parameter has three possible values. Exception is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data. DefaultToFirst will select the first item in the list if the Value does not match. NoSelection will not pick a radiobutton when the Value is illegal. Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings. |
| `MTShield` | A simple component producing an HTML shield styled after svgs from shield.io (square, flat variety) |
| `MTSlidingContent` | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| `MTSlidingTabBar` | An `MTTabBar` augmented with content displayed in a `MTSlidingContent` |
| `MTToastAnchor` | A port of [Blazored/Toast](https://github.com/Blazored/Toast), modified and styled à la Material Theme. Place once instance of this in your Blazor app at the top of `App.razor` or `MainLayout.razor`. Requires that you register an `IMTToastService` service and will throw an exception on startup if the service is not found. |

## Services
 
| Service | Notes |
| :------ | :---- |
| `IMTAnimatedNavigationManager` | Manages fade out/in page navigation, wrapping Blazor's `NavigationManager.NavigateTo()` function. This is purely optional and you can continue to use Blazor's navigtion if you don't want animation. |
| `IMTToastService` | Manages toast notification. Requires a `MTToastAnchor` component and will throw an exception when you attempt to show a toast notification if this isn't found. |

## Utilities
 
| Utility | Notes |
| :------ | :---- |
| `MTCascadingDefaults` | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| `MTTypography` | Constants for standard Material Theme typography. |
| `MTIconHelper` | Working with `IMTIcon` and `IMTIconFoundry` to implement `MTMIFoundry()` to specify [Material Icons](https://material.io/resources/icons/?style=baseline), and optionally `FAFoundry()` for [Font Awesome](https://fontawesome.com/icons?d=gallery) and `OIFoundry()` for [Open Iconic](https://useiconic.com/open) icons. Icon names are passed to components as a string, with an additional parameter of `IconFoundry` using utility functions from `MTIcon` to specify the foundry and its optional parameters. Your default icon foundry can be set in `MTCascadingDefaults` (which itself defaults to Material Icons) and then you can pass string names for the icon of your choice. For Font Awesome icons, omit the preceding "fas/r/l/d" because this is set as a Font Awesome foundry style and in `MTCascadingDefaults.FAIconStyle`. Font Awesome relative icon size and Material Icons theme are also similarly parameterized. BlazorMdc expects you to include Material Icons in your project (these are necessary for drop down arrows and so forth, but Font Awesome icons are discretionary depending upon your project's requirement - you do however need to use Font Awesome version 5 and Open Iconic version 1.1. |

## Future Development

- Add remaining Material Theme components.
- Add [density subsystem](https://material.io/develop/web/components/density/).
- Complete implementation of current components, in particular those points noted above as not being implemented.
- Target best practice (per notes in introduction) and perform quality audit.
- Build nullable numeric input in addition to current non nullables.
- Follow [Material Theme framework standards](https://material.io/develop/web/docs/framework-integration/).