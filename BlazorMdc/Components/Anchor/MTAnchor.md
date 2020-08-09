---
uid: C.MTAnchor
title: MTAnchor
---
# MTAnchor

### Summary

An anchor component for toasts and tooltips, based on a port of [Blazored/Toast](https://github.com/Blazored/Toast), modified and styled for Material Theme.

### Details

-  Place once instance of this in your Blazor app at the top of `App.razor`or `MainLayout.razor`; and
-  Requires that you register services by calling [services.AddMtServices()](xref:BlazorMdc.ServiceCollectionExtensions.AddMTServices(Microsoft.Extensions.DependencyInjection.IServiceCollection,BlazorMdc.MTToastServiceConfiguration,BlazorMdc.MTAnimatedNaviationManagerConfiguration)) service and will throw an exception on startup if the service is not found.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTToastAnchor&color=brightgreen)](xref:BlazorMdc.MTToastAnchor)