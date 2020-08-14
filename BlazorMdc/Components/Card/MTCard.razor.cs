using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme card with three elements: primary, primary action buttons and action icons.
    /// </summary>
    public partial class MTCard : ComponentFoundation
    {
        /// <summary>
        /// The card style - see <see cref="MTCardStyle"/>
        /// <para>Overrides <see cref="MTCascadingDefaults.CardStyle"/></para>
        /// </summary>
        [Parameter] public MTCardStyle? CardStyle { get; set; }


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
        /// A render fragment where you place <see cref="MTButton"/>s as action buttons.
        /// </summary>
        [Parameter] public RenderFragment ActionButtons { get; set; }


        /// <summary>
        /// A render fragment where you place <see cref="MTIconButton"/>s as action icons.
        /// </summary>
        [Parameter] public RenderFragment ActionIcons { get; set; }


        private string PrimaryClass => AutoStyled ? "bmdc-card__primary" : "";
        private string PrimaryActionClass => AutoStyled ? "bmdc-card__primary-action" : "";
        private ElementReference PrimaryActionReference { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-card")
                .AddIf("mdc-card--outlined", () => CascadingDefaults.AppliedStyle(CardStyle) == MTCardStyle.Outlined);
        }


        /// <summary>
        /// Overrides <see cref="OnAfterRenderAsync(bool)"/> because the method must only
        /// initiate Material Theme javascript if the <see cref="PrimaryAction"/> is not null.
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && PrimaryAction != null)
            {
                await JsRuntime.InvokeVoidAsync("BlazorMdc.cardPrimaryAction.init", PrimaryActionReference);
            }
        }
    }
}
