# Material.Blazor

[![NuGet version](https://img.shields.io/nuget/v/Material.Blazor?logo=nuget&label=nuget%20version&style=flat-square)](https://www.nuget.org/packages/Material.Blazor/)
[![NuGet downloads](https://img.shields.io/nuget/dt/Material.Blazor?logo=nuget&label=nuget%20downloads&style=flat-square)](https://www.nuget.org/packages/Material.Blazor/)
[![Gitter](https://img.shields.io/gitter/room/Material.Blazor/community?logo=gitter&style=flat-square)](https://gitter.im/Material-Blazor/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

<br />

>[!TIP]
>Visit our website at https://material-blazor.com for a full Material.Blazor demonstration.

# Lightweight Material Theme Razor Components for Blazor

Material.Blazor is a lightweight [Material Theme](https://material.io/) [web development platform](https://material.io/develop/web/) ([version 8.0.0]((https://github.com/material-components/material-components-web/blob/master/CHANGELOG.md#800-2020-11-02))) component library for [ASP.NET Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) that is rigorously faithful to the Material Theme's design philosophy, markup and code usage.
This docs site along with [our demonstration website](https://material-blazor.com) gives you a deep dive into Material.Blazor.

<div style="text-align: right; font-style: italic;">Simon and Mark</div>

## Background

Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as Material.Blazor. This is available at https://www.nuget.org/packages/Material.Blazor.

Material.Blazor isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from [Telerik](https://www.telerik.com/blazor-ui), and [Syncfusion](https://blazor.syncfusion.com/); this is not an exhaustive list and there may be others. So why did we create Material.Blazor as yet another option? Because we had some overriding objectives and to our taste this required a new library focussing on the following:

- Lightweight components that require the minimal possible setup or boilerplate Blazor coding and without intensive startup processing;
- An entirely native Blazor experience for Material.Blazor's consumer, using JavaScript Interop within Material.Blazor only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application;
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable;
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS:
  - Material.Blazor keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability.
  - We don't help you with styling/CSS. Whether you are theming or just tailoring the styles of individual components within a `<div>` block, you need to be very familar with [Material Components Web](https://github.com/material-components/material-components-web/tree/v8.0.0/packages). If you think you like or dislike the look of one of our "core" Material.Blazor components, what you're actually viewing is Material Theme as Google intend it, and which we aim to bring faithfully to you.
  - Similarly you need to manage your layout because Material.Blazor doesn't try to help out. This is so you can decide what layout system to use - Material Theme, Bootstrap or whatever you want.
  - So: we just do components using Material Theme. Other libraries take a different approach, and if you have a different requirement you may want to consider other options;
- You'll find some different themes [on our website](https://material-blazor.com) just to give you a flavour of what can be done. Note that these themes aren't really anything to do with Material.Blazor - we just decided to show that Material.Blazor works with themes built using [material-components-web](https://github.com/material-components/material-components-web). Click the button on the top right of the top app bar. See the code base (same repo as this) to see how we did it.
- We've built some added value "plus" components derived from core material theme components but that are not strictly material theme themselves. These include an autocomplete box, a confimration dialog and formatted numeric input fields. We also provide a date picker and paginator, each of which follow Material Theme specification in the absence of a Material Theme css/js implementation;
- We aim for Material.Blazor to employ best practice for Blazor development. As a starting point this should be considered as being defined per [this video from NDC London, January 2020](https://www.youtube.com/watch?v=QnBYmTpugz0); and
- Permissive [MIT license](xref:A.License) and a clear [contributor code of conduct](xref:A.CodeOfConduct).

## Attribution

Material.Blazor is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting.

We also want to acknowledge the work of 
* [Vladimir Samoilenko (@SamProf on Github)](https://github.com/SamProf) for his work on [MatBlazor](https://www.matblazor.com/). MatBlazor code was referenced and some small parts of the code were copied to be part of Material.Blazor (ClassMapper and StyleMapper).
* [Chris Sainty (@chrissainty on Github)](https://github.com/chrissainty) for his work on [Blazored/Toast](https://github.com/Blazored/Toast) which is the basis for MBToast.
* [ℳisterℳagoo (@mistermag00 on Twitter)](https://github.com/SQL-MisterMagoo/) for the `@:@{` construct used in MBPagedDataList and [Peter Morris (@mrpmorris on Github)](https://github.com/mrpmorris) for demonstrating this with code that we forked in [Blazor University](https://blazor-university.com/), christening it the "wig pig" - head to Blazor University to see why.

## Installation

[See the Installation article](articles/Installation.md)

## Components, Services, and Utilities

[See the Components/Services/Utilities documentation](Material.Blazor/Components/Intro.md)

<br />
<br />

---

<br />

[![NuGet version](https://img.shields.io/nuget/v/Material.Blazor?logo=nuget&label=nuget%20version&style=flat-square)](https://www.nuget.org/packages/Material.Blazor/)
[![NuGet downloads](https://img.shields.io/nuget/dt/Material.Blazor?logo=nuget&label=nuget%20downloads&style=flat-square)](https://www.nuget.org/packages/Material.Blazor/)
[![Gitter](https://img.shields.io/gitter/room/Material.Blazor/community?logo=gitter&style=flat-square)](https://gitter.im/Material.Blazor/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?logo=github&style=flat-square)](/LICENSE.md)
[![GitHub issues](https://img.shields.io/github/issues/Material-Blazor/Material.Blazor?logo=github&style=flat-square)](https://github.com/Material-Blazor/Material.Blazor/issues)
[![GitHub forks](https://img.shields.io/github/forks/Material-Blazor/Material.Blazor?logo=github&style=flat-square)](https://github.com/Material-Blazor/Material.Blazor/network/members)
[![GitHub stars](https://img.shields.io/github/stars/Material-Blazor/Material.Blazor?logo=github&style=flat-square)](https://github.com/Material-Blazor/Material.Blazor/stargazers)
[![GitHub stars](https://img.shields.io/github/watchers/Material-Blazor/Material.Blazor?logo=github&style=flat-square)](https://github.com/Material-Blazor/Material.Blazor/watchers)

[![GithubActionsMainPublish](https://img.shields.io/github/workflow/status/Material-Blazor/Material.Blazor/GithubActionsMainPublish?label=actions%20main&logo=github&style=flat-square)](https://github.com/Material-Blazor/Material.Blazor/actions?query=workflow%3AGithubActionsMainPublish)
[![GithubActionsDevelop](https://img.shields.io/github/workflow/status/Material-Blazor/Material.Blazor/GithubActionsDevelop?label=actions%20develop&logo=github&style=flat-square)](https://github.com/Material-Blazor/Material.Blazor/actions?query=workflow%3AGithubActionsDevelop)