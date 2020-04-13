using System.Runtime.InteropServices;

namespace BlazorMdc.Demo
{
    public partial class Index
    {
        string runtime = RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY"))
            ? "Mono WebAssembly"
            : ".NET Core";

        string mode;
        public Index()
        {
#if DEBUG
        mode = "debug";
#else
        mode = "release";
#endif
        }
    }
}
