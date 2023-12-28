using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System;
using System.Linq;
using System.Linq.Expressions;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor formatted integer field.
/// </summary>
public sealed class MBIntField : InputComponent<int>
{

    #region members

#nullable enable annotations

    #region non-cascading parameters (MBTextField)

    /// <summary>
    /// The text field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }

    /// <summary>
    /// The leading icon's descriptor. No leading icon is shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingIcon { get; set; }

    /// <summary>
    /// Adding a toggleicon turns the leading icon into a toggleiconbutton.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingToggleIcon { get; set; }

    /// <summary>
    /// The link for the iconbutton
    /// </summary>
    [Parameter] public string LeadingToggleIconButtonLink { get; set; }

    /// <summary>
    /// The link target for the iconbutton
    /// </summary>
    [Parameter] public string LeadingToggleIconButtonLinkTarget { get; set; }

    /// <summary>
    /// The toggle state of the icon button
    /// </summary>
    [Parameter] public bool LeadingToggleIconSelected { get; set; }

    /// <summary>
    /// Prefix text.
    /// </summary>
    [Parameter] public string? Prefix { get; set; }

    /// <summary>
    /// Suffix text.
    /// </summary>
    [Parameter] public string? Suffix { get; set; }

    /// <summary>
    /// Supporting text that is displayed either with focus or persistently with <see cref="SupportingTextPersistent"/>.
    /// </summary>
    [Parameter] public string SupportingText { get; set; } = "";

    /// <summary>
    /// Makes the <see cref="SupportingText"/> persistent if true.
    /// </summary>
    [Parameter] public bool SupportingTextPersistent { get; set; } = false;

    /// <summary>
    /// The text alignment style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
    /// </summary>
    [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }

    /// <summary>
    /// The unique id for the text field; Used to locate the text field
    /// from JS interop methods.
    /// 
    /// In normal use there is no need to set this parameter in the calling component
    /// </summary>
    [Parameter] public string TextFieldId { get; set; } = "textfield-id-" + Guid.NewGuid().ToString().ToLower();

    /// <summary>
    /// The text input style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
    /// </summary>
    [Parameter] public MBTextInputStyle TextInputStyle { get; set; } = MBTextInputStyle.Outlined;

    /// <summary>
    /// The trailing icon's descriptor. No trailing icon is shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingIcon { get; set; }

    /// <summary>
    /// Adding a toggleicon turns the trailing icon into a toggleiconbutton.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingToggleIcon { get; set; }

    /// <summary>
    /// The link for the iconbutton
    /// </summary>
    [Parameter] public string TrailingToggleIconButtonLink { get; set; }

    /// <summary>
    /// The link target for the iconbutton
    /// </summary>
    [Parameter] public string TrailingToggleIconButtonLinkTarget { get; set; }

    /// <summary>
    /// The toggle state of the icon button
    /// </summary>
    [Parameter] public bool TrailingToggleIconSelected { get; set; }

    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }

    #endregion (MBText)

    #region non-cascading parameters (MBIntField)

    /// <summary>
    /// Adjusts the value's magnitude as a number when the field is focused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved).
    /// </summary>
    [Parameter] public MBNumericInputMagnitude FocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;

    /// <summary>
    /// The maximum allowable value.
    /// </summary>
    [Parameter] public int? Max { get; set; }

    /// <summary>
    /// The minimum allowable value.
    /// </summary>
    [Parameter] public int? Min { get; set; }

    /// <summary>
    /// Format to apply to the numeric value when the field is not selected.
    /// </summary>
    [Parameter] public string NumericFormat { get; set; }

    /// <summary>
    /// Alternative format for a singular number if required. An example is "1 month"
    /// vs "3 months".
    /// </summary>
    [Parameter] public string? NumericSingularFormat { get; set; }

    /// <summary>
    /// Adjusts the value's magnitude as a number when the field is unfocused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved).
    /// </summary>
    [Parameter] public MBNumericInputMagnitude UnfocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;

    #endregion

#nullable restore annotations

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToDictionary();
        var rendSeq = 0;

        EventCallback<decimal> valueChanged =
            EventCallback.Factory.Create(this, (decimal newValue) => DecimalValueChanged(newValue));

        InternalDecimalFieldRenderer.BuildDecimalFieldRenderTree(
            builder,
            ref rendSeq,
            CascadingDefaults,
            @class,
            @style,
            AppliedDisabled,
            Density,
            attributesToSplat,
            DecimalValue,
            valueChanged,
            () => DecimalValue,
            null,
            null,
            0,
            FocusedMagnitude,
            Label,
            DecimalMin,
            DecimalMax,
            NumericFormat,
            NumericSingularFormat,
            Prefix,
            Suffix,
            SupportingText,
            TextAlignStyle,
            TextFieldId,
            TextInputStyle,
            null,
            LeadingIcon,
            LeadingToggleIcon,
            LeadingToggleIconButtonLink,
            LeadingToggleIconButtonLinkTarget,
            LeadingToggleIconSelected,
            TrailingIcon,
            TrailingToggleIcon,
            TrailingToggleIconButtonLink,
            TrailingToggleIconButtonLinkTarget,
            TrailingToggleIconSelected,
            UnfocusedMagnitude,
            ValidationMessageFor);
    }

    #endregion

    #region DecimalMin
    private decimal? DecimalMin
    {
        get
        {
            if (Min == null)
            {
                return null;
            }

            return (decimal)Min;
        }
    }

    #endregion

    #region DecimalMax

    private decimal? DecimalMax
    {
        get
        {
            if (Max == null)
            {
                return null;
            }
            return (decimal)Max;
        }
    }

    #endregion

    #region DecimalValue

    private decimal DecimalValue
    {
        get => Convert.ToDecimal(ComponentValue);
        set => ComponentValue = Convert.ToInt32(value);
    }

    #endregion

    #region DecimalValueChanged

    private void DecimalValueChanged(decimal newValue)
    {
        DecimalValue = newValue;
    }

    #endregion

}
