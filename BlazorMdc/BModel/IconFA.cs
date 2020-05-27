using System.Collections.Generic;

namespace BModel
{
    /// <summary>
    /// Font Awesome icon.
    /// </summary>
    internal class IconFA : BModel.IIcon
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
        public BEnum.IconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public BEnum.IconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    BEnum.IconFARelativeSize.Regular => "",
                    BEnum.IconFARelativeSize.ExtraSmall => " fa-xs",
                    BEnum.IconFARelativeSize.Small => " fa-sm",
                    BEnum.IconFARelativeSize.Large => " fa-lg",
                    BEnum.IconFARelativeSize.TwoTimes => " fa-2x",
                    BEnum.IconFARelativeSize.ThreeTimes => " fa-3x",
                    BEnum.IconFARelativeSize.FiveTimes => " fa-5x",
                    BEnum.IconFARelativeSize.SevenTimes => " fa-7x",
                    BEnum.IconFARelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


#nullable enable annotations
        public IconFA(CascadingDefaults cascadingDefaults, string iconName, IconFoundryFA? foundry = null)
        {
            IconName = iconName;
            Style = cascadingDefaults.AppliedIconFAStyle(foundry?.Style);
            RelativeSize = cascadingDefaults.AppliedIconFARelativeSize(foundry?.RelativeSize);
        }
#nullable restore annotations
    }
}
