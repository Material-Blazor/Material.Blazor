using System.Collections.Generic;

namespace BlazorMdc
{
    /// <summary>
    /// Material Icons icon.
    /// </summary>
    internal class IconMI : IMTIcon
    {
        /// <inheritdoc />
        public string Class
        {
            get
            {
                return "material-icons" + Theme switch
                {
                    IconMITheme.Filled => "",
                    IconMITheme.Outlined => "-outlined",
                    IconMITheme.Round => "-round",
                    IconMITheme.TwoTone => "-two-tone",
                    IconMITheme.Sharp => "-sharp",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


        /// <inheritdoc />
        public string Text => IconName.ToLower();

        
        private readonly Dictionary<string, object> _attributes = new Dictionary<string, object>();
        /// <inheritdoc />
        public IDictionary<string, object> Attributes => _attributes;


        /// <inheritdoc />
        public string IconName { get; }


        /// <inheritdoc />
        public bool RequiresColorFilter => Theme == IconMITheme.TwoTone;


        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public IconMITheme Theme { get; }


#nullable enable annotations
        public IconMI(MTCascadingDefaults cascadingDefaults, string iconName, IconFoundryMI? foundry = null)
        {
            IconName = iconName;
            Theme = cascadingDefaults.AppliedIconMITheme(foundry?.Theme);
        }
#nullable restore annotations
    }
}
