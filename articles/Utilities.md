---
uid: A.Utilities
title: Utilities
---
# Utilities

The following are utilities for cascading app defaults through nested components and managing icon foundries.

## Utilities List

| Utility | Notes |
| :------ | :---- |
| [MBCascadingDefaults](xref:U.MBCascadingDefaults) | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| [MBIconHelper](xref:U.MBIconHelper) | Working with `IMBMdcIcon` and `IMdcIconFoundry` to implement `MBMIFoundry()` to specify [Material Icons](https://material.io/resources/icons/?style=baseline), and optionally `FAFoundry()` for [Font Awesome](https://fontawesome.com/icons?d=gallery) and `OIFoundry()` for [Open Iconic](https://useiconic.com/open) icons. Icon names are passed to components as a string, with an additional parameter of `IconFoundry` using utility functions from `MBIcon` to specify the foundry and its optional parameters. Your default icon foundry can be set in `MBCascadingDefaults` (which itself defaults to Material Icons) and then you can pass string names for the icon of your choice. For Font Awesome icons, omit the preceding "fas/r/l/d" because this is set as a Font Awesome foundry style and in `MBCascadingDefaults.FAIconStyle`. Font Awesome relative icon size and Material Icons theme are also similarly parameterized. Material.Blazor expects you to include Material Icons in your project (these are necessary for drop down arrows and so forth, but Font Awesome icons are discretionary depending upon your project's requirement - you do however need to use Font Awesome version 5 and Open Iconic version 1.1. |