using Material.Blazor.Internal;

using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// Open Iconic icon.
    /// </summary>
    internal class IconOI : IMBIcon
    {
        /// <inheritdoc />
        public string Class => "oi";


        /// <inheritdoc />
        public string Text => "";


        private readonly Dictionary<string, object> _attributes;
        /// <inheritdoc />
        public IDictionary<string, object> Attributes => _attributes;


        /// <inheritdoc />
        public string IconName { get; }


        /// <inheritdoc />
        public bool RequiresColorFilter => false;


#nullable enable annotations
#pragma warning disable IDE0060 // Remove unused parameter
        public IconOI(MBCascadingDefaults cascadingDefaults, string iconName, IconFoundryOI? foundry = null)
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
