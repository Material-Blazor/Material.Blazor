---
uid: A.PlusComponents
title: PlusComponents
---
# Plus Components

Material Theme closely specifies component HTML markup. Material.Blazor implements many of these as [Core Components](xref:A.CoreComponents). Material.Blazor also 
implements further Blazor/Material Theme hybrid components that we term "Plus Components".

## Component List

| Component | Notes |
| :-------- | :---- |
| [MBAnchor](xref:C.MBAnchor) | Anchor for a port of [Blazored/Toast](https://github.com/Blazored/Toast) and [Material Tooltips](https://github.com/material-components/material-components-web/tree/master/packages/mdc-tooltip#tooltip) modified and styled for Material Theme. Place once instance of this in your Blazor app at the top of `App.razor` or `MainLayout.razor`. Requires that you register an [IIMBoastService](xref:S.IMBToastService) service and will throw an exception on startup if the service is not found. |
| [MBAutocompleteTextField](xref:C.MBAutocompleteTextField) | An autocomplete comprising a text field and a menu. |
| [MBBatchingWrapper](xref:C.MBBatchingWrapper) | A container in which JS can be batched
| [MBBladeSet](xref:C.MBBladeSet) | Blades inspired by Microsoft Azure |
| [MBConfirmationDialog](xref:C.MBConfirmationDialog) | A special purpose wrapper around [MBDialog](xref:C.MBDialog) that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| [MBDatePicker](xref:C.MBDatePicker) | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. |
| [MBDebouncedTextField](xref:C.MBDebouncedTextField) | A debounced version of [MBTextField](xref:C.MBTextField) |
| [MBDivider](xref:C.MBDivider) | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. |
| [MBIcon](xref:C.MBIcon) | Displays an icon from the specified icon foundry or the default foundry from [MBCascadingDefaults](xref:U.MBCascadingDefaults). See also [MBIconHelper](xref:U.MBIconHelper). |
| [MBNumericDecimalField](xref:C.MBNumericDecimalField) | Wraps [MBTextField](xref:C.MBTextField) to format numeric entry of a `decimal`. |
| [MBNumericDoubleField](xref:C.MBNumericDoubleField) | A wrapper for `MBNumericDecimalField` for `double` variables. |
| [MBNumericIntField](xref:C.MBNumericIntField) | A wrapper for `MBNumericDecimalField` for `int` variables. |
| [MBPagedDataList](xref:C.MBPagedDataList) | A templated component for paging generic data lists using [MBPaginator](xref:C.MBPaginator) and applying transitions with [MBSlidingContent](xref:C.MBSlidingContent). |
| [MBRadioButtonGroup](xref:C.MBRadioButtonGroup) | A group of [MBRadioButtons](xref:C.MBRadioButton). |
| [MBShield](xref:C.MBShield) | A simple component producing an HTML shield styled after svgs from shield.io (square, flat variety) |
| [MBSlidingContent](xref:C.MBSlidingContent) | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| [MBSlidingTabBar](xref:C.MBSlidingTabBar) | An `MBTabBar` augmented with content displayed in a `MBSlidingContent` |

## Deprecated Component List

| Component | Notes |
| :-------- | :---- |
| [MBToast](xref:C.MBToast) | An `MBToast` component used to show toast notifications` |

## Experimental Component List

| Component | Notes |
| :-------- | :---- |
| [MBGrid](xref:C.MBGrid) | Displays a grid composed from the elements specified as parameters. |
| [MBGridMT](xref:C.MBGrid) | Displays a grid themed as MWC composed from the elements specified as parameters. |
