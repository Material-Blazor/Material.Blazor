using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    public class MdcIconHelper : IMdcIcon
    {
        public string Class => UnderlyingIcon.Class;

        public string Text => UnderlyingIcon.Text;

        public IDictionary<string, object> Attributes => UnderlyingIcon.Attributes;

        public string IconName => UnderlyingIcon.IconName;

        public bool RequiresWhiteFilter => UnderlyingIcon.RequiresWhiteFilter;


        private readonly IMdcIcon UnderlyingIcon;


        public static IMdcIconFoundry MIFoundry(MdcIconMITheme? theme = null) => new IconFoundryMI(theme);
        public static IMdcIconFoundry FAFoundry(MdcIconFAStyle? style = null, MdcIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);
        public static IMdcIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        public MdcIconHelper(MdcCascadingDefaults cascadingDefaults, string iconName, IMdcIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new MdcCascadingDefaults();
            }

            MdcIconFoundryName iconFoundry = (foundry is null) ? cascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                MdcIconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                MdcIconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                MdcIconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
