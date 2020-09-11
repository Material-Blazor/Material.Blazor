---
uid: A.Icon
title: Icon
---
# Icon

## Summary

Blazor MDC allows you to freely choose among the Material Icons, Font Awesome version 5 and Open Iconic version 1.1 icon foundries. These three foundries
each use different HTML markup, and this difference is handled by the general purpose [MTIcon (see API documentation)](xref:BlazorMdc.MTIcon) component.

Material Icons are essential for Material Theme and so our css includes this font for you. You will need to include links
for Font Awesome and Open Iconic separately if you want to use them - see the [Installation Article](xref:A.Installation#package-versions) for links.

## Using MTIcon

MTIcon's two principal parameters are IconName (required) and IconFoundry (optional). Examples of icon name are "alarm" for Material
Icons, "fa-bell" for Font Awesome and "audio" for Open Iconic. If you don't provide IconFoundry your default foundry will be used. The default 
is either Material Icons or a [default that you set with cascading defaults](xref:A.CascadingDefaults#icons).

A third parameter is a boolean value TabBar. Set this to true if you are placing an icon in a tab bar so that further styling can be added.

## Setting the Icon Foundry

Blazor MDC provides three static convenience methods to supply an icon foundry to MTIcon: `IconFoundry="IconHelper.MIIcon()"`, `IconFoundry="IconHelper.FAIcon()"`, `IconFoundry="IconHelper.OIIcon()"`.
There are varying parameters for these helper methods described in the [Icon Helper documentation](xref:BlazorMdc.MTIconHelper).

## Other Components

Many components such as MTButton, MTSelect and MTTextField take icons. In every instance these components take IconName
and an optional IconFoundry parameters which are applied in the same way as for MTIcon. In fact they all use MTIcon.