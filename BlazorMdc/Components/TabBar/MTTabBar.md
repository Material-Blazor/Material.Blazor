---
uid: C.MTTabBar
title: MTTabBar
---
# MTTabBar&lt;TItem&gt;

## Summary

A [Material Tab Bar](https://github.com/material-components/material-components-web/tree/v7.0.0/packages/mdc-tab-bar#tab-bar), including scroll function for when the tab bar is wider than the viewport.

## Details

- Accepts an IEnumerable of tab labels and (optional) icons;
- Two-way binds the tab index number;
- **Ignores the `Disabled` attribute**
- Takes a boolean to indicate whether icons are stacked vertically above labels or not; and
- Applies [density subsystem](xref:A.Density).

## Assisting Blazor Rendering with `@key`

- MTTabBar renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MTTabBar by default uses each item in the `Items` parameter as the key, however you can override this. Blazor MDC does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MTList demonstration website page's code](https://github.com/BlazorMdc/BlazorMdc/blob/main/BlazorMdcWebsite.Components/Pages/List.razor#L155).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTTabBar&color=brightgreen)](xref:BlazorMdc.MTTabBar`1)