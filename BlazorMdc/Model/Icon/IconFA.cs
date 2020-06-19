using System.Collections.Generic;

namespace BlazorMdc.Internal
{
    /// <summary>
    /// Font Awesome icon.
    /// </summary>
    internal class IconFA : IMTIcon
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
        public IconFAStyle Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public IconFARelativeSize RelativeSize { get; }


        private string IconStyleText => Style.ToString().Substring(0, 1).ToLower();

        private string IconNameText
        {
            get
            {
                return IconName.ToLower() + RelativeSize switch
                {
                    IconFARelativeSize.Regular => "",
                    IconFARelativeSize.ExtraSmall => " fa-xs",
                    IconFARelativeSize.Small => " fa-sm",
                    IconFARelativeSize.Large => " fa-lg",
                    IconFARelativeSize.TwoTimes => " fa-2x",
                    IconFARelativeSize.ThreeTimes => " fa-3x",
                    IconFARelativeSize.FiveTimes => " fa-5x",
                    IconFARelativeSize.SevenTimes => " fa-7x",
                    IconFARelativeSize.TenTimes => " fa-10x",
                    _ => throw new System.NotImplementedException(),
                };
            }
        }


#nullable enable annotations
        public IconFA(MTCascadingDefaults cascadingDefaults, string iconName, MTIconFoundryFA? foundry = null)
        {
            IconName = iconName;
            Style = cascadingDefaults.AppliedIconFAStyle(foundry?.Style);
            RelativeSize = cascadingDefaults.AppliedIconFARelativeSize(foundry?.RelativeSize);
        }
#nullable restore annotations
    }
}
