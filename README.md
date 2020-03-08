# BlazorMdc

## Lightweight Material Theme razor components for Blazor.

BlazorMdc is intended to be lightweight and rigorously faithful to the design philosophy behind [Material Theme's](https://material.io/) [web development platform](https://material.io/develop/web/). Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as BlazorMdc. 

BlazorMdc isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from Telerik and Syncfusion; this is not an exhaustive list and there may be others. So why create BlazorMdc as yet another option? In building our Blazor applications using Material Theme we had some overriding objectives and to our taste this required a new library focussing on the following:

- Lightweight components that require the minimal possible setup and boilerplate Blazor coding and without intensive startup processing,
- Native Blazor code to the greatest possible extent, using JavaScript Interop only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application,
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable,
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS - BlazorMdc keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. So if you are less interested in that control but want to deliver something that looks good fast, this is where you should consider other libraries.

Please note that BlazorMdc is in the early stages of development, so there are likely to be **frequent breaking changes** until we reach version 1. This project is owned by [Dioptra](https://dioptra.tech) and is licensed under the terms of the MIT license.

## Attribution

BlazorMdc is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting. At the present time we have revisited only a limited selection of components from RazorComponents.MaterialDesign - we are still under development.

## Demonstration website

_TBD_

## Components

The following is a list of components, but lacks documentation on how they are used. Since forking from [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign), some components await review - these are highlighed.

| Component | Notes |
| :-------- | :---- |
| `MdcButton` | A [Material Button](https://material.io/develop/web/components/buttons/). |
| `MdcCheckbox` | A [Material Checkbox](https://material.io/develop/web/components/input-controls/checkboxes/). Implements a two state on/off checkbox, but not yet an indeterminate variety. |
| `MdcDatePicker` | An implementation of the [Material date picker specification](https://material.io/components/pickers/#specs) for the desktop. Does not implement date ranges. Date pickers are only implemented in Material Theme for Android, so we interpreted as closely as possible the specification with our own CSS. This is the only instance where we have created CSS for a component, because our goal is to use standard Material Theme styling throughout. The result seems a bit too dense and is within a couple of pixels of unstyled overflow content on the month selection menu for long month names in English; this is likely to overflow for languages with longer month names. We are therefore likely to relax the component's density, which should improve usability. We have deviated from the specification by adding an "undo" button to return to the current selected date. There is no "today" button, which is not in the Material Theme specifcation. |
| `MdcDialog` | A [Material Dialog](https://material.io/develop/web/components/dialogs/). _Awaits review_. |
| `MdcDrawer` | A [Material Drawer](https://material.io/develop/web/components/drawers/). _Awaits review_. |
| `MdcIconButton` | A [Material Icon Button](https://material.io/develop/web/components/buttons/icon-buttons/). Toggle icon buttons are not implemented. |
| `MdcLinearProgress` | A [Material Linear Progress bar](https://material.io/develop/web/components/linear-progress/). Only implements an indeterminate progress point |
| `MdcList` | A [Material List](https://material.io/develop/web/components/lists/). _Awaits review_. |
| `MdcMenu` | A [Material Menu](https://material.io/develop/web/components/menus/). Does not implement sub menus. May redesign parameterization. |
| `MdcNavLink` | A [Material List Item](https://material.io/develop/web/components/menus/) wrapping a Blazor `NavLink`. _Awaits review_. |
| `MdcNumericDoubleField` | Wraps `MdcTextField` to format numeric entry of a `double`. The format is applied when the component lacks focus, at which point the field is a text field holding the formatted number as text. When the field gains focus it switches to a number field. Allows for percentages to be entered as a whole number, e.g. typing "12" will yield a `double` equal to '0.12' and displaying '12%' when lacking focus. We intend to find a similar way to handle [basis points](https://en.wikipedia.org/wiki/Basis_point). |
| `MdcNumericIntField` | A wrapper for `MdcNumericDoubleField` for `int` variables. |
| `MdcSelect` | A [Material Select Menu](https://material.io/develop/web/components/input-controls/select-menus/). |
| `MdcSwitch` | A [Material Switch](https://material.io/develop/web/components/input-controls/switches/). |
| `MdcTabBar` | A [Material Tab Bar](https://material.io/develop/web/components/tabs/tab-bar/). Does not implement displaying tab content; this is under review. |
| `MdcTextArea` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/) expressed as a text area. Does not implement the full width variety. |
| `MdcTextField` | A [Material Text Field](https://material.io/develop/web/components/input-controls/text-field/). Does not implement the full width variety. |
| `MdcTopAppBar` | A [Material Top App Bar](https://material.io/develop/web/components/top-app-bar/). _Partially reviewed_. |

 ## Utilities
 
| Utility | Notes |
| :-------- | :---- |
| `MdcCascadingDefaults` | Allows you to set up defaults such as button style (filled, outlined etc), text area style (filled or outlined) |
| `MdcTypography` | Constants for standard Material Theme typography. _Awaits Review_. |

## Known Issues

| Component | Issue |
| :-------- | :---- |
| `MdcNumericDoubleField` | When focus is lost for non-integer input, there's a flash of unstyled content ("FOUC") where the field indicates that validation has failed with a red underline/outline for the filled/outlined styles respectively. |
| `MdcTopAppBar` | Styling for the short variety of top app bar is wrong when a drawer is opened. |
