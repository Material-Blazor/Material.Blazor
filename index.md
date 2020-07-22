# Blazor MDC

[![NuGet version](https://img.shields.io/nuget/v/BlazorMdc?logo=nuget&label=nuget%20version&style=flat-square)](https://www.nuget.org/packages/BlazorMdc/)
[![NuGet downloads](https://img.shields.io/nuget/dt/BlazorMdc?logo=nuget&label=nuget%20downloads&style=flat-square)](https://www.nuget.org/packages/BlazorMdc/)
[![Gitter](https://img.shields.io/gitter/room/BlazorMdc/community?logo=gitter&style=flat-square)](https://gitter.im/BlazorMdc/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

<br />

>[!TIP]
>Visit our website at https://blazormdc.com which is being developed as a new Blazor MDC demonstration.

## Lightweight Material Theme razor components for Blazor

Blazor MDC is a lightweight [Material Theme](https://material.io/) [web development platform](https://material.io/develop/web/) ([version 7.0.0]((https://github.com/material-components/material-components-web/blob/master/CHANGELOG.md#600-2020-04-22))) component library for [ASP.NET Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) that is rigorously faithful to the Material Theme's design philosophy, markup and code usage. Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as Blazor MDC. This is available at https://www.nuget.org/packages/BlazorMdc.

Blazor MDC isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from [Telerik](https://www.telerik.com/blazor-ui), and [Syncfusion](https://blazor.syncfusion.com/); this is not an exhaustive list and there may be others. So why did we create Blazor MDC as yet another option? In building our Blazor applications using Material Theme we had some overriding objectives and to our taste this required a new library focussing on the following:

- Permissive [MIT license](xref:A.License) and a clear [contributor code of conduct](xref:A.CodeOfConduct);
- Lightweight components that require the minimal possible setup or boilerplate Blazor coding and without intensive startup processing;
- An entirely native Blazor experience for Blazor MDC's consumer, using JavaScript Interop within Blazor MDC only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application;
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable;
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS. Blazor MDC keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. This requires you to manage your layout because Blazor MDC does not attempt to give you layout shortcuts. This is so you can decide what layout system to use? Material Theme, Bootstrap or as you wish. Other libraries take a different approach, and if you have a different requirement you may want to consider other options;
- Some added value components derived from core material theme components but that are not strictly material theme themselves. These include an autocomplete box, a confimration dialog and formatted numeric input fields. We also provide a date picker and paginator, each of which follow Material Theme specification in the absence of a Material Theme css/js implementation; and
- We aim for Blazor MDC to employ best practice for Blazor development. As a starting point this should be considered as being defined per [this video from NDC London, January 2020](https://www.youtube.com/watch?v=QnBYmTpugz0).

## Attribution

Blazor MDC is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting. At the present time we have revisited only a limited selection of components from RazorComponents.MaterialDesign - we are still under development.

We also want to acknowledge the work of 
* [Vladimir Samoilenko (@SamProf on Github)](https://github.com/SamProf) for his work on [MatBlazor](https://www.matblazor.com/). MatBlazor code was referenced and some small parts of the code were copied to be part of Blazor MDC (ClassMapper and StyleMapper).
* [Chris Sainty (@chrissainty on Github)](https://github.com/chrissainty) for his work on [Blazored/Toast](https://github.com/Blazored/Toast) which is the basis for MTToast.
* [ℳisterℳagoo (@mistermag00 on Twitter)](https://github.com/SQL-MisterMagoo/) for the `@:@{` construct used in MTPagedDataList and [Peter Morris (@mrpmorris on Github)](https://github.com/mrpmorris) for demonstrating this with code that we forked in [Blazor University](https://blazor-university.com/), christening it the "wig pig" - head to Blazor University to see why.

## Installation

[See the Installation article](articles/Installation.md)

## Demonstration

[See the Demonstration article](articles/Demonstration.md)

## Components, Services, and Utilities

[See the Components/Services/Utilities documentation](BlazorMdc/Components/Intro.md)

## Future Work

- Add remaining Material Theme components.
- Add [density subsystem](https://material.io/develop/web/components/density/).
- Target best practice (per notes in introduction) and perform further quality audit.
- Build nullable numeric input in addition to current non nullables.
- Continually review and follow [Material Theme framework standards](https://material.io/develop/web/docs/framework-integration/).

<br />
<br />

---

<br />

[![NuGet version](https://img.shields.io/nuget/v/BlazorMdc?logo=nuget&label=nuget%20version&style=flat-square)](https://www.nuget.org/packages/BlazorMdc/)
[![NuGet downloads](https://img.shields.io/nuget/dt/BlazorMdc?logo=nuget&label=nuget%20downloads&style=flat-square)](https://www.nuget.org/packages/BlazorMdc/)
[![Gitter](https://img.shields.io/gitter/room/BlazorMdc/community?logo=gitter&style=flat-square)](https://gitter.im/BlazorMdc/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?logo=github&style=flat-square)](/LICENSE.md)
[![GitHub issues](https://img.shields.io/github/issues/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/issues)
[![GitHub forks](https://img.shields.io/github/forks/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/network/members)
[![GitHub stars](https://img.shields.io/github/stars/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/stargazers)
[![GitHub stars](https://img.shields.io/github/watchers/BlazorMdc/BlazorMdc?logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/watchers)

[![GithubActionsMainPublish](https://img.shields.io/github/workflow/status/blazormdc/blazormdc/GithubActionsMainPublish?label=actions%20main&logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/actions?query=workflow%3AGithubActionsMainPublish)
[![GithubActionsDevelop](https://img.shields.io/github/workflow/status/blazormdc/blazormdc/GithubActionsDevelop?label=actions%20develop&logo=github&style=flat-square)](https://github.com/BlazorMdc/BlazorMdc/actions?query=workflow%3AGithubActionsDevelop)
