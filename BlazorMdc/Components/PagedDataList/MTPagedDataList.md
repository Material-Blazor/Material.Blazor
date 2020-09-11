---
uid: C.MTPagedDataList
title: MTPagedDataList
---
# MTPagedDataList&lt;TItem&gt;

## Summary

A templated component for paging generic data lists using [MTPaginator](xref:C.MTPaginator). Uses the ["Wig Pig" nested coding pattern](https://blazor-university.com/templating-components-with-renderfragements/passing-placeholders-to-renderfragments/) and can either render list items one by one or wrap a component such as [MTList](xref:C.MTList) or [MTDataTable](xref:C.MTDataTable).

## Details

- Paginates an IEnumerable of a data item that you define (TItem);
- Can either apply basic formatting of that data on your behalf, or allow your render fragment access to the skip/take paginated section of your dataset for you to render;
- Uses [MTSlidingContent](xref:C.MTSlidingContent) to apply subtle left/right, fade out/in animation to indicate page transitions to the user;
- Integrates with [MTPaginator](xref:C.MTPaginator) and its parameterization, including two-way binding for the page number;

## Assisting Blazor Rendering with `@key`

- MTPagedDataList renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MTPagedDataList by default uses each item in the `Data` parameter as the key, however you can override this. Blazor MDC does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MTList demonstration website page's code](https://github.com/BlazorMdc/BlazorMdc/blob/main/BlazorMdcWebsite.Components/Pages/List.razor#L155).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTPagedDataList&color=brightgreen)](xref:BlazorMdc.MTPagedDataList`1)