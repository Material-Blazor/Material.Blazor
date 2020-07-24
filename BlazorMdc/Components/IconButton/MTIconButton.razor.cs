using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme icon button, with provision for standard MT styling, leading 
    /// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--icon" class when 
    /// placed inside an <see cref="MTCard"/>.
    /// </summary>
    public partial class MTIconButton : ComponentFoundation
    {
        [CascadingParameter] private MTCard Card { get; set; }


#nullable enable annotations
        /// <summary>
        /// The icon's name.
        /// </summary>
        [Parameter] public string Icon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        /// <summary>
        /// The button's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        private ElementReference ElementReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityInfo(CascadingDefaults.AppliedIconButtonDensity(Density));


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add($"mdc-icon-button")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-card__action mdc-card__action--icon", () => (Card != null));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.iconButton.init", ElementReference);
    }
}
