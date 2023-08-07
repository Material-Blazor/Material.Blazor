---
uid: A.CascadingDefaults
title: CascadingDefaults
---
# Cascading Defaults

Material.Blazor uses a system of cascading defaults using [MBCascadingDefaults](xref:U.MBCascadingDefaults) to control defaults for things such as button style and density, text field
style and so on. The `MBCascadingDefaults` class is supplied to components held within a `<CascadingValue>` tag. Cascading defaults can be nested (the most recent)
takes precedence as for any cascading value, and if no cascading defaults are supplied, a default scheme is applied by Material.Blazor. Cascading defaults apply when
an optional parameter is not supplied to a component.

This section describes the usage of properties in [MBCascadingDefaults](xref:U.MBCascadingDefaults).

## Icons

The following properties are used for displaying icons. Material.Blazor components all render icons using the [MBIcon](xref:C.MBIcon) component which renders any of Material Icons, Font
Awesome of Open Iconic icons and their respective variants. Any component that uses icons accepts an optional `IconFoundry` parameter, which 

| Property | Used In |
| :------- | :------ |
| [IconFoundryName](xref:Material.Blazor.MBCascadingDefaults.IconFoundryName) | The default icon foundry. |
| [IconMITheme](xref:Material.Blazor.MBCascadingDefaults.IconMITheme) | The default Material Icons theme. |
| [IconFAStyle](xref:Material.Blazor.MBCascadingDefaults.IconFAStyle) | The default Font Awesome style. |
| [IconFARelativeSize](xref:Material.Blazor.MBCascadingDefaults.IconFARelativeSize) | The default Font Awesome relative size. |

## Density Subsystem

Material Theme has a [density subsystem](xref:A.Density) which applies to some components. When a component Density parameter is not set the folliwng cascading defaults apply:

| Property | Used In |
| :------- | :------ |
| [ThemeDensity](xref:Material.Blazor.MBCascadingDefaults.ThemeDensity) | A default for all components unless over-ridden by first one of the cascading default parameters below or second a component's own `Density` parameter. |
| [ButtonDensity](xref:Material.Blazor.MBCascadingDefaults.ButtonDensity) | [MBButton](xref:C.MBButton). |
| [CheckboxDensity](xref:Material.Blazor.MBCascadingDefaults.CheckboxDensity) | [MBCheckbox](xref:C.MBCheckbox). |
| [DataTableDensity](xref:Material.Blazor.MBCascadingDefaults.DataTableDensity) | [MBDataTable](xref:C.MBDataTable). |
| [IconButtonDensity](xref:Material.Blazor.MBCascadingDefaults.IconButtonDensity) | [MBIconButton](xref:C.MBIconButton) and [MBIconButtonToggle](xref:C.MBIconButtonToggle). |
| [ListSingleLineDensity](xref:Material.Blazor.MBCascadingDefaults.ListSingleLineDensity) | [MBList](xref:C.MBList). |
| [RadioButtonDensity](xref:Material.Blazor.MBCascadingDefaults.RadioButtonDensity) | [MBRadioButton](xref:C.MBRadioButton) and [MBRadioButtonGroup](xref:C.MBRadioButtonGroup). |
| [SelectDensity](xref:Material.Blazor.MBCascadingDefaults.SelectDensity) | [MBSelect](xref:C.MBSelect). |
| [SwitchDensity](xref:Material.Blazor.MBCascadingDefaults.SwitchDensity) | [MBSwitch](xref:C.MBSwitch). |
| [TabBarDensity](xref:Material.Blazor.MBCascadingDefaults.TabBarDensity) | [MBTabBar](xref:C.MBTabBar). |
| [TextFieldDensity](xref:Material.Blazor.MBCascadingDefaults.TextFieldDensity) | [MBTextField](xref:C.MBTextField), [MBTextArea](xref:C.MBTextArea), [MBAutocompletePagedField](xref:C.MBAutocompletePagedField), [MBAutocompleteSelectField](xref:C.MBAutocompleteSelectField), [MBAutocompleteTextField](xref:C.MBAutocompleteTextField), [MBDebouncedTextField](xref:C.MBDebouncedTextField), [MBNumericDoubleField](xref:C.MBNumericDoubleField) and [MBNumericIntField](xref:C.MBNumericIntField). |

The order of priority for applying density is *first/highest* a component's `Density` parameter, *second* a component oriented cascading default (lines two onwards in the table above), 
then *third/last* `ThemeDensity` from cascading defaults. If either cascading defaults are not supplied or densities are not set, the default is [MBDensity.Default](xref:Material.Blazor.MBDensity.Default).

## General Properties

| Property | Used In |
| :------- | :------ |
| [Disabled](xref:Material.Blazor.MBCascadingDefaults.Disabled) | Sets the default `Disabled` state for all component, overridden by component `Disabled` parameters. |
| [ButtonStyle](xref:Material.Blazor.MBCascadingDefaults.ButtonStyle) | Style for general [MBButton](xref:C.MBButton)s. Defaults to `MBButtonStyle.Text`. |
| [CardActionButtonStyle](xref:Material.Blazor.MBCascadingDefaults.CardActionButtonStyle) | Style for [MBButton](xref:C.MBButton)s used for [MBCard](xref:C.MBCard) actions. Defaults to `MBButtonStyle.Text`. |
| [DialogActionButtonStyle](xref:Material.Blazor.MBCascadingDefaults.DialogActionButtonStyle) | Style for [MBButton](xref:C.MBButton)s used for [MBDialog](xref:C.MBDialog) actions. Defaults to `MBButtonStyle.Text`. |
| [CardStyle](xref:Material.Blazor.MBCascadingDefaults.CardStyle) | Style for [MBCard](xref:C.MBCard). Defaults to `MBCardStyle.Default`. |
| [ListStyle](xref:Material.Blazor.MBCascadingDefaults.ListStyle) | Style for [MBList](xref:C.MBList). Defaults to `MBListStyle.None`. |
| [ListType](xref:Material.Blazor.MBCascadingDefaults.ListType) | Style for [MBList](xref:C.MBList). Defaults to `MBListType.Regular`. |
| [SelectInputStyle](xref:Material.Blazor.MBCascadingDefaults.SelectInputStyle) | Style for [MBSelect](xref:C.MBSelect) and [MBDatePicker](xref:C.MBDatePicker). Defaults to `MBSelectInputStyle.Filled`. |
| [TextAlignStyle](xref:Material.Blazor.MBCascadingDefaults.TextAlignStyle) | Text alignment for [MBSelect](xref:C.MBSelect), [MBTextField](xref:C.MBTextField), [MBTextArea](xref:C.MBTextArea), [MBAutocompletePagedField](xref:C.MBAutocompletePagedField), [MBAutocompleteSelectField](xref:C.MBAutocompleteSelectField), [MBAutocompleteTextField](xref:C.MBAutocompleteTextField), [MBDebouncedTextField](xref:C.MBDebouncedTextField), [MBNumericDoubleField](xref:C.MBNumericDoubleField) and [MBNumericIntField](xref:C.MBNumericIntField). Defaults to `MBTextAlignStyle.Default` / left aligned for ltr input and vice versa. |
| [TextInputStyle](xref:Material.Blazor.MBCascadingDefaults.TextInputStyle) | Style for [MBTextField](xref:C.MBTextField), [MBTextArea](xref:C.MBTextArea), [MBAutocompletePagedField](xref:C.MBAutocompletePagedField), [MBAutocompleteSelectField](xref:C.MBAutocompleteSelectField), [MBAutocompleteTextField](xref:C.MBAutocompleteTextField), [MBDebouncedTextField](xref:C.MBDebouncedTextField), [MBNumericDoubleField](xref:C.MBNumericDoubleField) and [MBNumericIntField](xref:C.MBNumericIntField). Defaults to `MBTextInputStyle.Filled`. |
| [DateSelectionCriteria](xref:Material.Blazor.MBCascadingDefaults.DateSelectionCriteria) | Selection criteria for dates in [MBDatePicker](xref:C.MBDatePicker). Defaults to `MBDateSelectionCriteria.AllowAll`. |
| [DebounceInterval](xref:Material.Blazor.MBCascadingDefaults.DebounceInterval) | Debounce interval for [MBDebouncedTextField](xref:C.MBDebouncedTextField). Defaults to `300", meaning 300 milliseconds. |

## Attribute Splatting and Data Validation

Material.Blazor makes extensive use of attribute splatting. As a measure to help library users identify erroneous attributes cascading defautls allow you to specify that unassigned attributes should result
in an exception being thrown. Material.Blazor also has several ways of handling when a select or radio button group receives a two-way bound value that is not in its item list.

| Property | Usage |
| :------- | :---- |
| [ConstrainSplattableAttributes](xref:Material.Blazor.MBCascadingDefaults.ConstrainSplattableAttributes) | If set to `true`, which is the default, components throw an exception when unassigned attributes are used in razor markup. Defaults to `false`. |
| [AllowedSplattableAttributes](xref:Material.Blazor.MBCascadingDefaults.AllowedSplattableAttributes) | A list of HTML attributes that you can assign for Material.Blazor to allow without throwing an exception . |
| [ItemValidation](xref:Material.Blazor.MBCascadingDefaults.ItemValidation) | Validation method applied to [MBSelect](xref:C.MBSelect) and [MBRadioButtonGroup](xref:C.MBRadioButtonGroup). |

## Forcing a Blazor Re-Render with the Version Property

Whenever a property of [MBCascadingDefaults](xref:Material.Blazor.MBCascadingDefaults) is updated, the [Version](xref:Material.Blazor.MBCascadingDefaults.Version) property
is incremented. You can use [Version](xref:Material.Blazor.MBCascadingDefaults.Version) to force a Blazor component, or block of components within a `<div>` to 
re-render as a result of updated cascading defaults.

In the following example if `ThemeDensity`, `ButtonDensity`, `TextFieldDensity`, `ButtonStyle`, `TextFieldStyle` etc change in `myCascadingDefaults`, the
button and text field will re-render the next time Blazor renders the page.

```html
<div @key="@myCascadingDefaults.Version">
    <MBButton Label="A Button!" />

    <MBTextField Label="A Text Field!" />
</div>

@code {
    [CascadingParameter] private MBCascadingDefaults myCascadingDefaults { get; set; }
}
```