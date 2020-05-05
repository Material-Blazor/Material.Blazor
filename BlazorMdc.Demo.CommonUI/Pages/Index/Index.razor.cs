using System.Runtime.InteropServices;

namespace BlazorMdc.Demo
{
    public partial class Index
    {
#if DEBUG
        private const string mode = "debug";
#else
        private const string mode = "release";
#endif    
        
        private readonly string runtime;
        
        public Index()
        {
            runtime = RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY"))
                ? $"Mono WebAssembly"
                : $".NET Core";
            runtime = RuntimeInformation.FrameworkDescription.ToString();
        }
    }
}
