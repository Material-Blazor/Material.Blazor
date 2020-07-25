﻿using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    /// <summary>
    /// A shield similar to those from shield.io and used in GitHub. Implemented
    /// with HTML rather than SVG.
    /// </summary>
    public partial class MTShield : ComponentFoundation
    {
#nullable enable annotations
        /// <summary>
        /// The shield type, being Label (left part), Value (right part) or both.
        /// </summary>
        [Parameter] public MTShieldType ShieldType { get; set; } = MTShieldType.LabelAndValue;


        /// <summary>
        /// Label (to the left).
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Value (to the right)
        /// </summary>
        [Parameter] public string Value { get; set; }


        /// <summary>
        /// Extra CSS class for the Label.
        /// </summary>
        [Parameter] public string LabelClass { get; set; } = "";


        /// <summary>
        /// HTML style attribute for the Label.
        /// </summary>
        [Parameter] public string LabelStyle { get; set; } = "";


        /// <summary>
        /// Icon for the Label.
        /// </summary>
        [Parameter] public string LabelIcon { get; set; } = "";


        /// <summary>
        /// Extra CSS Class for the Value.
        /// </summary>
        [Parameter] public string ValueClass { get; set; } = "";


        /// <summary>
        /// HTML style attribute for the Value.
        /// </summary>
        [Parameter] public string ValueStyle { get; set; } = "";


        /// <summary>
        /// Icon for the Value.
        /// </summary>
        [Parameter] public string ValueIcon { get; set; } = "";


        /// <summary>
        /// The foundry to use for both icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MTCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("bmdc-shield");
        }
    }
}
