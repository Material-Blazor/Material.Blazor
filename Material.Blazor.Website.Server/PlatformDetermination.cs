﻿namespace Material.Blazor.Website.Server;

/// <summary>
/// A class that determines the current platform:
///     Blazor Server or WebAssembly.
///     MD2 or MD3
/// </summary>
public static class PlatformDetermination
{
#if BLAZOR_SERVER
    /// <summary>
    /// We are running Blazor Server.
    /// </summary>
    public const bool IsBlazorServer = true;
    public const bool IsBlazorWebAssembly = false;
#else
    /// <summary>
    /// We are running Blazor WebAssembly.
    /// </summary>
    public const bool IsBlazorServer = false;
    public const bool IsBlazorWebAssembly = true;
#endif
}
