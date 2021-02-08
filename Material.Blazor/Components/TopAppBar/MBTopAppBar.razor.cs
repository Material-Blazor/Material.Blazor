using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme top app bar
    /// </summary>
    public partial class MBTopAppBar : ComponentFoundation
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
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry IconFoundry { get; set; }


        /// <summary>
        /// Render fragment where @Body is referenced.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        /// <summary>
        /// Page scroll target 
        /// </summary>
        [Parameter] public string ScrollTarget { get; set; }


        /// <summary>
        /// Top app bar type. See <see cref="MBTopAppBarType"/>
        /// </summary>
        [Parameter] public MBTopAppBarType TopAppBarType { get; set; } = MBTopAppBarType.Standard;


        private ElementReference HeaderElem { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-top-app-bar")
                .AddIf($"mdc-top-app-bar--{TopAppBarType.ToString().ToLower()}", () => TopAppBarType != MBTopAppBarType.Standard && TopAppBarType != MBTopAppBarType.ShortCollapsed)
                .AddIf($"mdc-top-app-bar--short mdc-top-app-bar--short-collapsed", () => TopAppBarType == MBTopAppBarType.ShortCollapsed)
                .Add("app-bar");
        }


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTopAppBar.init", HeaderElem, ScrollTarget);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTopAppBar.destroy", HeaderElem);
    }
}
