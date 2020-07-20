---
uid: A.CoreComponents
title: CoreComponents
---
## Core Components

Material Theme closely specifies the HTML markup for its [core components](https://material.io/develop/web). Blazor MDC implements many of these and aheres rigorously to 
the markup specification. We term these "Core Components. Blazor MDC also has non core [Plus Components](xref:PlusComponents).

### Component List

| Component | Notes |
| :-------- | :---- |
| [MTButton](xref:C.MTButton) | A [Material Button](https://material.io/develop/web/components/buttons/). |
| [MTCard](xref:C.MTCard) | A [Material Card](https://material.io/develop/web/components/cards/). |
| [MTCheckbox](xref:C.MTCheckbox) | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| [MTCircularProgress](xref:C.MTCircularProgress) | A [Material Circular Progress indicator](https://material.io/develop/web/components/progress-indicator/). |
| [MTDataTable<TItem>](xref:C.MTDataTable) | A [Material Data Table](https://material.io/develop/web/components/data-tables/) without row selection. |
| [MTDialog](xref:C.MTDialog) | A [Material Dialog](https://material.io/develop/web/components/dialogs/). Can set scrim and escape button actions. |
| [MTDrawer](xref:C.MTDrawer) | A [Material Drawer](https://material.io/develop/web/components/drawers/). |
| [MTIconButton](xref:C.MTIconButton) | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| [MTIconButtonToggle](xref:C.MTIconButtonToggle) | A toggle variant of the [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| [MTLinearProgress](xref:C.MTLinearProgress) | A [Material Linear Progress bar](https://material.io/develop/web/components/progress-indicator/). |
| [MTList](xref:C.MTList) | A [Material List](https://material.io/develop/web/components/lists/). Implements Material Theme Web Components one and two line lists, plus a BlazorMdc interpretation of a three line list. |
| [MTMenu](xref:C.MTMenu) | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| [MTNavLink](xref:C.MTNavLink) | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. |
| [MTRadioButton](xref:C.MTRadioButton) | A [Material Radio Button](https://material.io/develop/web/components/input-controls/radio-buttons/). |
| [MTSelect](xref:C.MTSelect) | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| [MTSwitch](xref:C.MTSwitch) | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| [MTTabBar](xref:C.MTTabBar) | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). |
| [MTTextArea](xref:C.MTTextArea) | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Implements the full width variety, but still needs to disable floating labels in this instance to follow MT guidelines - indeed full width fields with a floating label render poorly. |
| [MTTextField](xref:C.MTTextField) | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| [MTTopAppBar](xref:C.MTTopAppBar) | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). |