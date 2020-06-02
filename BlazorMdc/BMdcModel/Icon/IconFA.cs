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
        public eIconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public eIconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    eIconFARelativeSize.Regular => "",
                    eIconFARelativeSize.ExtraSmall => " fa-xs",
                    eIconFARelativeSize.Small => " fa-sm",
                    eIconFARelativeSize.Large => " fa-lg",
                    eIconFARelativeSize.TwoTimes => " fa-2x",
                    eIconFARelativeSize.ThreeTimes => " fa-3x",
                    eIconFARelativeSize.FiveTimes => " fa-5x",
                    eIconFARelativeSize.SevenTimes => " fa-7x",
                    eIconFARelativeSize.TenTimes => " fa-10x",
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
