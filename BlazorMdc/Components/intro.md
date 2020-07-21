## Components, Services, and Utilities

NB - Need an introduction text here

NB - Remove from the table as each component/service/utility is documented

The following is a list of core Material Theme components.

| Component | Notes |
| :-------- | :---- |
| `MTCard` | A [Material Card](https://material.io/develop/web/components/cards/). _Requires ripple effect._ |
| `MTCheckbox` | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| `MTCircularProgress` | A [Material Circular Progress indicator](https://material.io/develop/web/components/progress-indicator/). |
| `MTDataTable` | A [Material Data Table](https://material.io/develop/web/components/data-tables/) without row selection |
| `MTDialog` | A [Material Dialog](https://material.io/develop/web/components/dialogs/). Can set scrim and escape button actions. |
| `MTDrawer` | A [Material Drawer](https://material.io/develop/web/components/drawers/). _Awaits review_. |
| `MTIconButton` | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| `MTIconButtonToggle` | A toggle variant of the [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). |
| `MTLinearProgress` | A [Material Linear Progress bar](https://material.io/develop/web/components/progress-indicator/). |
| `MTList` | A [Material List](https://material.io/develop/web/components/lists/). Implements Material Theme Web Components one and two line lists, plus a BlazorMdc interpretation of a three line list. |
| `MTMenu` | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| `MTNavLink` | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. _Awaits review_. |
| `MTRadioButton` | A [Material Radio Button](https://material.io/develop/web/components/input-controls/radio-buttons/). |
| `MTSelect` | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| `MTSwitch` | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| `MTTabBar` | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). |
| `MTTextArea` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Implements the full width variety, but still needs to disable floating labels in this instance to follow MT guidelines - indeed full width fields with a floating label render poorly. |
| `MTTextField` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| `MTTopAppBar` | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). _Partially reviewed_. |

## Plus Components

The following are extra or 'plus' components that extend the strict, core Material Theme `MTXxx` components with either additional functionality or in the case of `MTDatePicker` and `MTPaginator` implementing a specification that is yet to be implemented in the Material Theme CSS and JavaScript libraries.

| Component | Notes |
| :-------- | :---- |
| `MTConfirmationDialog` | A special purpose wrapper around `MTDialog` that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| `MTDatePicker` | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. Does not implement date ranges. Date pickers are only implemented in Material Theme for Android, so we interpreted as closely as possible the specification with our own CSS. This is the only instance where we have created CSS for a component, because our goal is to use standard Material Theme styling throughout. The result seems a bit too dense and is within a couple of pixels of unstyled overflow content on the month selection menu for long month names in English; this is likely to overflow for languages with longer month names. We are therefore likely to relax the component's density, which should improve usability. We have deviated from the specification by adding an "undo" button to return to the current selected date. There is no "today" button, which is not in the Material Theme specification. |
| `MTDebouncedTextField` | A debounced version of `MTTextField` |
| `MTDivider` | Implements a list divider by wrapping `hr` and gives the option of inset and padded. This uses the mdc-list-divider styles. | 
| `MTIcon` | Displays an icon from the specified icon foundry or the default foundry from `MTCascadingDefaults`. See `IconHelper`. |
| `MTNumericDoubleField` | Wraps `MTTextField` to format numeric entry of a `double`. The format is applied when the component lacks focus, at which point the field is a text field holding the formatted number as text. When the field gains focus it switches to a number field. Allows for percentages to be entered as a whole number, e.g. typing "12" will yield a `double` equal to '0.12' and displaying '12%' when lacking focus. We intend to find a similar way to handle [basis points](https://en.wikipedia.org/wiki/Basis_point). |
| `MTNumericIntField` | A wrapper for `MTpNumericDoubleField` for `int` variables. |
| `MTPagedDataList` | A templated component for paging generic data lists using `MTPaginator`. Uses the Wig Pig nested coding pattern and can either render list items one by one or wrap a component such as `MTList` or `MTDataTable`. |
| `MTPaginator` | An implementation of the [Material paginator specification](https://material.io/components/data-tables#behavior). |
| `MTRadioButtonGroup` | A group of `MTRadioButton`s. The ItemValidation parameter has three possible values. Exception is the default value and an exception will be raised if the Value supplied does not match one of the Values in the List parameter data. DefaultToFirst will select the first item in the list if the Value does not match. NoSelection will not pick a radiobutton when the Value is illegal. Several ArgumentExceptions can also be thrown for such things as a missing or empty List, a List that has multiple identical SelectedValues, and missing Value bindings. |
| `MTShield` | A simple component producing an HTML shield styled after svgs from shield.io (square, flat variety) |
| `MTSlidingContent` | A templated component to provide previous/next navigation through a series of pages with light left/right and fade in/out animation. |
| `MTSlidingTabBar` | An `MTTabBar` augmented with content displayed in a `MTSlidingContent` |
| `MTToastAnchor` | A port of [Blazored/Toast](https://github.com/Blazored/Toast), modified and styled à la Material Theme. Place once instance of this in your Blazor app at the top of `App.razor` or `MainLayout.razor`. Requires that you register an `IMTToastService` service and will throw an exception on startup if the service is not found. |

## Services
 
| Service | Notes |
| :------ | :---- |
| `IMTAnimatedNavigationManager` | Manages fade out/in page navigation, wrapping Blazor's `NavigationManager.NavigateTo()` function. This is purely optional and you can continue to use Blazor's navigtion if you don't want animation. |
| `IMTToastService` | Manages toast notification. Requires a `MTToastAnchor` component and will throw an exception when you attempt to show a toast notification if this isn't found. |

## Utilities
 
| Utility | Notes |
| :------ | :---- |
| `MTCascadingDefaults` | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| `MTTypography` | Constants for standard Material Theme typography. |
| `MTIconHelper` | Working with `IMTIcon` and `IMTIconFoundry` to implement `MTMIFoundry()` to specify [Material Icons](https://material.io/resources/icons/?style=baseline), and optionally `FAFoundry()` for [Font Awesome](https://fontawesome.com/icons?d=gallery) and `OIFoundry()` for [Open Iconic](https://useiconic.com/open) icons. Icon names are passed to components as a string, with an additional parameter of `IconFoundry` using utility functions from `MTIcon` to specify the foundry and its optional parameters. Your default icon foundry can be set in `MTCascadingDefaults` (which itself defaults to Material Icons) and then you can pass string names for the icon of your choice. For Font Awesome icons, omit the preceding "fas/r/l/d" because this is set as a Font Awesome foundry style and in `MTCascadingDefaults.FAIconStyle`. Font Awesome relative icon size and Material Icons theme are also similarly parameterized. BlazorMdc expects you to include Material Icons in your project (these are necessary for drop down arrows and so forth, but Font Awesome icons are discretionary depending upon your project's requirement - you do however need to use Font Awesome version 5 and Open Iconic version 1.1. |


