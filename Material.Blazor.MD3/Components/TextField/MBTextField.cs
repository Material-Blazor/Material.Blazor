using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor text field.
/// </summary>
public sealed class MBTextField : InternalTextFieldBase
{
    private protected override string WebComponentName()
    {
        if (TextInputStyle == MBTextInputStyle.Outlined)
        {
            return "md-outlined-text-field";
        }
        else
        {
            return "md-filled-text-field";
        }

    }
}
