﻿using Material.Blazor.Internal.MD3;

namespace Material.Blazor.MD3;

/// <summary>
/// A Material.Blazor filled text field.
/// </summary>
public sealed class MBFilledTextField : InternalTextFieldBase
{
    private protected override string WebComponentName()
    {
        return "md-filled-text-field";
    }
}
