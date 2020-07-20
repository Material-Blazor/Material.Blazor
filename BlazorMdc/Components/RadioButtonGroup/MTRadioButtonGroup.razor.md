---
uid: C.MTRadioButtonGroup
title: MTRadioButtonGroup
---
# MTRadioButtonGroup&lt;TItem&gt;

### Summary

A group of [MTRadioButtons](xref:C.MTRadioButton).

### Details

- Groups a set of [MTRadioButtons](xref:C.MTRadioButton) together;
- Allows for horizontal or vertical alignment;
- The ItemValidation parameter has three possible values:
  - "Exception" is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data;
  - "DefaultToFirst" will select the first item in the list if the Value does not match; or
  - "NoSelection" will not pick a radiobutton when the Value is illegal;
- Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTRadioButtonGroup&color=brightgreen)](xref:BlazorMdc.MTRadioButtonGroup`1)