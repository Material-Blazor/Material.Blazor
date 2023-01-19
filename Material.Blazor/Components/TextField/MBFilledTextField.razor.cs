using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor filled text field.
/// </summary>
public sealed class MBFilledTextField : InternalTextFieldBase
{
    private protected override string ComponentName()
    {
        return "md-filled-text-field";
    }
}
