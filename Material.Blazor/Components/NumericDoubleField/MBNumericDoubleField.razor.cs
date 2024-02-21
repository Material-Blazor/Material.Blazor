﻿using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// An double variant of <see cref="MBNumericDecimalField"/>.
/// </summary>
public partial class MBNumericDoubleField : InputComponent<double>
{
#nullable enable annotations
    /// <summary>
    /// Helper text that is displayed either with focus or persistently with <see cref="HelperTextPersistent"/>.
    /// </summary>
    [Parameter] public string HelperText { get; set; } = "";


    /// <summary>
    /// Makes the <see cref="HelperText"/> persistent if true.
    /// </summary>
    [Parameter] public bool HelperTextPersistent { get; set; } = false;


    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }


    /// <summary>
    /// The text input style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
    /// </summary>
    [Parameter] public MBTextInputStyle? TextInputStyle { get; set; }


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
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


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
    /// Adjusts the value's maginitude as a number when the field is focused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved.
    /// </summary>
    [Parameter] public MBNumericInputMagnitude FocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;


    /// <summary>
    /// Adjusts the value's maginitude as a number when the field is unfocused. Used for
    /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
    /// this issue may not get solved.
    /// </summary>
    [Parameter] public MBNumericInputMagnitude UnfocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;


    /// <summary>
    /// The minimum allowable value.
    /// </summary>
    [Parameter] public double? Min { get; set; }


    /// <summary>
    /// The maximum allowable value.
    /// </summary>
    [Parameter] public double? Max { get; set; }


    /// <summary>
    /// Number of decimal places for the value. If more dp are entered the value gets rounded properly.
    /// </summary>
    [Parameter] public uint DecimalPlaces { get; set; } = 2;
#nullable restore annotations


    private int Rounding => (int)DecimalPlaces + Convert.ToInt32(Math.Log(Convert.ToDouble(Math.Pow(10, (int)FocusedMagnitude))));
    private MBNumericDecimalField DecimalField { get; set; }


    private decimal DecimalValue
    {
        get => (decimal)ComponentValue;
        set => ComponentValue = Convert.ToDouble(Math.Round(value, Rounding));
    }


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

        set
        {
            if (value == null)
            {
                Min = null;
            }

            Min = Convert.ToDouble(Math.Round(value ?? 0, (int)DecimalPlaces));
        }
    }


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

        set
        {
            if (value == null)
            {
                Max = null;
            }

            Max = Convert.ToDouble(Math.Round(value ?? 0, (int)DecimalPlaces));
        }
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        AllowAllRenders();
    }


    /// <summary>
    /// Returns an <see cref="ElementReference"/> for the control's input element.
    /// </summary>
    /// <returns></returns>
    public ElementReference GetInputReference()
    {
        return DecimalField.GetInputReference();
    }
}
