---
uid: C.MBNumericDoubleField
title: MBNumericDoubleField
---
# MBNumericDoubleField

## Summary

An [MBTextField](xref:C.MBTextField) designed for numeric value input with a formatted display while the field lacks focus (format is turned off with focus for efficient data entry).
Has the capacity to scale order of magnitude for percentage or [basis points](https://en.wikipedia.org/wiki/Basis_point) (1/100th of a percent) data input and display. Has the following properties

## Detail

- Includes [MBTextField](xref:C.MBTextField) properties; plus
- Minimum and maximum amounts;
- Numeric format for when the field lacks focus;
- A maximum number of decimal places - if the user types additional dp, standard rounding is applied;
- Focused and Unfocused magnitude to facilite percentage and basis point input, e.g. 12.5% is entered as text "12.5" rather than "0.125" and displayed either as "12.5" or with percentage formatting as "12.5%" (not available with basis points);
- Applies [density subsystem](xref:A.Density) - note that filled text fields with denisty of -2 or less ignore labels by design within Material Theme.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBNumericDoubleField&color=brightgreen)](xref:BlazorMdc.MBNumericDoubleField)