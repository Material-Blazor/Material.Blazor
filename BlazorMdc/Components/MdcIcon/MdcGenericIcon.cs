using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    public class MdcGenericIcon : IMdcIconBase
    {
        public string Class => UnderlyingIcon.Class;

        public string Text => UnderlyingIcon.Text;

        public string IconName { get; set; }


        public MdcMIIcon MIIcon { get; set; }

        public MdcFAIcon FAIcon { get; set; }


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        public static implicit operator MdcGenericIcon(string iconName) => new MdcGenericIcon(iconName);
        public static implicit operator MdcGenericIcon(MdcMIIcon mcIcon) => new MdcGenericIcon(mcIcon);
        public static implicit operator MdcGenericIcon(MdcFAIcon faIcon) => new MdcGenericIcon(faIcon);



        private IMdcIconBase UnderlyingIcon
        {
            get
            {
                if (MIIcon != null)
                {
                    return MIIcon;
                }

                if (FAIcon != null)
                {
                    return FAIcon;
                }

                return CascadingDefaults.IconFoundry switch
                {
                    MdcIconFoundry.MaterialIcons => new MdcMIIcon(IconName),
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

        public MdcGenericIcon(MdcMIIcon mcIcon)
        {
            MIIcon = mcIcon;
        }

        public MdcGenericIcon(MdcFAIcon faIcon)
        {
            FAIcon = faIcon;
        }
    }
}
