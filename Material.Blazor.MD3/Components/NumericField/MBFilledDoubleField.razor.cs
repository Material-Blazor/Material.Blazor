using Material.Blazor.Internal;
using System;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor filled style formatted double field.
/// </summary>
public sealed class MBFilledDoubleField : InternalFloatingPointFieldBase<double, MBFilledTextField>
{
    private protected override double ConvertFromDecimal(decimal decimalValue)
    {
        return Convert.ToDouble(decimalValue);
    }
}
