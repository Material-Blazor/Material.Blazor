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

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTPagedDataList&color=brightgreen)](xref:BlazorMdc.MTPagedDataList`1)