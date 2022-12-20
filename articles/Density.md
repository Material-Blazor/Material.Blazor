---
uid: A.Density
title: Density
---
# Density

## Summary

Material Theme specifies a [density subsystem](https://material.io/develop/web/components/density), applied using SASS mixins. Material.Blazor handles density through component parameters and
cascading defaults. This parameterization is applied to Material Theme components via CSS classes prepared by Material.Blazor from the SASS mixins. Density is specified by the
[MBDensity enumeration](xref:Material.Blazor.MBDensity), and can be controlled both with Cascading Defaults and direct component parameters.

## Density Levels

Density is specified by having components rendered increasingly dense as a density number reduces from zero to minus 5. Some components render all density levels, others only a subset, stopping
at either minus three or minus four. In these cases if you specify a something more dense, the densest available rendering will be supplied. For instance `MBButton` with density of minus 5 will render with
density of minus 3.

| Density Level | Enumeration |
| :-----------: | :---------- |
| 0 | `MBDensity.Default` |
| -1 | `MBDensity.Minus1` |
| -2 | `MBDensity.Minus2` and `MBDensity.Comfortable` |
| -3 | `MBDensity.Minus3` and `MBDensity.Compact` |
| -4 | `MBDensity.Minus4` |
| -5 | `MBDensity.Minus5` |

## Components Applying Density Subsystem

Applicable density levels are shown with a :heavy_check_mark:. Those with a :x: will display the most dense option available. For instance an [MBButton](xref:C.MBButton) with
a specified density of minus 5 will actually display with a density of minus 3.

| Component |   0 |  -1 |  -2 |  -3 |  -4 |  -5 |
| :-------- | :-: | :-: | :-: | :-: | :-: | :-: |
| [MBAutocompleteTextField, SelectField](xref:C.MBAutocompleteTextField, TextField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBAutocompleteTextField, TextField](xref:C.MBAutocompleteTextField, TextField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBButton](xref:C.MBButton) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MBCheckbox](xref:C.MBCheckbox) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MBDataTable<TItem>](xref:C.MBDataTable) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBDebouncedTextField](xref:C.MBDebouncedTextField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBIconButton](xref:C.MBIconButton) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| [MBIconButtonToggle](xref:C.MBIconButtonToggle) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| [MBList](xref:C.MBList) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBNumericDecimalField](xref:C.MBNumericDecimalField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBNumericDoubleField](xref:C.MBNumericDoubleField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBNumericIntField](xref:C.MBNumericIntField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBRadioButton](xref:C.MBRadioButton) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MBRadioButtonGroup](xref:C.MBRadioButtonGroup) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MBSelect](xref:C.MBSelect) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark:[<sup>1</sup>](#fn1) | :heavy_check_mark:[<sup>1</sup>](#fn1) | :heavy_check_mark:[<sup>1</sup>](#fn1) | :x: |
| [MBSwitch](xref:C.MBSwitch)[<sup>2</sup>](#fn2) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| [MBTabBar](xref:C.MBTabBar) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MBTextArea](xref:C.MBTextArea) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark:[<sup>1</sup>](#fn1) | :heavy_check_mark:[<sup>1</sup>](#fn1) | :heavy_check_mark:[<sup>1</sup>](#fn1) | :x: |
| [MBTextField](xref:C.MBTextField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark:[<sup>1</sup>](#fn1) | :heavy_check_mark:[<sup>1</sup>](#fn1) | :heavy_check_mark:[<sup>1</sup>](#fn1) | :x: |

<br />

**1<a name="fn1"></a>**: Filled text fields, text areas and selects with density of -2 or below hide lables with `display: none;` due to a lack of space. Labels remain in the DOM for aria reference.
**2<a name="fn2"></a>**: As of Material Components Web v12.0.0 and therefore Material.Blazor 2.0.0 switch density seems to be deprecated.