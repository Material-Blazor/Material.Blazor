using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    internal class IconFA : IMdcIcon
    {
        public string Class => $"fa{IconStyleText} {IconNameText}";

        public string Text => "";

        public string IconName { get; }

        public bool RequiresWhiteFilter => false;

        public MdcIconFAStyle? Style { get; }

        public MdcIconFARelativeSize? RelativeSize { get; }


        [CascadingParameter] protected MdcCascadingDefaults CascadingDefaults { get; set; } = new MdcCascadingDefaults();


        private string IconStyleText => CascadingDefaults.AppliedIconFAStyle(Style).ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + CascadingDefaults.AppliedIconFARelativeSize(RelativeSize) switch
                {
                    MdcIconFARelativeSize.Regular => "",
                    MdcIconFARelativeSize.ExtraSmall => " fa-xs",
                    MdcIconFARelativeSize.Small => " fa-sm",
                    MdcIconFARelativeSize.Large => " fa-lg",
                    MdcIconFARelativeSize.TwoTimes => " fa-2x",
                    MdcIconFARelativeSize.ThreeTimes => " fa-3x",
                    MdcIconFARelativeSize.FiveTimes => " fa-5x",
                    MdcIconFARelativeSize.SevenTimes => " fa-7x",
                    MdcIconFARelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


#nullable enable annotations
        public IconFA(string iconName, IconFoundryFA? foundry = null)
        {
            IconName = iconName;
            Style = foundry?.Style;
            RelativeSize = foundry?.RelativeSize;
        }
#nullable restore annotations
    }
}
