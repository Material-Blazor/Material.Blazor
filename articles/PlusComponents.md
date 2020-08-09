---
uid: A.PlusComponents
title: PlusComponents
---
# Plus Components

Material Theme closely specifies component HTML markup. Blazor MDC implements many of these as [Core Components](xref:A.CoreComponents). Blazor MDC also 
implements further Blazor/Material Theme hybrid components that we term "Plus Components".

### Component List

| Component | Notes |
| :-------- | :---- |
| [MTAnchor](xref:C.MTAnchor) | Anchor for a port of [Blazored/Toast](https://github.com/Blazored/Toast) and [Material Tooltips](https://github.com/material-components/material-components-web/tree/master/packages/mdc-tooltip#tooltip) modified and styled for Material Theme. Place once instance of this in your Blazor app at the top of `App.razor` or `MainLayout.razor`. Requires that you register an [IIMToastService](xref:S.IMTToastService) service and will throw an exception on startup if the service is not found. |
| [MTAnimatedNavigation](xref:C.MTAnimatedNavigation) | An component used by the [IMTAnimatedNavigationManager](xref:S.IMTAnimatedNavigationManager) service. |
| [MTAutocomplete](xref:C.MTAutocomplete) | An autocomplete comprising a text field and a menu. |
| [MTConfirmationDialog](xref:C.MTConfirmationDialog) | A special purpose wrapper around [MTDialog](xref:C.MTDialog) that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| [MTDatePicker](xref:C.MTDatePicker) | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. |
| [MTDebouncedTextField](xref:C.MTDebouncedTextField) | A debounced version of [MTTextField](xref:C.MTTextField) |
| [MTDivider](xref:C.MTDivider) | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. |
| [MTIcon](xref:C.MTIcon) | Displays an icon from the specified icon foundry or the default foundry from [MTCascadingDefaults](xref:U.MTCascadingDefaults). See also [MTIconHelper](xref:U.MTIconHelper). |
| [MTNumericDoubleField](xref:C.MTNumericDoubleField) | Wraps [MTTextField](xref:C.MTTextField) to format numeric entry of a double. |
| [MTNumericIntField](xref:C.MTNumericIntField) | A wrapper for `MTpNumericDoubleField` for `int` variables. |
| [MTPagedDataList](xref:C.MTPagedDataList) | A templated component for paging generic data lists using [MTPaginator](xref:C.MTPaginator) and applying transitions with [MTSlidingContent](xref:C.MTSlidingContent). |
| [MTPaginator](xref:C.MTPaginator) | An implementation of the [Material paginator specification](https://material.io/components/data-tables#behavior). |
| [MTRadioButtonGroup](xref:C.MTRadioButtonGroup) | A group of [MTRadioButtons](xref:C.MTRadioButton). |
| [MTShield](xref:C.MTShield) | A simple component producing an HTML shield styled after svgs from shield.io (square, flat variety) |
| [MTSlidingContent](xref:C.MTSlidingContent) | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| [MTSlidingTabBar](xref:C.MTSlidingTabBar) | An `MTTabBar` augmented with content displayed in a `MTSlidingContent` |
