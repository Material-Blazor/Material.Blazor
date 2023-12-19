using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// A Material Theme numeric input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>
public abstract class InternalNumericFieldBase2<T, U> : InputComponent<T> 
    where T : struct, INumber<T>
    where U : InternalTextFieldBase2
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

    #endregion (MBText

    #region non-cascading parameters (MBDecimalField)

    /// <summary>
    /// Number of decimal places for the value. If more dp are entered the value gets rounded properly.
    /// </summary>
    [Parameter] public uint DecimalPlaces { get; set; } = 2;

    /// <summary>
    /// The minimum allowable value.
    /// </summary>
    [Parameter] public decimal? Min { get; set; }

    /// <summary>
    /// The maximum allowable value.
    /// </summary>
    [Parameter] public decimal? Max { get; set; }

    /// <summary>
    /// Format to apply to the numeric value when the field is not selected.
    /// </summary>
    [Parameter] public string NumericFormat { get; set; }

    /// <summary>
    /// Adjusts the value's magnitude as a number when the field is focused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved.
    /// </summary>
    [Parameter] public MBNumericInputMagnitude FocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;

    /// <summary>
    /// Alternative format for a singular number if required. An example is "1 month"
    /// vs "3 months".
    /// </summary>
    [Parameter] public string? NumericSingularFormat { get; set; }

    /// <summary>
    /// Adjusts the value's magnitude as a number when the field is unfocused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved.
    /// </summary>
    [Parameter] public MBNumericInputMagnitude UnfocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;

    #endregion

#nullable restore annotations

    #region injected members

    [Inject] private IJSRuntime JsRuntime { get; set; }

    #endregion

    #region local members

    private string DoublePattern { get; } = @"^[-+]?[0-9]*\.?[0-9]+$";
    private string PositiveDoublePattern { get; } = @"[0-9]*\.?[0-9]+$";
    private string IntegerPattern { get; } = @"^(\+|-)?\d+$";
    private string PositiveIntegerPattern { get; } = @"^\d+$";


    private decimal AppliedMultiplier => HasFocus ? FocusedMultiplier : UnfocusedMultiplier;
    private decimal FocusedMultiplier { get; set; } = 1;
    public bool HasFocus { get; set; } = false;
    internal string ItemType { get; set; } = "text";
    private int MyDecimalPlaces { get; set; } = 0;
    public Regex Regex { get; set; }
    private bool SelectInputContentOnAfterRender { get; set; } = false;
    private U TextField { get; set; }
    private decimal UnfocusedMultiplier { get; set; } = 1;

    #endregion

    #endregion

    #region BuildRenderTree

    /// <inheritdoc/>
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();

        builder.OpenComponent<U>(0);
        {
            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(1, attributesToSplat);
            }

            builder.AddAttribute(2, "class", @class);
            builder.AddAttribute(3, "style", style);
            builder.AddAttribute(4, "id", id);

            if (HasFocus)
            {
                builder.AddAttribute(5, "type", "number");
                builder.AddAttribute(6, "formnovalidate", true);
                builder.AddAttribute(7, "Value", BindConverter.FormatValue(ConvertToUnformattedTextValue(Value)));
                SelectInputContentOnAfterRender = true;
            }
            else
            {
                builder.AddAttribute(5, "type", "text");
                builder.AddAttribute(7, "Value", BindConverter.FormatValue(ConvertToFormattedTextValue(Value)));
            }

            builder.AddAttribute(8, "ValueChanged", RuntimeHelpers.TypeCheck(EventCallback.Factory.Create(this, RuntimeHelpers.CreateInferredEventCallback(this, __value => ValueChanged.InvokeAsync(ConvertToNumericValue(__value)), ConvertToUnformattedTextValue(Value)))));
            var stringValue = HasFocus ? ConvertToUnformattedTextValue(Value) : ConvertToFormattedTextValue(Value);
            builder.AddAttribute(9, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<string>>>(() => stringValue));

            builder.AddAttribute(10, "onfocusin", EventCallback.Factory.Create<FocusEventArgs>(this, OnFocusInAsync));
            builder.AddAttribute(11, "onfocusout", EventCallback.Factory.Create<FocusEventArgs>(this, OnFocusOutAsync));
            builder.AddAttribute(12, "Disabled", Disabled);
            builder.AddAttribute(13, "label", Label);
            builder.AddAttribute(14, "SupportingText", SupportingText);
            builder.AddAttribute(15, "SupportingTextPersistent", SupportingTextPersistent);
            builder.AddAttribute(16, "LeadingIcon", LeadingIcon);
            builder.AddAttribute(17, "TrailingIcon", TrailingIcon);
            builder.AddAttribute(18, "Prefix", Prefix);
            builder.AddAttribute(19, "Suffix", Suffix);
            builder.AddAttribute(20, "Density", Density);

            if (Min is not null)
            {
                builder.AddAttribute(21, "min", Min);
            }

            if (Max is not null)
            {
                builder.AddAttribute(22, "max", Max);
            }

            var step = BuildStep();

            if (!string.IsNullOrWhiteSpace(step))
            {
                builder.AddAttribute(23, "step", BuildStep());
            }

            builder.AddAttribute(24, "TextAlignStyle", MBTextAlignStyle.Right);
            builder.AddAttribute(25, "ValidationMessageFor", ValidationMessageFor);
            builder.AddAttribute(26, "TextInputStyle", TextInputStyle);

            builder.AddComponentReferenceCapture(27, __value => TextField = (U)__value);
        }
        builder.CloseComponent();
    }

    #endregion

    #region BuildStep

    /// <summary>
    /// Returns the step value.
    /// </summary>
    /// <returns></returns>
    private protected virtual string BuildStep()
    {
        return "1";
    }

    #endregion

    #region ConvertToFormattedTextValue (abstract)

    /// <summary>
    /// Converts a string value from the text field to a formatted numeric value.
    /// </summary>
    /// <returns></returns>
    private protected abstract string ConvertToFormattedTextValue(T value);

    #endregion

    #region ConvertToNumericValue (abstract)

    /// <summary>
    /// Converts a string value from the text field to a numeric value.
    /// </summary>
    /// <returns></returns>
    private protected abstract T ConvertToNumericValue(string value);

    #endregion

    #region ConvertToUnformattedTextValue (abstract)
    /// <summary>
    /// Converts a string value from the text field to an unformatted numeric value, subject to the correct number of decimal places.
    /// </summary>
    /// <returns></returns>
    private protected abstract string ConvertToUnformattedTextValue(T displayText);

    #endregion

    #region GetDecimalPlaces

    /// <summary>
    /// Returns the required number of decimal places.
    /// </summary>
    /// <returns></returns>
    private protected virtual int GetDecimalPlaces()
    {
        return 0;
    }

    #endregion

    #region GetFocusedMagnitude

    /// <summary>
    /// Returns the focused magnitude.
    /// </summary>
    /// <returns></returns>
    private protected virtual MBNumericInputMagnitude GetFocusedMagnitude()
    {
        return MBNumericInputMagnitude.Normal;
    }

    #endregion

    #region GetUnfocusedMagnitude

    /// <summary>
    /// Returns the unfocused magnitude.
    /// </summary>
    /// <returns></returns>
    private protected virtual MBNumericInputMagnitude GetUnfocusedMagnitude()
    {
        return MBNumericInputMagnitude.Normal;
    }

    #endregion

    #region OnAfterRenderAsync

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender).ConfigureAwait(false);

        if (SelectInputContentOnAfterRender)
        {
            SelectInputContentOnAfterRender = false;

            await TextField.SelectFieldContent();
        }
    }

    #endregion

    #region OnFocusInAsync

    private async Task OnFocusInAsync()
    {
        HasFocus = true;
        await InvokeAsync(StateHasChanged);
    }

    #endregion

    #region OnFocusOutAsync

    private async Task OnFocusOutAsync()
    {
        HasFocus = false;
        await InvokeAsync(StateHasChanged);
    }

    #endregion

    #region OnParametersSetAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        var allowSign = Min is not (not null and >= 0);

        Regex = new Regex(allowSign ? DoublePattern : PositiveDoublePattern);

        //Regex = GetDecimalPlaces() == 0
        //    ? new Regex(allowSign ? IntegerPattern : PositiveIntegerPattern)
        //    : new Regex(allowSign ? DoublePattern : PositiveDoublePattern);
    }

    #endregion

}
