# BlazorMdc (pre release)

[![NuGet Downloads](https://img.shields.io/nuget/dt/BlazorMdc?label=NuGet%20Downloads)](https://www.nuget.org/packages/BlazorMdc/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](/LICENSE.md)
[![GitHub issues](https://img.shields.io/github/issues/BlazorMdc/BlazorMdc)](https://github.com/BlazorMdc/BlazorMdc/issues)
[![GitHub forks](https://img.shields.io/github/forks/BlazorMdc/BlazorMdc)](https://github.com/BlazorMdc/BlazorMdc/network/members)
[![GitHub stars](https://img.shields.io/github/stars/BlazorMdc/BlazorMdc)](https://github.com/BlazorMdc/BlazorMdc/stargazers)

## Lightweight Material Theme razor components for Blazor

BlazorMdc is a lightweight [Material Theme](https://material.io/) [web development platform](https://material.io/develop/web/) component library for [ASP.NET Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) that is rigorously faithful to the Material Theme's design philosophy, markup and code usage. Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as BlazorMdc. This is available at https://www.nuget.org/packages/BlazorMdc.

BlazorMdc isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from Telerik and Syncfusion; this is not an exhaustive list and there may be others. So why create BlazorMdc as yet another option? In building our Blazor applications using Material Theme we had some overriding objectives and to our taste this required a new library focussing on the following:

- Lightweight components that require the minimal possible setup and boilerplate Blazor coding and without intensive startup processing,
- Native Blazor code to the greatest possible extent, using JavaScript Interop only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application,
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable,
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS - BlazorMdc keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. So if you are less interested in that control but want to deliver something that looks good fast, this is where you may want to consider other libraries,
- Some added value components derived from core material theme components but that are not strictly material theme themselves. These include an autocomplete box, a confimration dialog, a date picker (following the material theme date picker specification quite closely) and formatted numeric input fields, and
- We aim for BlazorMdc to employ best practice for Blazor development. As a starting point this should be considered as being defined per [this video from NDC London, January 2020](https://www.youtube.com/watch?v=QnBYmTpugz0). We have plenty to do to arrive at that position.

Note that BlazorMdc is in the early stages of development, so there are likely to be **frequent breaking changes** until we reach version 1. This project is owned by [Dioptra](https://dioptra.tech) and is licensed under the terms of the MIT license.

Lastly if you want to contribute please note our [code of conduct](https://github.com/BlazorMdc/BlazorMdc/blob/master/CODE_OF_CONDUCT.md).

## Attribution

BlazorMdc is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting. At the present time we have revisited only a limited selection of components from RazorComponents.MaterialDesign - we are still under development.

We also want to acknowledge the work of 
* [Vladimir Samoilenko (@SamProf on Github)](https://github.com/SamProf) for his work on [MatBlazor](https://www.matblazor.com/). MatBlazor code was referenced and some small parts of the code were copied to be part of BlazorMdc (ClassMapper and StyleMapper).
* [Chris Sainty (@chrissainty on Github)](https://github.com/chrissainty) for his work on [Blazored/Toast](https://github.com/Blazored/Toast) which is the basis for PMdcToast.
* [ℳisterℳagoo (@mistermag00 on Twitter)](https://github.com/SQL-MisterMagoo/) for the `@:@{` construct used in PMdcPagedDataList and [Peter Morris (@mrpmorris on Github)](https://github.com/mrpmorris) for demonstrating this with code that we forked in [Blazor University](https://blazor-university.com/), christening it the "wig pig" - head to Blazor University to see why.

## Installation

Either fork this repo or use the Nuget package linked at the top of this document. Once the package is referenced in your project you will need to add one of the two following methods of linking CSS and JS in your html (there are non-minified blazormdc.* files to reference if you prefer). Note that if you fork this repo, we compile, bundle and minify SASS/CSS and JS. In Visual Studio you will need to install the [Web Compiler](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler) and [Bundler Minifier](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.BundlerMinifier) extensions.

Reference the `BlazorMdc` namespace with `@using BlazorMdc` to your `_Imports.razor` file and if you want to use `PMdcToast` add `services.AddPMdcToast();` to your `ConfigureServices` function for Blazor Server or to the `Main()` function for Blazor WASM.

**NOTE** - BlazorMdc works with [Material Components v5.1.0](https://github.com/material-components/material-components-web/releases/tag/v5.1.0). [Version 6.0.0](https://github.com/material-components/material-components-web/releases/tag/v6.0.0) released on 23 April 2020 causes dramatic markup failure. We aim to migrate promptly once we consider the relevant Material Theme documentation to be clear enough to enable this.

#### Option 1 - Using our bundled CSS and JS

We bundle the Material Theme CSS and JS into BlazorMdc for your convenience, and you will need to add three items to your index file. Place this in the the `<head>` tag:
```
    <link href="_content/BlazorMdc/blazormdc-bundled.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
```
and at the end of `<body>`:
```
    <script src="_content/BlazorMdc/blazormdc-bundled.min.js"></script>
```
See the [Blazor Server demo index file](BlazorMdc.Demo.WebServer/Pages/index_ssb.cshtml) for an example.

#### Option 2 - Using our unbundled CSS and JS 

If you want to directly reference the Material Theme CSS and JS from the unpkg CDN (or download it for yourself), place this in the `<head>` tag:
```
    <link href="_content/BlazorMdc/blazormdc.min.css" rel="stylesheet">
    <link href="https://unpkg.com/material-components-web@5.1.0/dist/material-components-web.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
```
and at the end of `<body>`:
```
    <script src="https://unpkg.com/material-components-web@5.1.0/dist/material-components-web.js"></script>
    <script src="_content/BlazorMdc/blazormdc.min.js"></script>
```
See the [Blazor WASM demo index file](BlazorMdc.Demo.WebServer/Pages/index_csb.cshtml) for an example.

## Demonstration website

We are not yet hosting a demonstration, but you can fork and download this project yourself. If you so so, set your default project to `BlazorMdc.Demo.WebServer`.

## Demonstration from local build

If you have cloned the repository and are building from source there is a project 'BlazorMDC.Demo.WebServer' that should be selected as the startup project.

There are four implemented solution configurations:

| Configuration | Notes |
| :------------ | :---- |
| `Debug_CSB` | This is a debug build. It defines two constants, DEBUG, and ClientSideBlazor. It executes using WASM. |
| `Debug_SSB` | Also a debug build, defines DEBUG and ServerSideBlazor. It executes in the context of the web server and the the client being displayed through a SignalR connection. |
| `Release_xSB` | These two (x=C or S) configurations are the same as the debug versions but are built as release and the DEBUG constant is replaced by RELEASE. |

The home page of the demonstration application shows the execution environment as well as the build mode.

## Components

The following is a list of core Material Theme components.

| Component | Notes |
| :-------- | :---- |
| `MdcButton` | A [Material Button](https://material.io/develop/web/components/buttons/). |
| `MdcCard` | A [Material Card](https://material.io/develop/web/components/cards/). _Requires ripple effect._ |
| `MdcCheckbox` | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| `MdcDataTable` | A [Material Data Table](https://material.io/develop/web/components/data-tables/) without row selection |
| `MdcDialog` | A [Material Dialog](https://material.io/develop/web/components/dialogs/). Can set scrim and escape button actions. |
| `MdcDrawer` | A [Material Drawer](https://material.io/develop/web/components/drawers/). _Awaits review_. |
| `MdcIconButton` | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| `MdcIconButtonToggle` | A toggle variant of the [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| `MdcLinearProgress` | A [Material Linear Progress bar](https://material.io/develop/web/components/linear-progress/). Only implements an indeterminate progress point |
| `MdcList` | A [Material List](https://material.io/develop/web/components/lists/). |
| `MdcMenu` | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| `MdcNavLink` | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. _Awaits review_. |
| `MdcRadioButton` | A [Material Radio Button](https://material.io/develop/web/components/input-controls/radio-buttons/). |
| `MdcSelect` | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| `MdcSwitch` | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| `MdcTabBar` | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). Displays tab contents as a `RenderFragment`, with mild 300ms fade animation with 12px left/right motion. |
| `MdcTextArea` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Implements the full width variety, but still needs to disable floating labels in this instance to follow MT guidelines - indeed full width fields with a floating label render poorly. |
| `MdcTextField` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| `MdcTopAppBar` | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). _Partially reviewed_. |

## Plus Components

The following are extra or 'plus' components that extend the strict, core Material Theme `MdcXxx` components with either additional functionality or in the case of `PMdcDatePicker` and `PMdcPaginator` implementing a specification that is yet to be implemented in the Material Theme CSS and JavaScript libraries.

| Component | Notes |
| :-------- | :---- |
| `PMdcAutocomplete` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) that drops a [menu](https://material.io/develop/web/components/menus/) for auto completion. Has parameters to allow blank results and for whitespace to be ignored in searches. Might consider forking and adapting [Blazored.Typeahead](https://github.com/Blazored/Typeahead) with MT styling. |
| `PMdcConfirmationDialog` | A special purpose wrapper around `MdcDialog` that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| `PMdcDatePicker` | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. Does not implement date ranges. Date pickers are only implemented in Material Theme for Android, so we interpreted as closely as possible the specification with our own CSS. This is the only instance where we have created CSS for a component, because our goal is to use standard Material Theme styling throughout. The result seems a bit too dense and is within a couple of pixels of unstyled overflow content on the month selection menu for long month names in English; this is likely to overflow for languages with longer month names. We are therefore likely to relax the component's density, which should improve usability. We have deviated from the specification by adding an "undo" button to return to the current selected date. There is no "today" button, which is not in the Material Theme specification. |
| `PMdcDebouncedTextField` | A debounced version of `MdcTextField` |
| `PMdcDivider` | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. | 
| `PMdcNumericDoubleField` | Wraps `MdcTextField` to format numeric entry of a `double`. The format is applied when the component lacks focus, at which point the field is a text field holding the formatted number as text. When the field gains focus it switches to a number field. Allows for percentages to be entered as a whole number, e.g. typing "12" will yield a `double` equal to '0.12' and displaying '12%' when lacking focus. We intend to find a similar way to handle [basis points](https://en.wikipedia.org/wiki/Basis_point). |
| `PMdcNumericIntField` | A wrapper for `MdcpNumericDoubleField` for `int` variables. |
| `PMdcPagedDataList` | A templated component for paging generic data lists using `PMdcPaginator`. Uses the Wig Pig nested coding pattern and can either render list items one by one or wrap a component such as `MdcList` or `MdcDataTable`. |
| `PMdcPaginator` | An implementation of the [Material paginator specification](https://material.io/components/data-tables#behavior). |
| `PMdcRadioButtonGroup` | A group of MdcRadioButtons. The ItemValidation parameter has three possible values. Exception is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data. DefaultToFirst will select the first item in the list if the Value does not match. NoSelection will not pick a radiobutton when the Value is illegal. Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings. |
| `PMdcSlidingContent` | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| `PMdcToast` | A port of [Blazored/Toast](https://github.com/Blazored/Toast) yet to be styled à la Material Theme. |

## Utilities
 
| Utility | Notes |
| :-------- | :---- |
| `MdcCascadingDefaults` | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| `MdcTypography` | Constants for standard Material Theme typography. |

## Future Development

- Add remaining Material Theme components.
- Add [density subsystem](https://material.io/develop/web/components/density/).
- Complete implementation of current components, in particular those points noted above as not being implemented.
- Target best practice (per notes in introduction) and perform quality audit.
- Build nullable numeric input in addition to current non nullables.
- Follow [Material Theme framework standards](https://material.io/develop/web/docs/framework-integration/).
