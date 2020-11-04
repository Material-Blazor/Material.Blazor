---
uid: C.MBSlidingTabBar
title: MBSlidingTabBar
---
# MBSlidingTabBar&lt;TItem&gt;

## Summary

A combination of a simple [MBTabBar](xref:C.MBTabBar) with an [MBSlidingContent](xref:C.MBSlidingContent) to provide an all-in-one tab bar
solution that uses navigation animation cues to inform the user of navigation events.

## Details

- Takes input relvant to each of [MBTabBar](xref:C.MBTabBar) and [MBSlidingContent](xref:C.MBSlidingContent) for the tab titles/icons and tab panel contents.

## Assisting Blazor Rendering with `@key`

- MBSlidingTabBar renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MBSlidingTabBar by default uses each item in the `Items` parameter as the key, however you can override this. Material.Blazor does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MBList demonstration website page's code](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website/Pages/List.razor#L155).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBSlidingTabBar&color=brightgreen)](xref:Material.Blazor.MBSlidingTabBar`1)
