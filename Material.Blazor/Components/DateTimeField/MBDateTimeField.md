---
uid: C.MBDateTimeField
title: MBDateTimeField
---
# MBDateTimeField

## Summary

An [MBTextField](xref:C.MBTextField) designed for either a `date` or `datetime-local` value input.
Has the following properties

## Detail

- Includes [MBTextField](xref:C.MBTextField) properties; plus
- Minimum and maximum datetimess;
- Can supress the default date
- Applies [density subsystem](xref:A.Density) - note that filled text fields with density of -2 or less ignore labels by design within Material Theme.
- Renders Blazor validation messages in Material Theme's style. see the [Form Validation Article](xref:A.FormValidation).

## Caveats

Note the use of multiple parameters that presume invariance during the
life of this component.
- DateOnly
- MaxDate
- MinDate
- SuppressDefaultDate


&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBDateTimeField&color=brightgreen)](xref:Material.Blazor.MBDateTimeField)
