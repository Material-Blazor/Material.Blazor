using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    internal class IconFA : IIconBase
    {
        public string Class => $"fa{IconStyleText} {IconNameText}";

        public string Text => "";

        public string IconName { get; }

        public MdcFAIconStyle? IconStyle { get; }

        public MdcFAIconRelativeSize? IconRelativeSize { get; }


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        private string IconStyleText => CascadingDefaults.AppliedFAIconStyle(IconStyle).ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + CascadingDefaults.AppliedFAIconRelativeSize(IconRelativeSize) switch
                {
                    MdcFAIconRelativeSize.Regular => "",
                    MdcFAIconRelativeSize.ExtraSmall => " fa-xs",
                    MdcFAIconRelativeSize.Small => " fa-sm",
                    MdcFAIconRelativeSize.Large => " fa-lg",
                    MdcFAIconRelativeSize.TwoTimes => " fa-2x",
                    MdcFAIconRelativeSize.ThreeTimes => " fa-3x",
                    MdcFAIconRelativeSize.FiveTimes => " fa-5x",
                    MdcFAIconRelativeSize.SevenTimes => " fa-7x",
                    MdcFAIconRelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }



        public IconFA(string iconName, ulong? foundrySpecification = null)
        {
            IconName = iconName;

            if (foundrySpecification is null) return;

            var localSpec = (ulong)foundrySpecification & (IconMasks.IconFoundry | IconMasks.FAIconStyle | IconMasks.FAIconRelativeSize);

            if (localSpec != foundrySpecification)
            {
                throw new ArgumentException("Invalid foundrySpecification provided for a Fornt Awesome Icon");
            }

            var style = localSpec & IconMasks.FAIconStyle;
            var relativeSize = localSpec & IconMasks.FAIconRelativeSize;

            if (style > 0) IconStyle = (MdcFAIconStyle)style;
            if (relativeSize > 0) IconRelativeSize = (MdcFAIconRelativeSize)relativeSize;
        }
    }
}
