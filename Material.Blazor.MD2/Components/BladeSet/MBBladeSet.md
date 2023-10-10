---
uid: C.MBBladeSet
title: MBBladeSet
---
# MBBladeSet

## Summary

A plus component to display blades to the right of the viewport in a manner inspired by Microsoft Azure.

- Styling is completely defined by the consumer and without any styling, blades are transparent and without borders.
- Blades work through a cascading value of type `MBBladeSet`. You add and remove blades by calling the `AddBlade` and `RemoveBlade` methods on this cascading value. See the [demo website code](https://github.com/Material-Blazor/Material.Blazor.MD2/blob/main/Material.Blazor.MD2/Components/BladeSet/MBBladeSet.razor.cs) for an example
- By default the page's main content reduces in width as blades are added, so blades appear within the viewport.
  - You can however specify a minimum width for main content to be applied to the `mb-bladeset-main-content` block.
  - You can do this either by modifying `mb-bladeset-main-content` directly in your CSS file, or adding CSS classes or styles to it using the `MainContentAdditionalCss` and `MainContentAdditionalStyles` parameters repectively.
  - See the Material.Blazor.MD2's [app.scss](https://github.com/Material-Blazor/Material.Blazor.MD2/blob/main/Material.Blazor.MD2.Website/Styles/app.scss) file for how we have used media queries with a `demo-blade-main-content` class that we apply on our website via the `MainContentAdditionalCss` parameter.
  - Note that `min-width` must be in absolute terms, i.e. using units of `px`, `em` or `rem`. Percentages, `auto`, `min-content` etc will be ignored by MBBladeSet.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBBladeSet&color=brightgreen)](xref:Material.Blazor.MD2.MBBladeSet)
