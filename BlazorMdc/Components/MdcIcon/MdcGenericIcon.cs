using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    public class MdcGenericIcon : IMdcIconBase
    {
        public string Class => UnderlyingIcon.Class;

        public string Text => UnderlyingIcon.Text;

        public string IconName { get; set; }


        public MdcMCIcon MCIcon { get; set; }

        public MdcFAIcon FAIcon { get; set; }


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        public static implicit operator MdcGenericIcon(string iconName) => new MdcGenericIcon(iconName);
        public static implicit operator MdcGenericIcon(MdcMCIcon mcIcon) => new MdcGenericIcon(mcIcon);
        public static implicit operator MdcGenericIcon(MdcFAIcon faIcon) => new MdcGenericIcon(faIcon);



        private IMdcIconBase UnderlyingIcon
        {
            get
            {
                if (MCIcon != null)
                {
                    return MCIcon;
                }

                if (FAIcon != null)
                {
                    return FAIcon;
                }

                return CascadingDefaults.IconFoundry switch
                {
                    MdcIconFoundry.MaterialComponents => new MdcMCIcon(IconName),
                    MdcIconFoundry.FontAwesome => new MdcFAIcon(IconName),
                    _ => throw new NotImplementedException(),
                };
            }
        }



        public MdcGenericIcon() { }

        public MdcGenericIcon(string iconName)
        {
            IconName = iconName;
        }

        public MdcGenericIcon(MdcMCIcon mcIcon)
        {
            MCIcon = mcIcon;
        }

        public MdcGenericIcon(MdcFAIcon faIcon)
        {
            FAIcon = faIcon;
        }
    }
}
