---
uid: C.MBList
title: MBList
---
# MBList&lt;TItem&gt;

## Summary

A partial implementation of a [Material List](https://github.com/material-components/material-components-web/tree/v8.0.0/packages/mdc-list#lists). Uses render fragments to implement Material Theme Web Components one and two line lists, plus a Material.Blazor interpretation of a three line list. It features:

## Details

- A title line render fragment;
- IEnumerable render fragments for the first, second and third lines of each list item;
- Icon IEnumerable render fragments that can be ignorred and suppressed with a boolean switch;
- IEnumerable avatar list render fragment;
- IEnumerable actions render fragment;
- Indicators for dense layout, dividers between items, whether keyboard interactions and ripple are activated, and whether lines two or three of each item are hidden;
- Click, KeyDown, MouseDown and TouchStart event handlers that return the index of the item receiving user interaction;
- Applies [density subsystem](xref:A.Density).

## Assisting Blazor Rendering with `@key`

- MBList renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MBList by default uses each item in the `Items` parameter as the key, however you can override this. Material.Blazor does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MBList demonstration website page's code](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website/Pages/List.razor#L155).

## Partial Implementation

MBList does not implement:

- Multi-select
- Checkbox

## Reserved Attributes

The following attributes are reserved by Material Components Web and will be ignored if you supply them:

- aria-orientation
- aria-valuemax

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBList&color=brightgreen)](xref:Material.Blazor.MBList`1)
