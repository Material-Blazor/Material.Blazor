---
uid: C.MTAnchor
title: MTAnchor
---
# MTAnchor

## Summary

An anchor component for toasts and tooltips (based on a port of [Blazored/Toast](https://github.com/Blazored/Toast)).

## Details

-  Place once instance of this in your Blazor app in `App.razor` or in your layout component page that is used for all application components that use toasts and tooltips.
-  Register services by calling [services.AddMtServices()](xref:BlazorMdc.ServiceCollectionExtensions.AddMTServices(Microsoft.Extensions.DependencyInjection.IServiceCollection,BlazorMdc.MTToastServiceConfiguration,BlazorMdc.MTAnimatedNavigationManagerServiceConfiguration)).
- The anchor will throw an exception on startup if the services registered by AddMTServices are not found.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTToastAnchor&color=brightgreen)](xref:BlazorMdc.MTToastAnchor)