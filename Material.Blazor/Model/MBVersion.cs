using System.Reflection;

namespace Material.Blazor
{
    public static class MBVersion
    {
        /// <summary>
        /// Returns a string with the value of the InformationalVersion
        /// </summary>
        /// <returns></returns>
        public static string MaterialBlazorVersion()
        {
            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}
