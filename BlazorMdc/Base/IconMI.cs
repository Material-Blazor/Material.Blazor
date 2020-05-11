using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    internal class IconMI : IIconBase
    {
        public string Class
        {
            get
            {
                return "material-icons" + CascadingDefaults.AppliedMCIconTheme(IconTheme) switch
                {
                    MdcMIIconTheme.Filled => "",
                    MdcMIIconTheme.Outlined => "-outlined",
                    MdcMIIconTheme.Round => "-round",
                    MdcMIIconTheme.TwoTone => "-two-tone",
                    MdcMIIconTheme.Sharp => "-sharp",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }

        public string Text => IconName.ToLower();

        public string IconName { get; }

        public MdcMIIconTheme? IconTheme { get; }


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        public IconMI(string iconName, ulong? foundrySpecification = null)
        {
            IconName = iconName;

            if (foundrySpecification is null) return;

            var localSpec = (ulong)foundrySpecification & (IconMasks.IconFoundry | IconMasks.MIIconTheme);

            if (localSpec != foundrySpecification)
            {
                throw new ArgumentException("Invalid foundrySpecification provided for a Material Icon");
            }

            var theme = localSpec & IconMasks.MIIconTheme;

            if (theme > 0) IconTheme = (MdcMIIconTheme)theme;
        }
    }
}
