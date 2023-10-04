using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor formatted decimal field.
/// </summary>
public sealed class MBDecimalField : InternalFloatingPointFieldBase<decimal, MBTextField>
{
    private protected override decimal ConvertFromDecimal(decimal decimalValue)
    {
        return decimalValue;
    }
}
