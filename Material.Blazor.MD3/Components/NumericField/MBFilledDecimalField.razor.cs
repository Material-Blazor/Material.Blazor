using Material.Blazor.Internal.MD3;

namespace Material.Blazor.MD3;

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
