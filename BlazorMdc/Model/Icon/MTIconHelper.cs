﻿using BlazorMdc.Internal;

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
        /// Returns a new Material Icons foundry.
        /// </summary>
        /// <param name="theme">Optional <see cref="MTIconMITheme"/> specifying the Material Icons theme.</param>
        /// <returns><see cref="IMTIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMTIconFoundry MIFoundry(MTIconMITheme? theme = null) => new IconFoundryMI(theme);


        /// <summary>
        /// Returns a new Font Awesome foundry.
        /// </summary>
        /// <param name="style">Optional <see cref="MTIconFAStyle"/> specifying the Font Awesome style.</param>
        /// <param name="relativeSize">Optional <see cref="MTIconFARelativeSize"/> specifying the Font Awesome relative size.</param>
        /// <returns><see cref="IMTIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMTIconFoundry FAFoundry(MTIconFAStyle? style = null, MTIconFARelativeSize? relativeSize = null) => new IconFoundryFA(style, relativeSize);


        /// <summary>
        /// Returns a Open Iconic foundry.
        /// </summary>
        /// <returns><see cref="IMTIconFoundry"/> to be passed to a BlazorMdc component.</returns>
        public static IMTIconFoundry OIFoundry() => new IconFoundryOI();


#nullable enable annotations
        internal MTIconHelper(MTCascadingDefaults cascadingDefaults, string iconName, IMTIconFoundry? foundry = null)
        {
            if (cascadingDefaults is null)
            {
                cascadingDefaults = new MTCascadingDefaults();
            }

            MTIconFoundryName iconFoundry = cascadingDefaults.AppliedIconFoundryName(foundry?.FoundryName);

            UnderlyingIcon = iconFoundry switch
            {
                MTIconFoundryName.MaterialIcons => new IconMI(cascadingDefaults, iconName, (IconFoundryMI?)foundry),
                MTIconFoundryName.FontAwesome => new IconFA(cascadingDefaults, iconName, (IconFoundryFA?)foundry),
                MTIconFoundryName.OpenIconic => new IconOI(cascadingDefaults, iconName, (IconFoundryOI?)foundry),
                _ => throw new NotImplementedException(),
            };
        }
#nullable restore annotations
    }
}
