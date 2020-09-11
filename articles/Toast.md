---
uid: A.Toast
title: Toast
---
# Toast

## Summary

The toast service is an added extra, styled to fit in with Blazor MDC, but outside the Material Theme specification. Our implementation is a reworked port of
[Chris Sainty's Blazored/Toast](https://github.com/Blazored/Toast).

## Service Setup and Anchor

The service is installed as described in the [Installation article](xref:A.Installation). Configuration parameters are 
listed on the [IMBToastService class api documentation page](xref:BlazorMdc.IMBToastService). You will also need to place the 
[MBAnchor component](xref:C.MBAnchor) in App.razor, also as shown in the [Installation article](xref:A.Installation).

## Launching a Toast

Toasts are launched from C# code. Use dependency injection to get an [IMBToastService](xref:S.IMBToastService) and then
call a toast using its [ShowToast() method](xref:BlazorMdc.IMBToastService#methods).