﻿using BMdcBase;
using BMdcModel;
using Microsoft.AspNetCore.Components;

namespace BMdcPlus
{
    /// <summary>
    /// Renders icons from any of the Material Icons, Font Awesome and Open Iconic
    /// foundries. Material Icons are essential for BlazorMdc and are included by the
    /// library's CSS, while you can elect whether to include Font Awesome and Open Iconic
    /// in your app.
    /// </summary>
    public partial class Icon : BMdcBase.ComponentBase
    {
#nullable enable annotations
        /// <summary>
        /// The icon name.
        /// </summary>
        [Parameter] public string IconName { get; set; }


        /// <summary>
        /// The foundry.
        /// <para><c>IconFoundry="BMdcModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BMdcModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BMdcModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BMdcModel.IIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Indicates if True that the icons is to be rendered in an <see cref="MdcTabBar{TItem}"/>,
        /// adding the "mdc-tab__icon" CSS class.
        /// </summary>
        [Parameter] public bool TabBar { get; set; }
#nullable restore annotations


        private BMdcModel.IconHelper IconHelper { get; set; }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            IconHelper = new BMdcModel.IconHelper(CascadingDefaults, IconName, IconFoundry);

            ClassMapper
                .Clear()
                .Add(IconHelper.Class)
                .AddIf("mdc-tab__icon", () => TabBar);

            ComponentPureHtmlAttributes = IconHelper.Attributes;
        }
    }
}
