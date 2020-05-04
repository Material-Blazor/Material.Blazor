using System.Runtime.InteropServices;

namespace BlazorMdc.Demo
{
    public partial class Index
    {
        readonly string runtime;
        readonly string mode;
        
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
            runtime = RuntimeInformation.FrameworkDescription.ToString();
        }
    }
}
