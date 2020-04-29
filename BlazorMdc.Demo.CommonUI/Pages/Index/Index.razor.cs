using System.Runtime.InteropServices;

namespace BlazorMdc.Demo
{
    public partial class Index
    {
        string runtime;
        string mode;
        
        public Index()
        {
#if DEBUG
            mode = "debug";
#else
            mode = "release";
#endif
            runtime = RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY"))
            ? $"Mono WebAssembly {mode}"
            : $".NET Core - {mode}";
        }
    }
}
