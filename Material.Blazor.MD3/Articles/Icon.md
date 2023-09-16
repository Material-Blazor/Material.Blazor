---
uid: A.Icon
title: Icon
---
# Icon

## Caveats

This is the page from MD2 and is subject to change

## Summary

Material.Blazor allows you to freely choose among the Material Icons, Font Awesome version 5 and Open Iconic version 1.1 icon foundries. These three foundries
each use different HTML markup, and this difference is handled by the general purpose [MBIcon (see API documentation)](xref:Material.Blazor.MBIcon) component.

Material Icons are essential for Material Theme and so our css includes this font for you. You will need to include links
for Font Awesome and Open Iconic separately if you want to use them - see the [Installation Article](xref:A.Installation#package-versions) for links.

## Using MBIcon

MBIcon's two parameters are IconName (required) and IconFoundry (optional). Examples of icon name are "alarm" for Material
Icons, "fa-bell" for Font Awesome and "audio" for Open Iconic. If you don't provide IconFoundry your default foundry will be used. The default 
is either Material Icons or a [default that you set with cascading defaults](xref:A.CascadingDefaults#icons).

## Setting the Icon Foundry

Material.Blazor provides three static convenience methods to supply an icon foundry to MBIcon: `IconFoundry="IconHelper.MIIcon()"`, `IconFoundry="IconHelper.FAIcon()"`, `IconFoundry="IconHelper.OIIcon()"`.
There are varying parameters for these helper methods described in the [Icon Helper documentation](xref:Material.Blazor.MBIconHelper).

## Other Components

Many components such as MBButton, MBSelect and MBTextField take icons. In every instance these components take IconName
and an optional IconFoundry parameters which are applied in the same way as for MBIcon. In fact they all use MBIcon.