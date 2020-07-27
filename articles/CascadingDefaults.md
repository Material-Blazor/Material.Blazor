---
uid: A.CascadingDefaults
title: CascadingDefaults
---
# Cascading Defaults

Blazor MDC uses a system of cascading defaults using [MTCascadingDefaults](xref:U.MTCascadingDefaults) to control defaults for things such as button style and density, text field
style and so on. The `MTCascadingDefaults` class is supplied to components held within a `<CascadingValue>` tag. Cascading defaults can be nested (the most recent)
takes precedence as for any cascading value, and if no cascading defaults are supplied, a default scheme is applied by Blazor MDC. Cascading defaults apply when
an optional parameter is not supplied to a component.

This section describes the usage of properties in [MTCascadingDefaults](xref:U.MTCascadingDefaults).

### Icons

The following properties are used for displaying icons. Blazor MDC components all render icons using the [MTIcon](xref:C.MTIcon) component which renders any of Material Icons, Font
Awesome of Open Iconic icons and their respective variants. Any component that uses icons accepts an optional `IconFoundry` parameter, which 

| Property | Used In |
| :------- | :------ |
| [IconFoundryName](xref:BlazorMdc.MTCascadingDefaults.IconFoundryName) | The default icon foundry. |
| [IconMITheme](xref:BlazorMdc.MTCascadingDefaults.IconMITheme) | The default Material Icons theme. |
| [IconFAStyle](xref:BlazorMdc.MTCascadingDefaults.IconFAStyle) | The default Font Awesome style. |
| [IconFARelativeSize](xref:BlazorMdc.MTCascadingDefaults.IconFARelativeSize) | The default Font Awesome relative size. |

### Density Subsystem

Material Theme has a [density subsystem](xref:A.Density) which applies to some components. When a component Density parameter is not set the folliwng cascading defaults apply:

| Property | Used In |
| :------- | :------ |
| [ThemeDensity](xref:BlazorMdc.MTCascadingDefaults.ThemeDensity) | A default for all components unless over-ridden by first one of the cascading default parameters below or second a component's own `Density` parameter. |
| [ButtonDensity](xref:BlazorMdc.MTCascadingDefaults.ButtonDensity) | [MTButton](xref:C.MTButton). |
| [CheckboxDensity](xref:BlazorMdc.MTCascadingDefaults.CheckboxDensity) | [MTCheckbox](xref:C.MTCheckbox). |
| [DataTableDensity](xref:BlazorMdc.MTCascadingDefaults.DataTableDensity) | [MTDataTable](xref:C.MTDataTable). |
| [IconButtonDensity](xref:BlazorMdc.MTCascadingDefaults.IconButtonDensity) | [MTIconButton](xref:C.MTIconButton) and [MTIconButtonToggle](xref:C.MTIconButtonToggle). |
| [ListSingleLineDensity](xref:BlazorMdc.MTCascadingDefaults.ListSingleLineDensity) | [MTList](xref:C.MTList). |
| [RadioButtonDensity](xref:BlazorMdc.MTCascadingDefaults.RadioButtonDensity) | [MTRadioButton](xref:C.MTRadioButton) and [MTRadioButtonGroup](xref:C.MTRadioButtonGroup). |
| [SelectDensity](xref:BlazorMdc.MTCascadingDefaults.SelectDensity) | [MTSelect](xref:C.MTSelect). |
| [SwitchDensity](xref:BlazorMdc.MTCascadingDefaults.SwitchDensity) | [MTSwitch](xref:C.MTSwitch). |
| [TabBarDensity](xref:BlazorMdc.MTCascadingDefaults.TabBarDensity) | [MTTabBar](xref:C.MTTabBar). |
| [TextFieldDensity](xref:BlazorMdc.MTCascadingDefaults.TextFieldDensity) | [MTTextField](xref:C.MTTextField), [MTTextArea](xref:C.MTTextArea), [MTAutocomplete](xref:C.MTAutocomplete), [MTDebouncedTextField](xref:C.MTDebouncedTextField), [MTNumericDoubleField](xref:C.MTNumericDoubleField) and [MTNumericIntField](xref:C.MTNumericIntField). |

The order of priority for applying density is *first/highest* a component's `Density` parameter, *second* a component oriented cascading default (lines two onwards in the table above), 
then *third/last* `ThemeDensity` from cascading defaults. If either cascading defaults are not supplied or densities are not set, the default is [MTDensity.Default](xref:BlazorMdc.MTDensity.Default).

### General Properties

| Property | Used In |
| :------- | :------ |
| [Disabled](xref:BlazorMdc.MTCascadingDefaults.Disabled) | Sets the default `Disabled` state for all component, overridden by component `Disabled` parameters. |
| [ButtonStyle](xref:BlazorMdc.MTCascadingDefaults.ButtonStyle) | Style for general [MTButton](xref:C.MTButton)s. Defaults to `MTButtonStyle.Text`. |
| [CardActionButtonStyle](xref:BlazorMdc.MTCascadingDefaults.CardActionButtonStyle) | Style for [MTButton](xref:C.MTButton)s used for [MTCard](xref:C.MTCard) actions. Defaults to `MTButtonStyle.Text`. |
| [DialogActionButtonStyle](xref:BlazorMdc.MTCascadingDefaults.DialogActionButtonStyle) | Style for [MTButton](xref:C.MTButton)s used for [MTDialog](xref:C.MTDialog) actions. Defaults to `MTButtonStyle.Text`. |
| [CardStyle](xref:BlazorMdc.MTCascadingDefaults.CardStyle) | Style for [MTCard](xref:C.MTCard). Defaults to `MTCardStyle.Default`. |
| [ListStyle](xref:BlazorMdc.MTCascadingDefaults.ListStyle) | Style for [MTList](xref:C.MTList). Defaults to `MTListStyle.None`. |
| [ListType](xref:BlazorMdc.MTCascadingDefaults.ListType) | Style for [MTList](xref:C.MTList). Defaults to `MTListType.Regular`. |
| [SelectInputStyle](xref:BlazorMdc.MTCascadingDefaults.SelectInputStyle) | Style for [MTSelect](xref:C.MTSelect) and [MTDatePicker](xref:C.MTDatePicker). Defaults to `MTSelectInputStyle.Filled`. |
| [TextAlignStyle](xref:BlazorMdc.MTCascadingDefaults.TextAlignStyle) | Text alignment for [MTSelect](xref:C.MTSelect), [MTTextField](xref:C.MTTextField), [MTTextArea](xref:C.MTTextArea), [MTAutocomplete](xref:C.MTAutocomplete), [MTDebouncedTextField](xref:C.MTDebouncedTextField), [MTNumericDoubleField](xref:C.MTNumericDoubleField) and [MTNumericIntField](xref:C.MTNumericIntField). Defaults to `MTTextAlignStyle.Default` / left aligned for ltr input and vice versa. |
| [TextInputStyle](xref:BlazorMdc.MTCascadingDefaults.TextInputStyle) | Style for [MTTextField](xref:C.MTTextField), [MTTextArea](xref:C.MTTextArea), [MTAutocomplete](xref:C.MTAutocomplete), [MTDebouncedTextField](xref:C.MTDebouncedTextField), [MTNumericDoubleField](xref:C.MTNumericDoubleField) and [MTNumericIntField](xref:C.MTNumericIntField). Defaults to `MTTextInputStyle.Filled`. |
| [DateSelectionCriteria](xref:BlazorMdc.MTCascadingDefaults.DateSelectionCriteria) | Selection criteria for dates in [MTDatePicker](xref:C.MTDatePicker). Defaults to `MTDateSelectionCriteria.AllowAll`. |
| [DebounceInterval](xref:BlazorMdc.MTCascadingDefaults.DebounceInterval) | Debounce interval for [MTDebouncedTextField](xref:C.MTDebouncedTextField). Defaults to `300", meaning 300 milliseconds. |

### Attribute Splatting and Data Validation

Blazor MDC makes extensive use of attribute splatting. As a measure to help library users identify erroneous attributes cascading defautls allow you to specify that unassigned attributes should result
in an exception being thrown. Blazor MDC also has several ways of handling when a select or radio button group receives a two-way bound value that is not in its item list.

| Property | Usage |
| :------- | :---- |
| [ConstrainSplattableAttributes](xref:BlazorMdc.MTCascadingDefaults.ConstrainSplattableAttributes) | If set to `true`, which is the default, components throw an exception when unassigned attributes are used in razor markup. |
| [EssentialSplattableAttributes](xref:BlazorMdc.MTCascadingDefaults.EssentialSplattableAttributes) | A readonly list of HTML attributes that Blazor MDC requires for operation. Includes: `formnovalidate`, `id`, `max`, `min`, `role`, `step`, `tabindex` and `type`. Note that all aria attributes (e.g. `aria-disabled`) and event attibutes (e.g. `onclick`) are all allowed in addition to this list. |
| [AllowedSplattableAttributes](xref:BlazorMdc.MTCascadingDefaults.AllowedSplattableAttributes) | A list of HTML attributes that you can assign for Blazor MDC to allow without throwing an exception . |
| [ItemValidation](xref:BlazorMdc.MTCascadingDefaults.ItemValidation) | Validation method applied to [MTSelect](xref:C.MTSelect) and [MTRadioButtonGroup](xref:C.MTRadioButtonGroup). |

### Forcing a Blazor Re-Render with the Version Property

Whenever a property of [MTCascadingDefaults](xref:BlazorMdc.MTCascadingDefaults) is updated, the [Version](xref:BlazorMdc.MTCascadingDefaults.Version) property
is incremented. You can use [Version](xref:BlazorMdc.MTCascadingDefaults.Version) to force a Blazor component, or block of components within a `<div>` to 
re-render as a result of updated cascading defaults.

In the following example if `ThemeDensity`, `ButtonDensity`, `TextFieldDensity`, `ButtonStyle`, `TextFieldStyle` etc change in `myCascadingDefaults`, the
button and text field will re-render the next time Blazor renders the page.

```html
<div @key="@myCascadingDefaults.Version">
    <MTButton Label="A Button!" />

    <MTTextField Label="A Text Field!" />
</div>

@code {
    [CascadingParameter] private MTCascadingDefaults myCascadingDefaults { get; set; }
}
```