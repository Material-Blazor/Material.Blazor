---
uid: C.MBDebouncedTextField
title: MBDebouncedTextField
---
# MBDebouncedTextField

## Summary

A debounced variant of the [MBTextField](xref:C.MBTextField). Allows the debounce interval in milliseconds to be set, defaulting to 300ms.

- Applies [density subsystem](xref:A.Density) - note that filled text fields with denisty of -2 or less ignore labels by design within Material Theme.
- Cannot be used within a form as a form field. Does not throw an exception but logs a warning to indicate that debounced text fields disable the `EditContext`.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBDebouncedTextField&color=brightgreen)](xref:Material.Blazor.MBDebouncedTextField)
