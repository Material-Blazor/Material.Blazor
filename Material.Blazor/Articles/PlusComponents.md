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
| [MBAutocompletePagedField](xref:C.MBAutocompletePagedField) | An autocomplete comprising a text field and a paged menu, using asynchronous methods (supplied by the caller) to provide ongoing value queries, for instance from a database. |
| [MBAutocompleteSelectField](xref:C.MBAutocompleteSelectField) | An autocomplete comprising a text field and a menu, using asynchronous methods (supplied by the caller) to provide ongoing value queries, for instance from a database. |
| [MBAutocompleteTextField](xref:C.MBAutocompleteTextField) | An autocomplete comprising a text field and a menu. |
| [MBBadge](xref:C.MBBadge) | Badges that can be applied wither within HTML `div'`s or invoked via the parameters on `MBButton`, `MBIconButton` and 'MBIconButtonToggle''. |
| [MBBladeSet](xref:C.MBBladeSet) | Blades inspired by Microsoft Azure |
| [MBCarousel](xref:C.MBCarousel) | A carousel implementing animation using an `MBSlidingContent` |
| [MBConfirmationDialog](xref:C.MBConfirmationDialog) | A special purpose wrapper around [MBDialog](xref:C.MBDialog) that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| [MBDatePicker](xref:C.MBDatePicker) | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. |
| [MBDateTimeField](xref:C.MBDateTimeField) | An implementation in the spirit of the MBNumeric fields using an input type of either 'date' or 'datetime-local'. |
| [MBDebouncedTextField](xref:C.MBDebouncedTextField) | A debounced version of [MBTextField](xref:C.MBTextField) |
| [MBDivider](xref:C.MBDivider) | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. |
| [MBDragAndDropList](xref:C.MBDragAndDropList) | A list of user provided render fragments that can be re-ordered with drag and drop. |
| [MBFileUploadButton](xref:C.MBFileUploadButton) | A material button styled wrapper for the `InputFile` component. |
| [MBFileUploadDragAndDrop](xref:C.MBFileUploadDragAndDrop) | A material card styled wrapper for the `InputFile` component that can load files either by drag and drop or clicking the card area. |
| [MBIcon](xref:C.MBIcon) | Displays an icon from the specified icon foundry or the default foundry from [MBCascadingDefaults](xref:U.MBCascadingDefaults). See also [MBIconHelper](xref:U.MBIconHelper). |
| [MBMenuSelectionGroup](xref:C.MBMenuSelectionGroup) | Allows grouping of menu items to enable multiple 'selected' checks |
| [MBNumericDecimalField](xref:C.MBNumericDecimalField) | Wraps [MBTextField](xref:C.MBTextField) to format numeric entry of a `decimal`. |
| [MBNumericDoubleField](xref:C.MBNumericDoubleField) | A wrapper for `MBNumericDecimalField` for `double` variables. |
| [MBNumericIntField](xref:C.MBNumericIntField) | A wrapper for `MBNumericDecimalField` for `int` variables. |
| [MBPagedDataList](xref:C.MBPagedDataList) | A templated component for paging generic data lists using [MBPaginator](xref:C.MBPaginator) and applying transitions with [MBSlidingContent](xref:C.MBSlidingContent). |
| [MBRadioButtonGroup](xref:C.MBRadioButtonGroup) | A group of [MBRadioButtons](xref:C.MBRadioButton). |
| [MBShield](xref:C.MBShield) | A simple component producing an HTML shield styled after svgs from shield.io (square, flat variety) |
| [MBSlidingContent](xref:C.MBSlidingContent) | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| [MBSlidingTabBar](xref:C.MBSlidingTabBar) | An `MBTabBar` augmented with content displayed in a `MBSlidingContent` |
| MBToast   | An `MBToast` component used to show toast notifications` |
