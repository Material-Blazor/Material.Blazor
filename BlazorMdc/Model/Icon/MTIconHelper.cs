using BlazorMdc.Internal;

using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    /// <summary>
    /// A helper class for defining which foundry to use for an icon.
    /// </summary>
    public class MTIconHelper : IMTIcon
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


        private readonly IMTIcon UnderlyingIcon;


        /// <summary>
        /// Returns a new <see cref="MTIconHelper"> for a Material Icons icon.
        /// </summary>
        /// <param name="theme">Optional <see cref="IconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IMTIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMTIconFoundry MIFoundry(IconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new <see cref="MTIconHelper"> for a Font Awesome icon.
        /// </summary>
        /// <param name="style">Optional <see cref="IconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="IconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IMTIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMTIconFoundry FAFoundry(IconFAStyle? style = null, IconFARelativeSize? relativeSize = null) => new MTIconFoundryFA(style, relativeSize);


        /// <summary>
        /// Returns a new <see cref="MTIconHelper"> for a Open Iconic icon.
        /// </summary>
        /// <returns><see cref="IMTIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMTIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cascadingDefaults"></param>
        /// <param name="iconName"></param>
        /// <param name="foundry"></param>
        internal MTIconHelper(MTCascadingDefaults cascadingDefaults, string iconName, IMTIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new MTCascadingDefaults();
            }

            IconFoundryName iconFoundry = (foundry is null) ? cascadingDefaults.IconFoundryName : foundry.FoundryName;

            UnderlyingIcon = iconFoundry switch
            {
                IconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                IconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (MTIconFoundryFA?)foundry),
                IconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
