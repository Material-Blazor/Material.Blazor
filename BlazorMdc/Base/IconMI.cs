using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    internal class IconMI : IMdcIcon
    {
        public string Class
        {
            get
            {
                return "material-icons" + CascadingDefaults.AppliedIconMITheme(Theme) switch
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

        public string IconName { get; }

        public bool RequiresWhiteFilter => CascadingDefaults.AppliedIconMITheme(Theme) == MdcIconMITheme.TwoTone;

        public MdcIconMITheme? Theme { get; }


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


#nullable enable annotations
        public IconMI(string iconName, IconFoundryMI? foundry = null)
        {
            IconName = iconName;
            Theme = foundry?.Theme;
        }
#nullable restore annotations
    }
}
