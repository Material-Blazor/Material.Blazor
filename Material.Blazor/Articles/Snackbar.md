---
uid: A.Snackbar
title: Snackbar
---
# Snackbar

## Summary

The snackbar service provides standard Material Theme snackbars.

## Service Setup and Anchor

The service is installed as described in the [Installation article](xref:A.Installation).
Configuration parameters are 
listed on the [IMBSnackbarService](xref:Material.Blazor.IMBSnackbarService) page. You will also need to place the 
[MBAnchor component](xref:C.MBAnchor) in App.razor, also as shown in the [Installation article](xref:A.Installation).

## Launching a Snackbar

Sanckbars are launched from C# code.
Use dependency injection to get an [IMBSnackbarService](xref:S.IMBSnackbarService) as relevant and then
call [ShowSnackbar() method](xref:Material.Blazor.IMBSnackbarService#methods).
