using System.Collections.Generic;

namespace BMdcModel
{
    /// <summary>
    /// Font Awesome icon.
    /// </summary>
    internal class IconFA : IIcon
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
        public EIconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public EIconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    EIconFARelativeSize.Regular => "",
                    EIconFARelativeSize.ExtraSmall => " fa-xs",
                    EIconFARelativeSize.Small => " fa-sm",
                    EIconFARelativeSize.Large => " fa-lg",
                    EIconFARelativeSize.TwoTimes => " fa-2x",
                    EIconFARelativeSize.ThreeTimes => " fa-3x",
                    EIconFARelativeSize.FiveTimes => " fa-5x",
                    EIconFARelativeSize.SevenTimes => " fa-7x",
                    EIconFARelativeSize.TenTimes => " fa-10x",
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
