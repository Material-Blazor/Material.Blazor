---
uid: A.PlusComponents
title: PlusComponents
---
## Plus Components

Material Theme closely specifies component HTML markup. Blazor MDC implements many of these as [Core Components](xref:A.CoreComponents). Blazor MDC also 
implements further Blazor/Material Theme hybrid components that we term "Plus Components".

### Component List

| Component | Notes |
| :-------- | :---- |
| [MTAnimatedNavigation](xref:C.MTAnimatedNavigation) | An component used by the [IMTAnimatedNavigationManager](xref:S.IMTAnimatedNavigationManager) service. |
| [MTAutocomplete](xref:C.MTAutocomplete) | An autocomplete comprising a text field and a menu. |
| [MTConfirmationDialog](xref:C.MTConfirmationDialog) | A special purpose wrapper around `MTDialog` that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| [MTDatePicker](xref:C.MTDatePicker) | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. |
| [MTDebouncedTextField](xref:C.MTDebouncedTextField) | A debounced version of [MTTextField](xref:C.MTTextField) |
| [MTDivider](xref:C.MTDivider) | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. |
| [MTIcon](xref:C.MTIcon) | Displays an icon from the specified icon foundry or the default foundry from [MTCascadingDefaults](xref:U.MTCascadingDefaults). See also [MTIconHelper](xref:U.MTIconHelper). |
| [MTNumericDoubleField](xref:C.MTNumericDoubleField) | Wraps `MTTextField` to format numeric entry of a `double`. The format is applied when the component lacks focus, at which point the field is a text field holding the formatted number as text. When the field gains focus it switches to a number field. Allows for percentages to be entered as a whole number, e.g. typing "12" will yield a `double` equal to '0.12' and displaying '12%' when lacking focus. We intend to find a similar way to handle [basis points](https://en.wikipedia.org/wiki/Basis_point). |
| [MTNumericIntField](xref:C.MTNumericIntField) | A wrapper for `MTpNumericDoubleField` for `int` variables. |
| [MTPagedDataList](xref:C.MTPagedDataList) | A templated component for paging generic data lists using `MTPaginator`. Uses the Wig Pig nested coding pattern and can either render list items one by one or wrap a component such as `MTList` or `MTDataTable`. |
| [MTPaginator](xref:C.MTPaginator) | An implementation of the [Material paginator specification](https://material.io/components/data-tables#behavior). |
| [MTRadioButtonGroup](xref:C.MTRadioButtonGroup) | A group of MdcRadioButtons. The ItemValidation parameter has three possible values. Exception is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data. DefaultToFirst will select the first item in the list if the Value does not match. NoSelection will not pick a radiobutton when the Value is illegal. Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings. |
| [MTShield](xref:C.MTShield) | A simple component producing an HTML shield styled after svgs from shield.io (square, flat variety) |
| [MTSlidingContent](xref:C.MTSlidingContent) | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| [MTSlidingTabBar](xref:C.MTSlidingTabBar) | An `MTTabBar` augmented with content displayed in a `MTSlidingContent` |
| [MTToastAnchor](xref:C.MTToastAnchor) | A port of [Blazored/Toast](https://github.com/Blazored/Toast), modified and styled for Material Theme. Place once instance of this in your Blazor app at the top of `App.razor` or `MainLayout.razor`. Requires that you register an [IIMToastService](xref:S.IMTToastService) service and will throw an exception on startup if the service is not found. |
