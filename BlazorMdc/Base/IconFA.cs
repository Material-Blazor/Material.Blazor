using System.Collections.Generic;

namespace BlazorMdc
{
    /// <summary>
    /// Font Awesome icon.
    /// </summary>
    internal class IconFA : IMdcIcon
    {
        /// <inheritdoc />
        public string Class => $"fa{IconStyleText} {IconNameText}";


        /// <inheritdoc />
        public string Text => "";

        
        private readonly Dictionary<string, object> _attributes = new Dictionary<string, object>();
        /// <inheritdoc />
        public IDictionary<string, object> Attributes => _attributes;


        /// <inheritdoc />
        public string IconName { get; }


        /// <inheritdoc />
        public bool RequiresColorFilter => false;


        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public MdcIconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public MdcIconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
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
        public IconFA(MdcCascadingDefaults cascadingDefaults, string iconName, IconFoundryFA? foundry = null)
        {
            IconName = iconName;
            Style = cascadingDefaults.AppliedIconFAStyle(foundry?.Style);
            RelativeSize = cascadingDefaults.AppliedIconFARelativeSize(foundry?.RelativeSize);
        }
#nullable restore annotations
    }
}
