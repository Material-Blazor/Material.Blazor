---
uid: A.MenuOverflow
title: MenuOverflow
---
# Menu Overflow

Menus are used by the [MBMenu](xref:C.MBMenu), [MBSelect](xref:C.MBSelect) and [MBDatePicker](xref:C.MBDatePicker) components. Each of these use Material Components Web's menu surfaces, which are just pop-up divs. In many instances
these menu surfaces display well without any adjustment, however in certain circumstances they run into overflow issues. These arise from constrained container divs
that have their `overflow-y` style set to anything other than `visible` and where the menu is sufficiently close to the lower edge of that container that it gets truncated
or causes scrollbars to appear on the container.

Material Components Web provides two menu surface utility classes to handle menu positioning and size, and these are controlled by the [MBMenuSurfacePositioning](xref:Material.Blazor.MBMenuSurfacePositioning)
enum. We also provide a helper flag on [MBDialog](xref:C.MBDialog) to set dialog overflow CSS settings.

## MBMenuSurfacePositioning

This enum can be provided to each of the three components mentioned above with the following values:

- _**Regular**_ places the menu with `position: fixed;` immediately next to its anchor. The menu width is determined by Material Components Web. This setting will fail to gracefully overflow constrained containers;
- _**FullWidth**_ takes the same placement as the Regular setting, however the width of the menu is 100% of its anchor. This is mostly intended for MBSelect and may result in poor layout for MBMenu. FullWidth is ignored in favour of Regular for MBDatePicker, which sets its own width;
- _**Fixed**_ palces the menu next to its anchor with `position: absolute;` and will therefore not suffer overflow issues. It will however not allow for full width menus versus their anchor (which is desirable for MBSelect) and will not scroll with its container.

## Dialog Alternative

We have added an `OverflowVisible` boolean flag to [MBDialog](xref:C.MBDialog) and [MBConfirmationDialog](xref:C.MBConfirmationDialog) to set the dialog containers' CSS to `overflow: visible;`. This is
an alternative way to have menu surfaces overflow from dialogs while, for instance, allowing for the FullWidth menu surface variant with MBSelect.