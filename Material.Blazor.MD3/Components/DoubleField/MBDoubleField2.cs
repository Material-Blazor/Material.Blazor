using Material.Blazor.Internal;
using System;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor formatted double field.
/// </summary>
public sealed class MBDoubleField : InternalFloatingPointFieldBase<double>
{
    private protected override double ConvertFromDecimal(decimal decimalValue)
    {
        return Convert.ToDouble(decimalValue);
    }
}
