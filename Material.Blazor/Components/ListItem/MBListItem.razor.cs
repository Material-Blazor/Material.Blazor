using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme list item.
    /// </summary>
    public partial class MBListItem : ComponentFoundation
    {
#nullable enable annotations
        /// <summary>
        /// The list item's label
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The leading icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// Determined whether the list item is in an menu and is in the selected state
        /// </summary>
        [Parameter] public bool IsSelectedMenuItem { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-list-item")
                .AddIf("mdc-menu-item--selected", () => IsSelectedMenuItem)
                .AddIf("mdc-list-item--disabled mb-list-item--disabled", () => AppliedDisabled);
        }
    }
}
