using Material.Blazor.Internal;
using System;

namespace Material.Blazor.Internal;

/// <summary>
/// A Material Theme numeric input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>
public abstract class InternalIntFieldBase2<U> : InternalNumericFieldBase2<int, U>
    where U : InternalTextFieldBase2
{
    private protected override int ConvertToNumericValue(string displayText)
    {
        if (!Regex.IsMatch(displayText))
        {
            return Value;
        }

        if (!decimal.TryParse(displayText, out var decimalValue))
        {
            return Value;
        }

        var result = Convert.ToInt32(Math.Round(decimalValue, 0));

        return (Min != null && decimalValue < Min) || (Max != null && decimalValue > Max) ? Value : result;
    }


    private protected override string ConvertToFormattedTextValue(int value)
    {
        var format = NumericSingularFormat is not null && Math.Abs(Value) == 1
            ? NumericSingularFormat
            : NumericFormat;

        return value.ToString(format);
    }


    private protected override string ConvertToUnformattedTextValue(int value)
    {
        return value.ToString();
    }
}
