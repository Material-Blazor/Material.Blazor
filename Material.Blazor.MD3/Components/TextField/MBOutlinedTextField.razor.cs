using Material.Blazor.Internal.MD3;

namespace Material.Blazor.MD3;

/// <summary>
/// A Material.Blazor outlined text field.
/// </summary>
public sealed class MBOutLinedTextField : InternalTextFieldBase
{
    private protected override string WebComponentName()
    {
        return "md-outlined-text-field";
    }
}
