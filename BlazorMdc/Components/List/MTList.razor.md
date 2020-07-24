---
uid: C.MTList
title: MTList
---
# MTList&lt;TItem&gt;

### Summary

A [Material List](https://material.io/develop/web/components/lists/). Uses render fragments to implement Material Theme Web Components one and two line lists, plus a BlazorMdc interpretation of a three line list. It features:

### Details

- A title line render fragment;
- IEnumerable render fragments for the first, second and third lines of each list item;
- Icon IEnumerable render fragments that can be ignorred and suppressed with a boolean switch;
- IEnumerable avatar list render fragment;
- IEnumerable actions render fragment;
- Indicators for dense layout, dividers between items, whether keyboard interactions and ripple are activated, and whether lines two or three of each item are hidden;
- Click, KeyDown, MouseDown and TouchStart event handlers that return the index of the item receiving user interaction;
- Applies [density subsystem](xref:A.Density).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTList&color=brightgreen)](xref:BlazorMdc.MTList`1)