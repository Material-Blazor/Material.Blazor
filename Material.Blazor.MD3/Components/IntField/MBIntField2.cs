using Material.Blazor.Internal;

using System;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor formatted integer field.
/// </summary>
public sealed class MBIntField2 : InternalNumericFieldBase<int>
{
    #region ConvertToFormattedTextValue

    private protected override string ConvertToFormattedTextValue(int value)
    {
        var format = NumericSingularFormat is not null && Math.Abs(Value) == 1
            ? NumericSingularFormat
            : NumericFormat;

        return value.ToString(format);
    }

    #endregion

    #region ConvertToNumericValue

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

    #endregion

    #region ConvertToUnformattedTextValue

    private protected override string ConvertToUnformattedTextValue(int value)
    {
        return value.ToString();
    }

    #endregion

}
