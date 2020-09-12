---
uid: C.MBPagedDataList
title: MBPagedDataList
---
# MBPagedDataList&lt;TItem&gt;

## Summary

A templated component for paging generic data lists using [MBPaginator](xref:C.MBPaginator). Uses the ["Wig Pig" nested coding pattern](https://blazor-university.com/templating-components-with-renderfragements/passing-placeholders-to-renderfragments/) and can either render list items one by one or wrap a component such as [MBList](xref:C.MBList) or [MBDataTable](xref:C.MBDataTable).

## Details

- Paginates an IEnumerable of a data item that you define (TItem);
- Can either apply basic formatting of that data on your behalf, or allow your render fragment access to the skip/take paginated section of your dataset for you to render;
- Uses [MBSlidingContent](xref:C.MBSlidingContent) to apply subtle left/right, fade out/in animation to indicate page transitions to the user;
- Integrates with [MBPaginator](xref:C.MBPaginator) and its parameterization, including two-way binding for the page number;

## Assisting Blazor Rendering with `@key`

- MBPagedDataList renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MBPagedDataList by default uses each item in the `Data` parameter as the key, however you can override this. Material.Blazor does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MBList demonstration website page's code](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website.Components/Pages/List.razor#L155).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBPagedDataList&color=brightgreen)](xref:Material.Blazor.MBPagedDataList`1)
