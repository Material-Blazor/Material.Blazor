using System.Collections.Generic;

namespace BModel
{
    /// <summary>
    /// Material Icons icon.
    /// </summary>
    internal class IconMI : BModel.IIcon
    {
        /// <inheritdoc />
        public string Class
        {
            get
            {
                return "material-icons" + Theme switch
                {
                    BEnum.IconMITheme.Filled => "",
                    BEnum.IconMITheme.Outlined => "-outlined",
                    BEnum.IconMITheme.Round => "-round",
                    BEnum.IconMITheme.TwoTone => "-two-tone",
                    BEnum.IconMITheme.Sharp => "-sharp",
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
        public bool RequiresColorFilter => Theme == BEnum.IconMITheme.TwoTone;


        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public BEnum.IconMITheme Theme { get; }


#nullable enable annotations
        public IconMI(CascadingDefaults cascadingDefaults, string iconName, IconFoundryMI? foundry = null)
        {
            IconName = iconName;
            Theme = cascadingDefaults.AppliedIconMITheme(foundry?.Theme);
        }
#nullable restore annotations
    }
}
