using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor outlined text field.
/// </summary>
public sealed class MBOutLinedTextField : InternalTextFieldBase
{
    private protected override string ComponentName()
    {
        return "md-outlined-text-field";
    }
}
