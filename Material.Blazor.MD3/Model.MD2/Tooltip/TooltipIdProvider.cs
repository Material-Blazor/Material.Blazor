using System.Threading;

namespace Material.Blazor.Internal;

/// <summary>
/// Unique identifiers are necessary for tooltips.
/// To guarantee order, we use a <see cref="long"/> instead of e.g. <see cref="System.Guid"/>.
/// To avoid duplicate IDs, we use a static counter which we increment atomically.
/// </summary>
internal static class TooltipIdProvider
{
    private static long Current;
    /// <summary>
    /// Get a unique ID for use with Tooltips.
    /// </summary>
    /// <returns></returns>
    public static long NextId() => Interlocked.Increment(ref Current);
}
