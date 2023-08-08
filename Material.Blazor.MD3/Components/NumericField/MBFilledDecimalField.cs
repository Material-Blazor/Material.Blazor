using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor filled style formatted decimal field.
/// </summary>
public sealed class MBFilledDecimalField : InternalFloatingPointFieldBase<decimal, MBFilledTextField>
{
    private protected override decimal ConvertFromDecimal(decimal decimalValue)
    {
        return decimalValue;
    }
}
