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
                    MTIconMITheme.Filled => "",
                    MTIconMITheme.Outlined => "-outlined",
                    MTIconMITheme.Round => "-round",
                    MTIconMITheme.TwoTone => "-two-tone",
                    MTIconMITheme.Sharp => "-sharp",
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
        public bool RequiresColorFilter => Theme == MTIconMITheme.TwoTone;


        /// <summary>
        /// The Material Icons theme.
        /// <para>Overrides <see cref="MTCascadingDefaults.IconMITheme"/></para>
        /// </summary>
        public MTIconMITheme Theme { get; }


#nullable enable annotations
        public IconMI(MTCascadingDefaults cascadingDefaults, string iconName, IconFoundryMI? foundry = null)
        {
            IconName = iconName;
            Theme = cascadingDefaults.AppliedIconMITheme(foundry?.Theme);
        }
#nullable restore annotations
    }
}
