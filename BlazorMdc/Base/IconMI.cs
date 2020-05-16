using System.Collections.Generic;

namespace BlazorMdc
{
    internal class IconMI : IMdcIcon
    {
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

        public string Text => IconName.ToLower();

        private readonly Dictionary<string, object> _attributes = new Dictionary<string, object>();
        public IDictionary<string, object> Attributes => _attributes; 
        
        public string IconName { get; }

        public bool RequiresWhiteFilter => Theme == MdcIconMITheme.TwoTone;

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
