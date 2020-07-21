using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme top app bar
    /// </summary>
    public partial class MTTopAppBar : ComponentFoundation
    {
        /// <summary>
        /// App bar title.
        /// </summary>
        [Parameter] public string Title { get; set; }


        /// <summary>
        /// Navigation button icon.
        /// </summary>
        [Parameter] public string NavIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public IMTIconFoundry IconFoundry { get; set; }


        /// <summary>
        /// Render fragment where @Body is referenced.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        /// <summary>
        /// Page scroll target 
        /// </summary>
        [Parameter] public string ScrollTarget { get; set; }


        /// <summary>
        /// Top app bar type. See <see cref="BlazorMdc.MTTopAppBarType"/>
        /// </summary>
        [Parameter] public MTTopAppBarType TopAppBarType { get; set; } = MTTopAppBarType.Standard;

        
        private ElementReference HeaderElem { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-top-app-bar")
                .AddIf($"mdc-top-app-bar--{TopAppBarType.ToString().ToLower()}", () => TopAppBarType != MTTopAppBarType.Standard && TopAppBarType != MTTopAppBarType.ShortCollapsed)
                .AddIf($"mdc-top-app-bar--short mdc-top-app-bar--short-collapsed", () => TopAppBarType == MTTopAppBarType.ShortCollapsed)
                .Add("app-bar");
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.topAppBar.init", HeaderElem, ScrollTarget);
    }
}
