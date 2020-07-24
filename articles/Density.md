---
uid: A.Density
title: Density
---
# Density

### Summary

Material Theme specifies a [density subsystem](https://material.io/develop/web/components/density), applied using SASS mixins. Blazor MDC handles density through component parameters and
cascading defaults. This parameterization is applied to Material Theme components via CSS classes prepared by Blazor MDC from the SASS mixins. Density is specified by the
[MTDensity enumeration](xref:BlazorMdc.MTDensity), and can be controlled both with Cascading Defaults and direct component parameters.

### Density Levels

Density is specified by having components rendered increasingly dense as a density number reduces from zero to minus 5. Some components render all density levels, others only a subset, stopping
at either minus three or minus four. In these cases if you specify a something more dense, the densest available rendering will be supplied. For instance `MTButton` with density of minus 5 will render with
density of minus 3.

| Density Level | Enumeration |
| :-----------: | :---------- |
| 0 | `MTDensity.Default` |
| -1 | `MTDensity.Minus1` |
| -2 | `MTDensity.Minus2` and `MTDensity.Comfortable` |
| -3 | `MTDensity.Minus3` and `MTDensity.Compact` |
| -4 | `MTDensity.Minus4` |
| -5 | `MTDensity.Minus5` |

### Components Applying Density Subsystem

| Component |   0 |  -1 |  -2 |  -3 |  -4 |  -5 |
| :-------- | :-: | :-: | :-: | :-: | :-: | :-: |
| [MTAutocomplete](xref:C.MTAutocomplete) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MTButton](xref:C.MTButton) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MTCheckbox](xref:C.MTCheckbox) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MTDataTable<TItem>](xref:C.MTDataTable) | TBD | TBD | TBD | TBD | TBD | TBD |
| [MTDebouncedTextField](xref:C.MTDebouncedTextField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MTIconButton](xref:C.MTIconButton) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| [MTIconButtonToggle](xref:C.MTIconButtonToggle) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| [MTList](xref:C.MTList) | TBD | TBD | TBD | TBD | TBD | TBD |
| [MTNumericDoubleField](xref:C.MTNumericDoubleField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MTNumericIntField](xref:C.MTNumericIntField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MTRadioButton](xref:C.MTRadioButton) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MTRadioButtonGroup](xref:C.MTRadioButtonGroup) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: |
| [MTSelect](xref:C.MTSelect) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MTSwitch](xref:C.MTSwitch) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: |
| [MTTabBar](xref:C.MTTabBar) | TBD | TBD | TBD | TBD | TBD | TBD |
| [MTTextArea](xref:C.MTTextArea) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |
| [MTTextField](xref:C.MTTextField) | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :x: |