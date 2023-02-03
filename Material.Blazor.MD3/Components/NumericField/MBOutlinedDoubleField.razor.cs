using Material.Blazor.Internal;
using System;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor outlined style formatted decimal field.
/// </summary>
public sealed class MBOutlinedDoubleField : InternalFloatingPointFieldBase<double, MBOutlinedTextField>
{
    private protected override double ConvertFromDecimal(decimal decimalValue)
    {
        return Convert.ToDouble(decimalValue);
    }
}
