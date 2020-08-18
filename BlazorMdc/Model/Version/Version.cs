using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BlazorMdc.Model
{
    public class Version
    {
        public string GetBlazorMdcVersion()
        {
            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}
