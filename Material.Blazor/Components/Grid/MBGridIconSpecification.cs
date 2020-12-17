using System.Drawing;

namespace Material.Blazor
{
    public class MBGridIconSpecification
    {
        public Color IconColor { get; set; }
#nullable enable annotations
        public IMBIconFoundry? IconFoundry { get; set; } = null;
#nullable restore annotations
        public string IconName { get; set; }
    }
}
