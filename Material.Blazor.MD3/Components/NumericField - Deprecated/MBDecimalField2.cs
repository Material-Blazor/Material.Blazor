using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor formatted decimal field.
/// </summary>
public sealed class MBDecimalField2 : InternalFloatingPointFieldBase2<decimal, MBTextField2>
{
    private protected override decimal ConvertFromDecimal(decimal decimalValue)
    {
        return decimalValue;
    }
}
