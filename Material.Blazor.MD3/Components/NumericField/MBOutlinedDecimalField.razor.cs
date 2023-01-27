using Material.Blazor.Internal.MD3;

namespace Material.Blazor.MD3;

/// <summary>
/// A Material.Blazor outlined style formatted decimal field.
/// </summary>
public sealed class MBOutlinedDecimalField : InternalFloatingPointFieldBase<decimal, MBOutLinedTextField>
{
    private protected override decimal ConvertFromDecimal(decimal decimalValue)
    {
        return decimalValue;
    }
}
