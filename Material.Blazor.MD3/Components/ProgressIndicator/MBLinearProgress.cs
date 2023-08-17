using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor outlined text field.
/// </summary>
public sealed class MBLinearProgress : InternalProgressBase
{
    private protected override string WebComponentName()
    {
        return "md-linear-progress";
    }
}
