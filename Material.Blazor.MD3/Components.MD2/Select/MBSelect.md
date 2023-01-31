---
uid: C.MBSelect
title: MBSelect
---
# MBSelect&lt;TItem&gt;

## Summary

A [Material Select Menu](https://github.com/material-components/material-components-web/tree/v9.0.0/packages/mdc-select#select-menus).

## Details

- Accepts an `IEnumerable<MBSelectElement<TItem>>` of selectable items;
- Can be styled as either a filled or outlined Material Theme select;
- The ItemValidation parameter has three possible values:
  - "Exception" is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data;
  - "DefaultToFirst" will select the first item in the list if the Value does not match; or
  - "NoSelection" will not pick a radiobutton when the Value is illegal;
- Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings.
- Applies [density subsystem](xref:A.Density) - note that filled selects with denisty of -2 or less ignore labels by design within Material Theme.

## Assisting Blazor Rendering with `@key`

- MBSelect renders similar table rows with a `foreach` loop;
- In general each item rendered in a loop in Blazor should be supplied with a unique object via the `@key` attribute - see [Blazor University](https://blazor-university.com/components/render-trees/optimising-using-key/);
- MBSelect by default uses the `SelectedValue` property of each item in the `Items` parameter as the key, however you can override this. Material.Blazor does this because we have had instances where Blazor crashes with the default key giving an exception message such as "The given key 'MyObject' was not present";
- You can provide a function delegate to the `GetKeysFunc` parameter - we have used two variants of this:
  - First to get a unique `Id` property that happens to be in our item's class: `GetKeysFunc="@((item) => item.Id)"`; and
  - Second using a "fake key" where we create a GUID to act as the key: `GetKeysFunc="@((item) => Guid.NewGuid())"`.
  - You can see an example of this in the [MBList demonstration website page's code](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website/Pages/List.razor#L155).

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBSelect&color=brightgreen)](xref:Material.Blazor.MBSelect`1)
