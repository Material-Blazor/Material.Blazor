---
uid: A.Installation
title: Installation
---
# Installation

Either fork this repo or use the Nuget package linked at the top of this document. Once the package is referenced in your project you will need to add the CSS and JS in your html (there are non-minified unbundled files for BlazorMdc.css & BlazorMds.js to reference if you need them for debugging purposes).
Reference the `BlazorMdc` namespace with `@using BlazorMdc` to your `_Imports.razor` file. 

## Directions for using Blazor MDC bundled CSS and JS

***This is the recommended way to install Blazor MDC.***

We bundle the Material Theme CSS and JS into BlazorMdc for your convenience along with [Material Icons](https://material.io/resources/icons/?style=baseline) which are essential for BlazorMdc. You will need to add two items to your index.html/_Host.cshtml file. Place this in the the `<head>` tag:

```html
<link href="_content/BlazorMdc/blazormdc-material-bundle.min.css" rel="stylesheet">
```

and at the end of `<body>`:

```html
<script src="_content/BlazorMdc/blazormdc-material-bundle.min.js"></script>
```

Add the BlazorMdc namespace to your project by appending `@using BlazorMdc` to the end of your project's _Imports.razor file. Do not use components from the BlazorMdc.Internal namespace: as the name
implies these are intended for internal use by Blazor MDC, however Blazor has no mechanism for internally restricted Blazor components to mirror the `internal` directive for a C# class.

## Alternative using unbundled CSS and JS

If you want, you can directly reference the Material Theme CSS and JS from the unpkg CDN (or download it for yourself). Again we package a reference to Material Icons. You will to add five items to your index.html/_Host.cshtml. Place this in the <head>` tag:

```html
<link href="https://fonts.googleapis.com/icon?family=Material+Icons|Material+Icons+Outlined|Material+Icons+Two+Tone|Material+Icons+Round|Material+Icons+Sharp" rel="stylesheet">
<link href="https://unpkg.com/material-components-web@7.0.0/dist/material-components-web.css" rel="stylesheet" />
<link href="_content/BlazorMdc/blazormdc.css" rel="stylesheet" />
```

and at the end of `<body>`:

```html
<script src="https://unpkg.com/material-components-web@7.0.0/dist/material-components-web.js"></script>
<script src="_content/BlazorMdc/blazormdc.js"></script>
```

We also provide minified `blazormdc.min.css` and `blazormdc.min.js`. Add the BlazorMdc namespace to your project as above. These will be needed
if you want to create your own theme using Material Theme SASS mixins - we have done this for [blazormc.com](https://blazormdc.com)

## Package versions

Blazor MDC works with the following package versions:

- [Material Components v7.0.0](https://github.com/material-components/material-components-web/blob/master/CHANGELOG.md#700-2020-06-23);
- [Font Awesome Icons version 5](https://fontawesome.com/changelog/latest) are optional and can be included in your HTML `<head>` with the CDN link:
    ```html
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.14.0/css/all.min.css" integrity="sha512-1PKOgIY59xJ8Co8+NE6FZ+LOAZKjy+KY8iq0G4B3CyeY6wYHN3yt9PW0XpSriVlkMXe40PTKnXrLnZ9+fkDaog==" crossorigin="anonymous" />
    ```
- [Open Iconic Icons version 1.1](https://useiconic.com/open) are also optional and can be included in your HTML `<head>` with the CDN link:
    ```html
    <link href="https://cdnjs.cloudflare.com/ajax/libs/open-iconic/1.1.1/font/css/open-iconic.min.css" crossorigin="anonymous" rel="stylesheet" />
    ```

## Services and Anchor

Blazor MDC has three services for animated navigation, toasts, and tooltips. We strongly advise you to use these in your project
because regular component tooltips will fail if you don't, although they are optional. To register the services:

```csharp
serviceCollection.AddMTServices(
    toastServiceConfiguration: new MTToastServiceConfiguration()
    {
        InfoDefaultHeading = "Info",
        SuccessDefaultHeading = "Success",
        WarningDefaultHeading = "Warning",
        ErrorDefaultHeading = "Error",
        Timeout = 5000,
        MaxToastsShowing = 5
    },

    animatedNavigationServiceConfiguration: new MTAnimatedNavigationServiceConfiguration()
    {
        ApplyAnimation = true,
        AnimationTime = 300
    }
);
```

The two configurations are optional - see [MTToastServiceConfiguration](xref:BlazorMdc.MTToastServiceConfiguration) and [MTAnimatedNavigationServiceConfiguration](xref:BlazorMdc.MTAnimatedNavigationServiceConfiguration).

When you use the services you must also place an anchor component at the top of `MainLayout.razor`, which must not be inside any other components or divs:

```html
<MTAnchor />
```

## Binding

BlazorMDC components support the EditForm environment. To that end BlazorMDC uses the 

```csharp
FieldIdentifier.Create(ValueExpression) 
```

construct. This means that values to be bound are limited to fields and properties. As an example, should you try to bind to an array element as in

```html
<Component @bind-Value="@boolArray[0]" />
```

you will be met with a runtime error of

`Error: System.ArgumentException: The provided expression contains a SimpleBinaryExpression which is not supported. FieldIdentifier only supports simple member accessors (fields, properties) of an object.`

