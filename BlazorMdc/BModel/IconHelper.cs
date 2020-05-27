using System;
using System.Collections.Generic;

namespace BModel
{
    /// <summary>
    /// A helper class for defining which foundry to use for an icon.
    /// </summary>
    public class IconHelper : IIcon
    {
        /// <inheritdoc/>
        public string Class => UnderlyingIcon.Class;


        /// <inheritdoc/>
        public string Text => UnderlyingIcon.Text;


        /// <inheritdoc/>
        public IDictionary<string, object> Attributes => UnderlyingIcon.Attributes;


        /// <inheritdoc/>
        public string IconName => UnderlyingIcon.IconName;


        /// <inheritdoc/>
        public bool RequiresColorFilter => UnderlyingIcon.RequiresColorFilter;


        private readonly IIcon UnderlyingIcon;


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Material Icons icon.
        /// </summary>
        /// <param name="theme">Optional <see cref="BEnum.IconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry MIFoundry(BEnum.IconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Font Awesome icon.
        /// </summary>
        /// <param name="style">Optional <see cref="BEnum.IconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="BEnum.IconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry FAFoundry(BEnum.IconFAStyle? style = null, BEnum.IconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


        /// <summary>
        /// Returns a new <see cref="IconHelper"> for a Open Iconic icon.
        /// </summary>
        /// <returns><see cref="IIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cascadingDefaults"></param>
        /// <param name="iconName"></param>
        /// <param name="foundry"></param>
        internal IconHelper(CascadingDefaults cascadingDefaults, string iconName, IIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new CascadingDefaults();
            }

            BEnum.IconFoundryName iconFoundry = (foundry is null) ? cascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                BEnum.IconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                BEnum.IconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                BEnum.IconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
