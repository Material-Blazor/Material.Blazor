---
uid: C.MTSelect
title: MTSelect
---
# MTSelect&lt;TItem&gt;

### Summary

A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/).

### Details

- Accepts an `IEnumerable<Titem>` of selectable items;
- Can be styled as either a filled or outlined Material Theme select;
- The ItemValidation parameter has three possible values:
  - "Exception" is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data;
  - "DefaultToFirst" will select the first item in the list if the Value does not match; or
  - "NoSelection" will not pick a radiobutton when the Value is illegal;
- Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings.
- Applies [density subsystem](xref:A.Density) - note that filled selects with denisty of -2 or less ignore labels by design within Material Theme.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTSelect&color=brightgreen)](xref:BlazorMdc.MTSelect`1)