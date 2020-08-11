using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme button, with provision for standard MT styling, leading 
    /// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--button" class when 
    /// placed inside an <see cref="MTCard"/>.
    /// </summary>
    public partial class MTButton : ComponentFoundation
    {
        [CascadingParameter] private MTCard Card { get; set; }

        [CascadingParameter] private MTDialog Dialog { get; set; }


#nullable enable annotations
        /// <summary>
        /// The button's Material Theme style - see <see cref="BlazorMdc.MTButtonStyle"/>.
        /// <para>Overrides <see cref="MTCascadingDefaults.ButtonStyle"/>, <see cref="MTCascadingDefaults.CardActionButtonStyle"/> or <see cref="MTCascadingDefaults.DialogActionButtonStyle"/> as relevant.</para>
        /// </summary>
        [Parameter] public MTButtonStyle? ButtonStyle { get; set; }


        /// <summary>
        /// The button's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        /// <summary>
        /// The button's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The leading icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// The trailing icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? TrailingIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MTCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// A string value to return from an <see cref="MTDialog"/> when this button is pressed.
        /// </summary>
        [Parameter] public string DialogAction { get; set; }
#nullable restore annotations


        private ElementReference ElementReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedButtonDensity(Density));


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-button")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-button--raised", () => CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == MTButtonStyle.ContainedRaised)
                .AddIf("mdc-button--unelevated", () => CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == MTButtonStyle.ContainedUnelevated)
                .AddIf("mdc-button--outlined", () => CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == MTButtonStyle.Outlined)
                .AddIf("mdc-card__action mdc-card__action--button", () => (Card != null));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeVoidAsync("BlazorMdc.button.init", ElementReference);
    }
}
