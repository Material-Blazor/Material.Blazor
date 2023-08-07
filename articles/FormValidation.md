---
uid: A.FormValidation
title: FormValidation
---
# Form Validation

## Summary

Material.Blazor integrates native Blazor form validation with Material Theme's validation methodology. Usually in Blazor apps you use the `ValidationMessage` component
to display validation results and you can still do this.

We have given you an alternative however, with a `ValidationMessageFor` parameter on MBAutocompletePagedField, MBAutocompleteSelectField, MBAutocompleteTextField, MBNumericDoubleField, MBNumericIntField, MBTextArea and MBTextField.
This parameter takes the same value as the one you would pass to the vanilla Blazor `ValidationMessage` component. Your options are below.

## Material.Blazor Validation Messages

The new Material.Blazor validation mechanism is built into the components mentioned above. When there's a validation error outlines take the invalid color (usually red) and 
the text field's label shakes.

```html
<MBTextField @bind-Value="@Model.Text"
             Label="Text Field"
             TextInputStyle="@MBTextInputStyle.Outlined"
             ValidationMessageFor="@(() => Model.Text)" />
```

## Standard Blazor Validation Messages

If you prefer, you can continue to use standard Blazor validation messages.

```html
<MBTextField @bind-Value="@Model.Text"
             Label="Text Field"
             TextInputStyle="@MBTextInputStyle.Outlined" />
<ValidationMessage For="@(() => Model.Text)" />
```