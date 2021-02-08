using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// Material Icons icon.
    /// </summary>
    internal class IconMI : IMBIcon
    {
        /// <inheritdoc />
        public string Class
        {
            get
            {
                return "material-icons" + Theme switch
                {
                    MBIconMITheme.Filled => "",
                    MBIconMITheme.Outlined => "-outlined",
                    MBIconMITheme.Round => "-round",
                    MBIconMITheme.TwoTone => "-two-tone",
                    MBIconMITheme.Sharp => "-sharp",
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
        public bool RequiresColorFilter => Theme == MBIconMITheme.TwoTone;


        /// <summary>
        /// The Material Icons theme.
        /// <para>Overrides <see cref="MBCascadingDefaults.IconMITheme"/></para>
        /// </summary>
        public MBIconMITheme Theme { get; }


#nullable enable annotations
        public IconMI(MBCascadingDefaults cascadingDefaults, string iconName, IconFoundryMI? foundry = null)
        {
            IconName = iconName;
            Theme = cascadingDefaults.AppliedIconMITheme(foundry?.Theme);
        }
#nullable restore annotations
    }
}
