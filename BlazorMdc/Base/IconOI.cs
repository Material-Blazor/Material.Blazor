using System.Collections.Generic;

namespace BlazorMdc
{
    internal class IconOI : IMdcIcon
    {
        public string Class => "oi";

        public string Text => "";

        private readonly Dictionary<string, object> _attributes;
        public IDictionary<string, object> Attributes => _attributes;

        public string IconName { get; }

        public bool RequiresWhiteFilter => false;


#nullable enable annotations
#pragma warning disable IDE0060 // Remove unused parameter
        public IconOI(MdcCascadingDefaults cascadingDefaults, string iconName, IconFoundryOI? foundry = null)
        {
            IconName = iconName;

            _attributes = new Dictionary<string, object>
            {
                { "data-glyph", iconName }
            };
        }
#pragma warning restore IDE0060 // Remove unused parameter
#nullable restore annotations
    }
}
