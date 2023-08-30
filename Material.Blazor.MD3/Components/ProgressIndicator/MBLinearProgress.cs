using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor linear progress indicator.
/// </summary>
public sealed class MBLinearProgress : InternalProgressBase
{
    private protected override string WebComponentName()
    {
        return "md-linear-progress";
    }
}
