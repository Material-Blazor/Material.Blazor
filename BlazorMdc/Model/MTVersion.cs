using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BlazorMdc.Model
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
