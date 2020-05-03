using System.Runtime.InteropServices;

namespace BlazorMdc.Demo
{
    public partial class Index
    {
        readonly string runtime;
        readonly string mode;
        readonly string osarchitecture;
        readonly string osdescription;
        readonly string processarchitecture;
        readonly string framework;
        
        public Index()
        {
#if DEBUG
            mode = "debug";
#else
            mode = "release";
#endif
            runtime = RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY"))
                ? $"Mono WebAssembly"
                : $".NET Core";

            framework = RuntimeInformation.FrameworkDescription.ToString();
            osarchitecture = RuntimeInformation.OSArchitecture.ToString();
            osdescription = RuntimeInformation.OSDescription.ToString();
            processarchitecture = RuntimeInformation.ProcessArchitecture.ToString();
        }
    }
}
