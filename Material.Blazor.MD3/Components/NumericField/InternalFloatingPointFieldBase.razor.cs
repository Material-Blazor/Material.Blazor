using Microsoft.AspNetCore.Components;
using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Material.Blazor.Internal;

/// <summary>
/// A Material Theme numeric input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>
public abstract class InternalFloatingPointFieldBase<T, U> : InternalNumericFieldBase<T, U>
    where T : struct, IFloatingPoint<T>
    where U : InternalTextFieldBase
{
    /// <summary>
    /// Adjusts the value's magnitude as a number when the field is focused. Used for
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
    /// Number of decimal places for the value. If more dp are entered the value gets rounded properly.
    /// </summary>
    [Parameter] public uint DecimalPlaces { get; set; } = 2;


    /// <summary>
    /// Converts a decimal value to type T.
    /// </summary>
    /// <param name="decimalValue"></param>
    /// <returns></returns>
    private protected abstract T ConvertFromDecimal(decimal decimalValue);


    /// <summary>
    /// Returns the Multiplier required given focused/unfocused magnitude as applicable.
    /// </summary>
    /// <returns></returns>
    private protected decimal GetMultiplier()
    {
        return Convert.ToDecimal(Math.Pow(10, (int)(HasFocus ? GetFocusedMagnitude() : GetUnfocusedMagnitude())));
    }


    /// <summary>
    /// Returns rounding required for conversion from a string value.
    /// </summary>
    /// <returns></returns>
    private protected int GetRounding()
    {
        return GetDecimalPlaces() + Convert.ToInt32(Math.Log(Convert.ToDouble(GetMultiplier())));
    }


    private protected override string BuildStep()
    {
        return Math.Pow(10, -(int)DecimalPlaces).ToString();
    }


    private protected override MBNumericInputMagnitude GetFocusedMagnitude()
    {
        return FocusedMagnitude;
    }


    private protected override MBNumericInputMagnitude GetUnfocusedMagnitude()
    {
        return UnfocusedMagnitude;
    }


    private protected override int GetDecimalPlaces()
    {
        return (int)DecimalPlaces;
    }


    private protected override T ConvertToNumericValue(string displayText)
    {
        if (!Regex.IsMatch(displayText))
        {
            return Value;
        }

        if (!decimal.TryParse(displayText, out var result))
        {
            return Value;
        }

        result = Math.Round(result / GetMultiplier(), GetRounding());

        return (Min != null && result < Convert.ToDecimal(Min)) || (Max != null && result > Convert.ToDecimal(Max)) ? Value : ConvertFromDecimal(result);
    }


    private protected override string ConvertToFormattedTextValue(T value)
    {
        var format = NumericSingularFormat is not null && Utilities.DecimalEqual(Math.Abs(Convert.ToDecimal(Value)), 1)
            ? NumericSingularFormat
            : NumericFormat;

        return (Convert.ToDecimal(value) * GetMultiplier()).ToString(format);
    }


    private protected override string ConvertToUnformattedTextValue(T value)
    {
        return Math.Round(Convert.ToDecimal(value) * GetMultiplier(), GetDecimalPlaces()).ToString();
    }
}
