---
uid: A.Utilities
title: Utilities
---
## Utilities

The following are utilities for cascading app defaults through nested components and managing icon foundries.

### Utilities List

| Utility | Notes |
| :------ | :---- |
| [MTCascadingDefaults](xref:U.MTCascadingDefaults) | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| [MTIconHelper](xref:U.MTIconHelper) | Working with `IMTMdcIcon` and `IMdcIconFoundry` to implement `MTMIFoundry()` to specify [Material Icons](https://material.io/resources/icons/?style=baseline), and optionally `FAFoundry()` for [Font Awesome](https://fontawesome.com/icons?d=gallery) and `OIFoundry()` for [Open Iconic](https://useiconic.com/open) icons. Icon names are passed to components as a string, with an additional parameter of `IconFoundry` using utility functions from `MTIcon` to specify the foundry and its optional parameters. Your default icon foundry can be set in `MTCascadingDefaults` (which itself defaults to Material Icons) and then you can pass string names for the icon of your choice. For Font Awesome icons, omit the preceding "fas/r/l/d" because this is set as a Font Awesome foundry style and in `MTCascadingDefaults.FAIconStyle`. Font Awesome relative icon size and Material Icons theme are also similarly parameterized. BlazorMdc expects you to include Material Icons in your project (these are necessary for drop down arrows and so forth, but Font Awesome icons are discretionary depending upon your project's requirement - you do however need to use Font Awesome version 5 and Open Iconic version 1.1. |