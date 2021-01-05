---
uid: A.Installation
title: Installation
---
# Installation

Either fork this repo or use the Nuget package linked at the top of this document. Once the package is referenced in your project you will need to add the CSS and JS in your html.

There are non-minified files of MaterialBlazor.css & MaterialBlazor.js available to reference if you need them for debugging purposes. You will have to fork the repository and build to get the non-minified files.

Add the `Material.Blazor` namespace to your project by appending `@using Material.Blazor` to the end of your project's _Imports.razor file. Do not use components from the `Material.Blazor.Internal` namespace: as the name
implies these are intended for internal use by Material.Blazor, however Blazor has no mechanism for internally restricted Blazor components to mirror the `internal` directive for a C# class.

## Obtaining the requisite CSS and JS

If you want, you can directly reference the Material Theme CSS and JS from the unpkg CDN (or download it for yourself). We package the css for 
 Material, Font Awesome, and Open Iconic icons. You will to add three items to your index.html/_Host.cshtml. Place this in the `<head>` tag:

```html
<link href="https://unpkg.com/material-components-web@8.0.0/dist/material-components-web.css" rel="stylesheet" />
<link href="_content/Material.Blazor/MaterialBlazor.min.css" rel="stylesheet" />
```

and at the end of `<body>`:

```html
<script src="_content/Material.Blazor/MaterialBlazor.min.js"></script>
```

 Replace the unpkg CSS with your own
if you have built a theme - you can see how we have done this in the [Material.Blazor website's index.html](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website.WebAssembly/wwwroot/index.html#L14).
## Package versions

Material.Blazor works with the following package versions:

- [Material Components v8.0.0](https://github.com/material-components/material-components-web/blob/master/CHANGELOG.md#800-2020-11-02)

## Services and Anchor

Material.Blazor has three services for animated navigation, toasts, and tooltips. We strongly advise you to use these in your project
because regular component tooltips will fail if you don't, although they are optional. To register the services:

```csharp
services.AddMBServices(
    toastServiceConfiguration: new MBToastServiceConfiguration()
    {
        InfoDefaultHeading = "Info",
        SuccessDefaultHeading = "Success",
        WarningDefaultHeading = "Warning",
        ErrorDefaultHeading = "Error",
        Timeout = 5000,
        MaxToastsShowing = 5
    },

    animatedNavigationServiceConfiguration: new MBAnimatedNavigationManagerServiceConfiguration()
    {
        ApplyAnimation = true,
        AnimationTime = 300
    }
);
```

The two configurations are optional - see [MBToastServiceConfiguration](xref:Material.Blazor.MBToastServiceConfiguration) and [MBAnimatedNavigationManagerServiceConfiguration](xref:Material.Blazor.MBAnimatedNavigationManagerServiceConfiguration).

When you use the services you must also place an anchor component at the top of `App.razor` - this must not be inside any other components or divs:

```html
<MBAnchor />
```

## Binding

Material.Blazor components support the EditForm environment. To that end Material.Blazor uses the 

```csharp
FieldIdentifier.Create(ValueExpression) 
```

construct. This means that values to be bound are limited to fields and properties. As an example, should you try to bind to an array element as in

```html
<Component @bind-Value="@boolArray[0]" />
```

you will be met with a runtime error of

`Error: System.ArgumentException: The provided expression contains a SimpleBinaryExpression which is not supported. FieldIdentifier only supports simple member accessors (fields, properties) of an object.`

