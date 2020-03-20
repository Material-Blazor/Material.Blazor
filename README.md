# BlazorMdc

## Lightweight Material Theme razor components for Blazor.

BlazorMdc is intended to be lightweight [Material Theme](https://material.io/) [web development platform](https://material.io/develop/web/) component library for [ASP.NET Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) that is rigorously faithful to the Material Theme's design philosophy, markup and code usage. Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as BlazorMdc. 

BlazorMdc isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from Telerik and Syncfusion; this is not an exhaustive list and there may be others. So why create BlazorMdc as yet another option? In building our Blazor applications using Material Theme we had some overriding objectives and to our taste this required a new library focussing on the following:

- Lightweight components that require the minimal possible setup and boilerplate Blazor coding and without intensive startup processing,
- Native Blazor code to the greatest possible extent, using JavaScript Interop only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application,
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable,
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS - BlazorMdc keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. So if you are less interested in that control but want to deliver something that looks good fast, this is where you should consider other libraries, and
- We aim for BlazorMdc to employ best practice for Blazor development. As a starting point this should be considered as being defined per [this video from NDC London, January 2020](https://www.youtube.com/watch?v=QnBYmTpugz0). We have plenty to do to arrive at that position.

Please note that BlazorMdc is in the early stages of development, so there are likely to be **frequent breaking changes** until we reach version 1. This project is owned by [Dioptra](https://dioptra.tech) and is licensed under the terms of the MIT license.

## Attribution

BlazorMdc is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting. At the present time we have revisited only a limited selection of components from RazorComponents.MaterialDesign - we are still under development.

## Demonstration website

_TBD_

## Components

The following is a list of components, but lacks documentation on how they are used. Since forking from [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign), some components await review - these are highlighed.

| Component | Notes |
| :-------- | :---- |
| `MdcAutocomplete` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) that drops a [menu](https://material.io/develop/web/components/menus/) for auto completion. Has parameters to allow blank results and for whitespace to be ignored in searches. Might consider forking and adapting [Blazored.Typeahead](https://github.com/Blazored/Typeahead) with MT styling. |
| `MdcButton` | A [Material Button](https://material.io/develop/web/components/buttons/). |
| `MdcCard` | A [Material Card](https://material.io/develop/web/components/cards/). _Requires ripple effect and completion of six examples mirroring those on material.io_ |
| `MdcCheckbox` | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| `MdcConfirmationDialog` | A special purpose wrapper around `MdcDialog` that makes the user type some text correctly in order to enable a button for a specific purpose. Modelled after the GitHub confirmation forms. |
| `MdcDatePicker` | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. Does not implement date ranges. Date pickers are only implemented in Material Theme for Android, so we interpreted as closely as possible the specification with our own CSS. This is the only instance where we have created CSS for a component, because our goal is to use standard Material Theme styling throughout. The result seems a bit too dense and is within a couple of pixels of unstyled overflow content on the month selection menu for long month names in English; this is likely to overflow for languages with longer month names. We are therefore likely to relax the component's density, which should improve usability. We have deviated from the specification by adding an "undo" button to return to the current selected date. There is no "today" button, which is not in the Material Theme specifcation. |
| `MdcDialog` | A [Material Dialog](https://material.io/develop/web/components/dialogs/). |
| `MdcDrawer` | A [Material Drawer](https://material.io/develop/web/components/drawers/). _Awaits review_. |
| `MdcIconButton` | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). Toggle icon buttons are not implemented. |
| `MdcLinearProgress` | A [Material Linear Progress bar](https://material.io/develop/web/components/linear-progress/). Only implements an indeterminate progress point |
| `MdcList` | A [Material List](https://material.io/develop/web/components/lists/). |
| `MdcMenu` | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| `MdcNavLink` | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. _Awaits review_. |
| `MdcNumericDoubleField` | Wraps `MdcTextField` to format numeric entry of a `double`. The format is applied when the component lacks focus, at which point the field is a text field holding the formatted number as text. When the field gains focus it switches to a number field. Allows for percentages to be entered as a whole number, e.g. typing "12" will yield a `double` equal to '0.12' and displaying '12%' when lacking focus. We intend to find a similar way to handle [basis points](https://en.wikipedia.org/wiki/Basis_point). |
| `MdcNumericIntField` | A wrapper for `MdcNumericDoubleField` for `int` variables. |
| `MdcRadioButtons` | A group of [Material Radio Buttons](https://material.io/develop/web/components/input-controls/radio-buttons/) with modification to list buttons vertically as well as the default inline. |
| `MdcSelect` | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| `MdcSwitch` | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| `MdcTabBar` | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). Displays tab contents as a `RenderFragment`, with mild 300ms fade animation with 12px left/right motion. |
| `MdcTextArea` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Implements the full width variety, but still needs to disable floating labels in this instance to follow MT guidelines - indeed full width fields with a floating label render poorly. |
| `MdcTextField` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| `MdcTopAppBar` | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). _Partially reviewed_. |

 ## Utilities
 
| Utility | Notes |
| :-------- | :---- |
| `MdcCascadingDefaults` | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| `MdcTypography` | Constants for standard Material Theme typography. |

## Known Issues

| Component | Issue |
| :-------- | :---- |
| `MdcAutocomplete` | Shows a flash of unstyled content ("FOUC") when a field that disallows blanks is cleared and then loses focus. The floating label stops floating and superimposes over the selected text. |
| `MdcNumericDoubleField` | When focus is lost for non-integer input, there's a FOUC where the field indicates that validation has failed with a red underline/outline for the filled/outlined styles respectively. |
| `MdcNumericDoubleField` | Empty field input correctly defaults to zero value but loses floating label. This is another FOUC. |
| `MdcTopAppBar` | Styling for the short variety of top app bar is wrong when a drawer is opened. |
| `MdcTextField` | Floating labels do not float when data is inserted automatically by the browser. Probably also affects `MdcTextArea` and will definitely affect `MdcNumericDoubleField` and `MdcNumericIntField` which are derived from `MdcTextField` |
| `MdcDatePicker`| As a stylistic issue, when the year pad is being shown, if the current year is more than 7 lines down (28+ years into the year list), it doesn't show because the year list is scrolled to the top. The list should initialize to a scrolled position showing the current year. |
| `MdcDialog` | When using check boxes or radio buttons in a dialog, sometimes the initial rendering of the ripple/selection area is smaller than it should be, and located to the upper left (so probably smaller than it should be but still anchored to the top left). |

## Future Development

- Add remaining Material Theme components.
- Add [density subsystem](https://material.io/develop/web/components/density/).
- Complete implementation of current components, in particular those points noted above as not being implemented.
- Target best practice (per notes in introduction) and perform quality audit.
- Build nullable numeric input in addition to current non nullables.
- Follow [Material Theme framework standards](https://material.io/develop/web/docs/framework-integration/).
