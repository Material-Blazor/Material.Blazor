using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    internal class Icon : IIconBase
    {
        public string Class => UnderlyingIcon.Class;

        public string Text => UnderlyingIcon.Text;

        public string IconName => UnderlyingIcon.IconName;


        private readonly IIconBase UnderlyingIcon;


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        public Icon(string iconName, ulong? foundrySpecification = null)
        {
            MdcIconFoundry iconFoundry = (foundrySpecification is null) ? CascadingDefaults.IconFoundry : (MdcIconFoundry)(foundrySpecification & IconMasks.IconFoundry);

            UnderlyingIcon = iconFoundry switch
            {
                MdcIconFoundry.MaterialIcons => new IconMI(iconName, foundrySpecification),
                MdcIconFoundry.FontAwesome => new IconFA(iconName, foundrySpecification),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
