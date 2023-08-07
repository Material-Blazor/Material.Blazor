using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor outlined text field.
/// </summary>
public sealed class MBLinearProgressIndicator : InternalProgressIndicator
{
    private protected override string WebComponentName()
    {
        return "md-linear-progress";
    }
}
