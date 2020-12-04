using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme card with three elements: primary, primary action buttons and action icons.
    /// </summary>
    public partial class MBCard : ComponentFoundation
    {
        /// <summary>
        /// The card style - see <see cref="MBCardStyle"/>
        /// <para>Overrides <see cref="MBCascadingDefaults.CardStyle"/></para>
        /// </summary>
        [Parameter] public MBCardStyle? CardStyle { get; set; }


        /// <summary>
        /// Styles the primary and primary action sections with padding if set to True. This is optional
        /// and you can individually style the HTML in the primary and primary action render fragments if you prefer.
        /// </summary>
        [Parameter] public bool AutoStyled { get; set; }


        /// <summary>
        /// A render fragment for the primary section
        /// </summary>
        [Parameter] public RenderFragment Primary { get; set; }


        /// <summary>
        /// A render fragment for the primary action section, which responds to Blazor events such as @onclick.
        /// </summary>
        [Parameter] public RenderFragment PrimaryAction { get; set; }


        /// <summary>
        /// A render fragment where you place <see cref="MBButton"/>s as action buttons.
        /// </summary>
        [Parameter] public RenderFragment ActionButtons { get; set; }


        /// <summary>
        /// A render fragment where you place <see cref="MBIconButton"/>s as action icons.
        /// </summary>
        [Parameter] public RenderFragment ActionIcons { get; set; }


        private string PrimaryClass => AutoStyled ? "mb-card__primary" : "";
        private string PrimaryActionClass => AutoStyled ? "mb-card__primary-action" : "";
        private ElementReference PrimaryActionReference { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-card")
                .AddIf("mdc-card--outlined", () => CascadingDefaults.AppliedStyle(CardStyle) == MBCardStyle.Outlined);
        }


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent()
        {
            if (PrimaryAction != null)
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCard.init", PrimaryActionReference);
            }
        }


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent()
        {
            if (PrimaryAction != null)
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCard.destroy", PrimaryActionReference);
            }
        }
    }
}
