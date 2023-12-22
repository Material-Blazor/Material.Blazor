using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A Material Theme numeric input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>
public sealed class MBDecimalField : InputComponent<decimal>
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
    [Parameter] public int DecimalPlaces { get; set; } = 2;

    /// <summary>
    /// Adjusts the value's magnitude as a number when the field is focused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved.
    /// </summary>
    [Parameter] public MBNumericInputMagnitude FocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;

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
    private bool HasFocus { get; set; } = false;
    internal string ItemType { get; set; } = "text";
    private int MyDecimalPlaces { get; set; } = 0;
    private Regex Regex { get; set; }
    private bool SelectInputContentOnAfterRender { get; set; } = false;
    private decimal UnfocusedMultiplier { get; set; } = 1;

    #endregion

    #endregion

    #region AppliedFormat

    private string AppliedFormat
    {
        get
        {
            if (HasFocus)
            {
                return "";
            }

            if ((NumericSingularFormat is not null) && Utilities.DecimalEqual(Math.Abs(ComponentValue), 1))
            {
                return NumericSingularFormat;
            }

            return NumericFormat;
        }
    }

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToDictionary();
        string value;

        if (HasFocus)
        {
            attributesToSplat.Add("type", "number");
            attributesToSplat.Add("max", Max.ToString());
            attributesToSplat.Add("min", Min.ToString());
            attributesToSplat.Add("step", Math.Pow(10, -MyDecimalPlaces).ToString());
            attributesToSplat.Add("formnovalidate", true);
            value = ConvertToUnformattedTextValue(Value);
            SelectInputContentOnAfterRender = true;
        }
        else
        {
            attributesToSplat.Add("type", "text");
            value = ConvertToFormattedTextValue(Value);
        }

        var rendSeq = 0;

        EventCallback focusIn =
            EventCallback.Factory.Create(this, () => OnFocusIn());

        EventCallback focusOut =
            EventCallback.Factory.Create(this, () => OnFocusOut());

        EventCallback<string> valueChanged =
            EventCallback.Factory.Create(this, (string newValue) => TextFieldStringValueChanged(newValue));

        InternalTextFieldRenderer.BuildTextFieldRenderTree(
            builder,
            ref rendSeq,
            CascadingDefaults,
            typeof(MBTextField),
            @class,
            @style,
            AppliedDisabled,
            Density,
            attributesToSplat,
            value,
            valueChanged,
            () => TextFieldStringValue,
            focusIn,
            focusOut,
            Label,
            Prefix,
            Suffix,
            SupportingText,
            TextAlignStyle,
            TextFieldId,
            TextInputStyle,
            ItemType,
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
            ValidationMessageFor);
    }

    #endregion

    #region ConvertToFormattedTextValue

    private string ConvertToFormattedTextValue(decimal value)
    {
        var format = NumericSingularFormat is not null && Utilities.DecimalEqual(Math.Abs(Value), 1)
            ? NumericSingularFormat
            : NumericFormat;

        return (value * GetMultiplier()).ToString(format);
    }

    #endregion

    #region ConvertToUnformattedTextValue

    private string ConvertToUnformattedTextValue(decimal value)
    {
        return Math.Round(value * GetMultiplier(), DecimalPlaces).ToString();
    }

    #endregion

    #region GetMultiplier

    private decimal GetMultiplier()
    {
        var magnitude = HasFocus ? (int)FocusedMagnitude : (int)UnfocusedMagnitude;
        return Convert.ToDecimal(Math.Pow(10, magnitude));
    }

    #endregion

    #region OnAfterRenderAsync

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender).ConfigureAwait(false);

        if (SelectInputContentOnAfterRender)
        {
            SelectInputContentOnAfterRender = false;

            await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTextField.selectFieldContent", TextFieldId).ConfigureAwait(false);
        }
    }

    #endregion

    #region OnInitializedAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        //
        //  Note the use of multiple parameters that presume invariance during the
        //  life of this component.
        //      DecimalPlaces
        //      FocusedMultiplier
        //      Max
        //      Min
        //      UnfocusedMultiplier
        //
        await base.OnInitializedAsync();

        var allowSign = Min is not (not null and >= 0);

        FocusedMultiplier = Convert.ToDecimal(Math.Pow(10, (int)FocusedMagnitude));
        UnfocusedMultiplier = Convert.ToDecimal(Math.Pow(10, (int)UnfocusedMagnitude));

        if (DecimalPlaces <= 0)
        {
            MyDecimalPlaces = 0;
            Regex = new Regex(allowSign ? IntegerPattern : PositiveIntegerPattern);
        }
        else
        {
            MyDecimalPlaces = (int)DecimalPlaces;
            Regex = new Regex(allowSign ? DoublePattern : PositiveDoublePattern);
        }

        TextFieldStringValue = StringValue(ComponentValue);
    }

    #endregion

    #region NumericValue

    private decimal NumericValue(string displayText)
    {
        var myRounding = MyDecimalPlaces + Convert.ToInt32(Math.Log(Convert.ToDouble(AppliedMultiplier)));

        if (!Regex.IsMatch(displayText))
        {
            return ComponentValue;
        }

        decimal amount;
        try
        {
            amount = Convert.ToDecimal(Math.Round(Convert.ToDecimal(displayText) / AppliedMultiplier, myRounding));
        }
        catch
        {
            return ComponentValue;
        }

        if ((Min != null && amount < Min) || (Max != null && amount > Max))
        {
            return ComponentValue;
        }

        return amount;
    }

    #endregion

    #region OnFocusIn

    private async Task OnFocusIn()
    {
        HasFocus = true;
        await InvokeAsync(StateHasChanged);
    }

    #endregion

    #region OnFocusOut

    private async Task OnFocusOut()
    {
        HasFocus = false;
        await InvokeAsync(StateHasChanged);
    }

    #endregion

    #region StringValue

    private string StringValue(decimal? value) => (Convert.ToDecimal(value) * AppliedMultiplier).ToString(AppliedFormat);

    #endregion

    #region TextFieldStringValue

    // There may be a case for simplifying this code. Does TextFieldStringValue need to be bound like this or can we instead bind to a string representation of the
    // properly scaled number without formatting intended only for human legibility?
    private string fv;
    private string TextFieldStringValue
    {
        get
        {
            return fv;
        }

        set
        {
            fv = value;
            decimal enteredVal;
            if (HasFocus)
            {
                enteredVal = Convert.ToDecimal(string.IsNullOrWhiteSpace(fv) ? "0" : fv.Trim()) / FocusedMultiplier;
            }
            else
            {
                enteredVal = NumericValue(fv) / AppliedMultiplier;
            }
            ComponentValue = Convert.ToDecimal(Math.Round(Math.Max(Min ?? enteredVal, Math.Min(enteredVal, Max ?? enteredVal)), MyDecimalPlaces + (int)FocusedMagnitude));
        }
    }

    #endregion

    #region TextFieldStringValueChanged

    private void TextFieldStringValueChanged(string newValue)
    {
        TextFieldStringValue = newValue;
    }

    #endregion

}
