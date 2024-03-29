﻿---
uid: C.MBNumericIntField
title: MBNumericIntField
---
# MBNumericIntField

## Summary

An `int` variant of [MBNumericDecimalField](xref:C.MBNumericDecimalField).

- Applies [density subsystem](xref:A.Density) - note that filled text fields with denisty of -2 or less ignore labels by design within Material Theme.
- Renders Blazor validation messages in Material Theme's style. see the [Form Validation Article](xref:A.FormValidation).

## Caveats

Note the use of multiple parameters that presume invariance during the
life of this component (since this component uses NumericDecimalField).
- DecimalPlaces
- FocusedMagnitude
- Min
- UnfocusedMagnitude

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBNumericIntField&color=brightgreen)](xref:Material.Blazor.MBNumericIntField)
