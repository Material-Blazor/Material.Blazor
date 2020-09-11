---
uid: C.MTRadioButtonGroup
title: MTRadioButtonGroup
---
# MTRadioButtonGroup&lt;TItem&gt;

## Summary

A group of [MTRadioButtons](xref:C.MTRadioButton).

## Details

- Groups a set of [MTRadioButtons](xref:C.MTRadioButton) together;
- Allows for horizontal or vertical alignment;
- The ItemValidation parameter has three possible values:
  - "Exception" is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data;
  - "DefaultToFirst" will select the first item in the list if the Value does not match; or
  - "NoSelection" will not pick a radiobutton when the Value is illegal;
- Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings.

## Assisting Blazor Rendering with `@key`

- MTRadioButtonGroup renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MTRadioButtonGroup by default uses the `SelectedValue` property of each item in the `Items` parameter as the key, however you can override this. Blazor MDC does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MTList demonstration website page's code](https://github.com/BlazorMdc/BlazorMdc/blob/main/BlazorMdcWebsite.Components/Pages/List.razor#L155).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Plus&color=red)](xref:A.PlusComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTRadioButtonGroup&color=brightgreen)](xref:BlazorMdc.MTRadioButtonGroup`1)