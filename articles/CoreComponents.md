---
uid: A.CoreComponents
title: CoreComponents
---
# Core Components

Material Theme closely specifies the HTML markup for its [core components](https://material.io/develop/web). Material.Blazor implements many of these and aheres rigorously to 
the markup specification. We term these "Core Components. Material.Blazor also has non core [Plus Components](xref:A.PlusComponents).

## Component List

| Component | Notes |
| :-------- | :---- |
| [MBButton](xref:C.MBButton) | A [Material Button](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-button#buttons). |
| [MBCard](xref:C.MBCard) | A [Material Card](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-card#cards). |
| [MBCheckbox](xref:C.MBCheckbox) | A [Material Checkbox](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-checkbox#selection-controls-checkboxes). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| [MBCircularProgress](xref:C.MBCircularProgress) | A [Material Circular Progress indicator](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-circular-progress#circular-progress). |
| [MBDataTable<TItem>](xref:C.MBDataTable) | A [Material Data Table](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-data-table#data-tables) without row selection. |
| [MBDialog](xref:C.MBDialog) | A [Material Dialog](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-dialog#dialogs). Can set scrim and escape button actions. |
| [MBDrawer](xref:C.MBDrawer) | A [Material Drawer](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-drawer#navigation-drawers). |
| [MBFloatingActionButton](xref:C.MBFloatingActionButton) | A [Material FAB](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-fab#floating-action-buttons). |
| [MBIconButton](xref:C.MBIconButton) | A [Material Icon Button](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-icon-button#icon-buttons). |
| [MBIconButtonToggle](xref:C.MBIconButtonToggle) | A toggle variant of the [Material Icon Button](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-icon-button#icon-buttons). |
| [MBLinearProgress](xref:C.MBLinearProgress) | A [Material Linear Progress bar](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-linear-progress#linear-progress). |
| [MBList](xref:C.MBList) | A [Material List](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-list#lists). Implements Material Theme Web Components one and two line lists, plus a Material.Blazor interpretation of a three line list. |
| [MBMenu](xref:C.MBMenu) | A [Material Menu](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-menu#menus). Does not implement sub menus. May redesign parameterization. |
| [MBRadioButton](xref:C.MBRadioButton) | A [Material Radio Button](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-radio#selection-controls-radio-buttons). |
| [MBPaginator](xref:C.MBPaginator) | An implementation of the [Material paginator specification](https://material.io/components/data-tables#behavior). |
| [MBSegmentedButtonMulti](xref:C.MBSegmentedButtonMulti) | A [Material Multi-Select Segmented Button](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-segmented-button#segmented-buttons). Implements a multi-select segmented button. |
| [MBSegmentedButtonSingle](xref:C.MBSegmentedButtonSingle) | A [Material Multi-Select Segmented Button](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-segmented-button#segmented-buttons). Implements a single-select segmented button. |
| [MBSelect](xref:C.MBSelect) | A [Material Select Menu](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-select#select-menus). |
| [MBSlider](xref:C.MBSlider) | A [Material Slider](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-slider#slider). A single-thumb continuous and discrete slider. |
| [MBSwitch](xref:C.MBSwitch) | A [Material Switch](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-switch#selection-controls-switches). |
| [MBTabBar](xref:C.MBTabBar) | A [Material Tab Bar](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-tab-bar#tab-bar). |
| [MBTextArea](xref:C.MBTextArea) | A [Material Text Field](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-textfield#text-field) expressed as a text area. |
| [MBTextField](xref:C.MBTextField) | A [Material Text Field](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-textfield#text-field). |
| [MBToast](xref:C.MBMBToast) | A [Material Toast](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-toast#toast). |
| [MBTooltip](xref:C.MBTooltip) | A [Material Tooltip](https://github.com/material-components/material-components-web/tree/master/packages/mdc-tooltip#tooltip). |
| [MBTopAppBar](xref:C.MBTopAppBar) | A [Material Top App Bar](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-top-app-bar#top-app-bar). |

## Experimental Component List

| Component | Notes |
| :-------- | :---- |
| [MBChipsSelectMulti](xref:C.MBChipsSelectMulti) | A [Material Filter Chipset](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-chips#chips). Implements a multi-select chipset ("filter chips"). |
| [MBChipsSelectSingle](xref:C.MBChipsSelectSingle) | A [Material Choice Chipset](https://github.com/material-components/material-components-web/tree/v12.0.0/packages/mdc-chips#chips). Implements a single-select chipset ("choice chips"). |
