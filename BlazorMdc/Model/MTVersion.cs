using System.Reflection;

namespace BlazorMdc
{
    public static class MTVersion
    {
        /// <summary>
        /// Returns a string with the value of the InformationalVersion
        /// </summary>
        /// <returns></returns>
        public static string BlazorMdcVersion()
        {
            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}
