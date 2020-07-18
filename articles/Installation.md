---
uid: A.Installation
title: Installation
---
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