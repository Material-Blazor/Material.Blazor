using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor filled style formatted decimal field.
/// </summary>
public sealed class MBDecimalField2 : InternalFloatingPointField2Base<decimal, MBTextField2>
{
    private protected override decimal ConvertFromDecimal(decimal decimalValue)
    {
        return decimalValue;
    }
}
