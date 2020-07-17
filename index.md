# BlazorMdc (1.0.0-Preview.1.16)

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

[See the Installation article](articles/Installation.md)

## Demonstration

[See the Demonstration article](articles/Demonstration.md)

## Components, Services, and Utilities

[See the Components/Services/Utilities documentation](BlazorMdc/Components/Intro.md)

## Future Development

- Add remaining Material Theme components.
- Add [density subsystem](https://material.io/develop/web/components/density/).
- Complete implementation of current components, in particular those points noted above as not being implemented.
- Target best practice (per notes in introduction) and perform quality audit.
- Build nullable numeric input in addition to current non nullables.
- Follow [Material Theme framework standards](https://material.io/develop/web/docs/framework-integration/).