---
uid: A.ToastAndSnackbar
title: ToastAndSnackbar
---
# Toast & Snackbar

## Summary

The snackbar service provides standard Material Theme snackbars.

The toast service is an added extra, styled to fit in with Material.Blazor, but outside the Material Theme specification. Our implementation is a reworked port of
[Chris Sainty's Blazored/Toast](https://github.com/Blazored/Toast).

## Service Setup and Anchor

The services are installed as described in the [Installation article](xref:A.Installation). Configuration parameters are 
listed on the [IMBToastService class api documentation page](xref:Material.Blazor.IMBToastService) and the same for [IMBSnackbarService](xref:Material.Blazor.IMBSnackbarService). You will also need to place the 
[MBAnchor component](xref:C.MBAnchor) in App.razor, also as shown in the [Installation article](xref:A.Installation).

## Launching a Toast or Snackbar

Both are launched from C# code. Use dependency injection to get an [IMBToastService](xref:S.IMBToastService) or  [IMBSnackbarService](xref:S.IMBSnackbarService) as relevant and then
call a toast using its [ShowToast() method](xref:Material.Blazor.IMBToastService#methods) or [ShowSnackbar() method](xref:Material.Blazor.IMBSnackbarService#methods).
