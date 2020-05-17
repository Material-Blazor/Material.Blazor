using System.Collections.Generic;

namespace BlazorMdc
{
    /// <summary>
    /// Material Icons icon.
    /// </summary>
    internal class IconMI : IMdcIcon
    {
        /// <inheritdoc />
        public string Class
        {
            get
            {
                return "material-icons" + Theme switch
                {
                    MdcIconMITheme.Filled => "",
                    MdcIconMITheme.Outlined => "-outlined",
                    MdcIconMITheme.Round => "-round",
                    MdcIconMITheme.TwoTone => "-two-tone",
                    MdcIconMITheme.Sharp => "-sharp",
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
        public bool RequiresColorFilter => Theme == MdcIconMITheme.TwoTone;


        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public MdcIconMITheme Theme { get; }


#nullable enable annotations
        public IconMI(MdcCascadingDefaults cascadingDefaults, string iconName, IconFoundryMI? foundry = null)
        {
            IconName = iconName;
            Theme = cascadingDefaults.AppliedIconMITheme(foundry?.Theme);
        }
#nullable restore annotations
    }
}
