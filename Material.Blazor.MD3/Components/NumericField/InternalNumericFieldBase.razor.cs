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
public abstract class InternalNumericFieldBase<T, U> : InputComponent<T> 
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


    private bool SelectInputContentOnAfterRender { get; set; } = false;
    private U TextField { get; set; }


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

        Regex = GetDecimalPlaces() == 0
            ? new Regex(allowSign ? IntegerPattern : PositiveIntegerPattern)
            : new Regex(allowSign ? DoublePattern : PositiveDoublePattern);
    }

    
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
            var stringValue = HasFocus? ConvertToUnformattedTextValue(Value) : ConvertToFormattedTextValue(Value);
            builder.AddAttribute(9, "ValueExpression", RuntimeHelpers.TypeCheck<Expression<Func<string>>>(() => stringValue));

            builder.AddAttribute(10, "onfocusin", EventCallback.Factory.Create<FocusEventArgs>(this, OnFocusInAsync));
            builder.AddAttribute(11, "onfocusout", EventCallback.Factory.Create<FocusEventArgs>(this, OnFocusOutAsync));

            //if (AppliedDisabled)
            //{
            //    builder.AddAttribute(12, "Disabled");
            //}

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

            builder.AddComponentReferenceCapture(18, __value => TextField = (U)__value);
        }
        builder.CloseComponent();
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender).ConfigureAwait(false);

        if (SelectInputContentOnAfterRender)
        {
            SelectInputContentOnAfterRender = false;

            await TextField.SelectFieldContent();
        }
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
}
