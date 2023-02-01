---
uid: C.MBAnchor
title: MBAnchor
---
# MBAnchor

## Summary

An anchor component for snackbars, toasts (based on a port of [Blazored/Toast](https://github.com/Blazored/Toast)) and tooltips.

## Details

-  Place once instance of this in your Blazor app in `App.razor` or in your layout component page that is used for all application components that use snackbars, toasts and tooltips.
- Register services by calling [services.AddMBServices()](xref:Material.Blazor.ServiceCollectionExtensions#methods)).
- The anchor will throw an exception on startup if the services registered by AddMBServices are not found.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBAnchor&color=brightgreen)](xref:Material.Blazor.MBAnchor)