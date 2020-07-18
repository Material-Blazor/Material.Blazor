---
uid: C.MTDatePicker
title: MTDatePicker
---
## MTDatePicker

A Blazor MDC implementation of the [Material Theme date picker specification](https://material.io/components/pickers).
An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. Does not implement date ranges.
Date pickers are only implemented in Material Theme for Android, so Blazor MDC interprets the spec as closely as possible with custom CSS. The result seems a little too dense and
is within a couple of pixels of unstyled overflow content on the month selection menu for long month names in English; this is likely to overflow for languages
with longer month names. We are therefore likely to relax the component's density, which should improve usability. We have deviated from the specification by
adding an "undo" button to return to the current selected date. There is no "today" button, which is not in the Material Theme specification.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTDatePicker&color=brightgreen)](xref:BlazorMdc.MTDatePicker)