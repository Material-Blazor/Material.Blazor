using Material.Blazor.Internal;

namespace Material.Blazor;

/// <summary>
/// A Material.Blazor circular progress indicator.
/// </summary>
public sealed class MBCircularProgress : InternalProgressBase

{
    private protected override string WebComponentName()
    {
        return "md-circular-progress";
    }
}
