using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    public class MdcIcon : IMdcIconBase
    {
        public string Class => UnderlyingIcon.Class;

        public string Text => UnderlyingIcon.Text;

        public string IconName => UnderlyingIcon.IconName;


        private readonly IMdcIconBase UnderlyingIcon;


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        public static implicit operator MdcIcon(string iconName) => new MdcIcon(iconName);
        public static IMdcIconFoundry MIFoundry(MdcIconMITheme? theme = null) => new IconFoundryMI(theme);
        public static IMdcIconFoundry FAFoundry(MdcIconFAStyle? style = null, MdcIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


#nullable enable annotations
        internal MdcIcon(string iconName, IMdcIconFoundry? foundry = null)
        {
            MdcIconFoundryName iconFoundry = (foundry is null) ? CascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                MdcIconFoundryName.MaterialIcons => new IconMI(iconName, (IconFoundryMI?)foundry),
                MdcIconFoundryName.FontAwesome => new IconFA(iconName, (IconFoundryFA?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
