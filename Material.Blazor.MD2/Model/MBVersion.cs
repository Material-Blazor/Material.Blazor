using System;
using System.Reflection;

namespace Material.Blazor.MD2;

public static class MBVersion
{
    /// <summary>
    /// Returns a string with the value of the InformationalVersion
    /// </summary>
    /// <returns></returns>
    public static string MaterialBlazorVersion()
    {
        return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion.Split('+')[0];
    }
}
