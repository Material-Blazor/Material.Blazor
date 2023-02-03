using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor outlined style formatted decimal field.
/// </summary>
public sealed class MBOutlinedDecimalField : InternalFloatingPointFieldBase<decimal, MBOutlinedTextField>
{
    private protected override decimal ConvertFromDecimal(decimal decimalValue)
    {
        return decimalValue;
    }
}
