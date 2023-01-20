using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
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
public abstract class InternalNumericFieldBase<T, U> : InputComponentMD3<T> 
    where T : struct, INumber<T>
    where U : InternalTextFieldBase
{
#nullable enable annotations
    /// <summary>
    /// Supporting text that is displayed either with focus or persistently with <see cref="SupportingTextPersistent"/>.
    /// </summary>
    [Parameter] public string SupportingText { get; set; } = "";


    /// <summary>
    /// Makes the <see cref="SupportingText"/> persistent if true.
    /// </summary>
    [Parameter] public bool SupportingTextPersistent { get; set; } = false;


    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }


    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }


    /// <summary>
    /// Prefix text.
    /// </summary>
    [Parameter] public string? Prefix { get; set; }


    /// <summary>
    /// Suffix text.
    /// </summary>
    [Parameter] public string? Suffix { get; set; }


    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? LeadingIcon { get; set; }


    /// <summary>
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? TrailingIcon { get; set; }


    /// <summary>
    /// The numeric field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


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
    /// The minimum allowable value.
    /// </summary>
    [Parameter] public T? Min { get; set; }


    /// <summary>
    /// The maximum allowable value.
    /// </summary>
    [Parameter] public T? Max { get; set; }
#nullable restore annotations


    private const string DoublePattern = @"^[-+]?[0-9]*\.?[0-9]+$";
    private const string PositiveDoublePattern = @"[0-9]*\.?[0-9]+$";
    private const string IntegerPattern = @"^(\+|-)?\d+$";
    private const string PositiveIntegerPattern = @"^\d+$";


    /// <summary>
    /// REGEX that matches valid text field input
    /// </summary>
    private protected Regex Regex { get; set; }


    /// <summary>
    /// Indicates whether the text field has focus.
    /// </summary>
    private protected bool HasFocus { get; set; } = false;


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        var allowSign = Min is not (not null and >= 0);

        if (GetDecimalPlaces() == 0)
        {
            Regex = new Regex(allowSign ? IntegerPattern : PositiveIntegerPattern);
        }
        else
        {
            Regex = new Regex(allowSign ? DoublePattern : PositiveDoublePattern);
        }
    }

    private string StringValue => HasFocus ? ConvertToUnformattedTextValue(Value) : ConvertToFormattedTextValue(Value);
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
                builder.AddAttribute(6, "Value", BindConverter.FormatValue(ConvertToUnformattedTextValue(Value)));
                //builder.AddAttribute(8, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<string>>>(() => ConvertToUnformattedTextValue(Value)));
            }
            else
            {
                builder.AddAttribute(5, "type", "text");
                builder.AddAttribute(6, "Value", BindConverter.FormatValue(ConvertToFormattedTextValue(Value)));
                //builder.AddAttribute(8, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<string>>>(() => ConvertToFormattedTextValue(Value)));
            }

            builder.AddAttribute(7, "ValueChanged", RuntimeHelpers.TypeCheck(EventCallback.Factory.Create(this, RuntimeHelpers.CreateInferredEventCallback(this, __value => ValueChanged.InvokeAsync(ConvertToNumericValue(__value)), ConvertToUnformattedTextValue(Value)))));
            builder.AddAttribute(8, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<string>>>(() => StringValue));

            //builder.AddAttribute(8, "ValueExpression", () => Value);




            builder.AddAttribute(8, "onfocusin", EventCallback.Factory.Create<FocusEventArgs>(this, OnFocusInAsync));
            builder.AddAttribute(9, "onfocusout", EventCallback.Factory.Create<FocusEventArgs>(this, OnFocusOutAsync));

            if (AppliedDisabled)
            {
                builder.AddAttribute(10, "Disabled");
            }

            builder.AddAttribute(11, "label", Label);
            builder.AddAttribute(12, "SupportingText", SupportingText);
            builder.AddAttribute(13, "SupportingTextPersistent", SupportingTextPersistent);
            builder.AddAttribute(14, "LeadingIcon", LeadingIcon);
            builder.AddAttribute(15, "TrailingIcon", TrailingIcon);
            builder.AddAttribute(16, "Prefix", Prefix);
            builder.AddAttribute(17, "Suffix", Suffix);

            builder.AddAttribute(18, "Density", Density);

            if (Min is not null)
            {
                builder.AddAttribute(19, "min", Min);
            }

            if (Max is not null)
            {
                builder.AddAttribute(20, "max", Max);
            }

            builder.AddAttribute(21, "step", BuildStep());
            builder.AddAttribute(22, "TextAlignStyle", MBTextAlignStyle.Right);
            builder.AddAttribute(23, "ValidationMessageFor", ValidationMessageFor);
        }
        builder.CloseComponent();
    }


    /// <summary>
    /// Converts a string value from the text field to a numeric value.
    /// </summary>
    /// <returns></returns>
    private protected abstract T ConvertToNumericValue(string value);


    /// <summary>
    /// Converts a string value from the text field to a formatted numeric value.
    /// </summary>
    /// <returns></returns>
    private protected abstract string ConvertToFormattedTextValue(T value);


    /// <summary>
    /// Converts a string value from the text field to an unformatted numeric value, subject to the correct number of decimal places.
    /// </summary>
    /// <returns></returns>
    private protected abstract string ConvertToUnformattedTextValue(T displayText);


    /// <summary>
    /// Returns the step value.
    /// </summary>
    /// <returns></returns>
    private protected virtual string BuildStep()
    {
        return "1";
    }


    /// <summary>
    /// Returns the focused magnitude.
    /// </summary>
    /// <returns></returns>
    private protected virtual MBNumericInputMagnitude GetFocusedMagnitude()
    {
        return MBNumericInputMagnitude.Normal;
    }


    /// <summary>
    /// Returns the unfocused magnitude.
    /// </summary>
    /// <returns></returns>
    private protected virtual MBNumericInputMagnitude GetUnfocusedMagnitude()
    {
        return MBNumericInputMagnitude.Normal;
    }


    /// <summary>
    /// Returns the required number of decimal places.
    /// </summary>
    /// <returns></returns>
    private protected virtual int GetDecimalPlaces()
    {
        return 0;
    }


    private async Task OnFocusInAsync()
    {
        HasFocus = true;
        await InvokeAsync(StateHasChanged);
    }


    private async Task OnFocusOutAsync()
    {
        HasFocus = false;
        await InvokeAsync(StateHasChanged);
    }


    //private string StringValue(decimal? value) => (Convert.ToDecimal(value) * AppliedMultiplier).ToString(AppliedFormat);


    //private decimal NumericValue(string displayText)
    //{
    //    var myRounding = MyDecimalPlaces + Convert.ToInt32(Math.Log(Convert.ToDouble(AppliedMultiplier)));

    //    if (!Regex.IsMatch(displayText))
    //    {
    //        return ComponentValue;
    //    }

    //    decimal amount;
    //    try
    //    {
    //        amount = Convert.ToDecimal(Math.Round(Convert.ToDecimal(displayText) / AppliedMultiplier, myRounding));
    //    }
    //    catch
    //    {
    //        return ComponentValue;
    //    }

    //    if ((Min != null && amount < Min) || (Max != null && amount > Max))
    //    {
    //        return ComponentValue;
    //    }

    //    return amount;
    //}
}
