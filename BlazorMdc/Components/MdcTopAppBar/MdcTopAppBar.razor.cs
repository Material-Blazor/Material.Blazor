using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// A Material Theme top app bar
    /// </summary>
    public partial class MdcTopAppBar : BBase.ComponentBase
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
        /// <para><c>IconFoundry="BModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BModel.IIconFoundry IconFoundry { get; set; }


        /// <summary>
        /// Render fragment where @Body is referenced.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        /// <summary>
        /// Page scroll target 
        /// </summary>
        [Parameter] public string ScrollTarget { get; set; }


        /// <summary>
        /// Top app bar type. See <see cref="BlazorMdc.TopAppBarType"/>
        /// </summary>
        [Parameter] public BEnum.TopAppBarType TopAppBarType { get; set; } = BEnum.TopAppBarType.Standard;

        
        private ElementReference HeaderElem { get; set; }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            ClassMapper
                .Clear()
                .Add("mdc-top-app-bar")
                .AddIf($"mdc-top-app-bar--{TopAppBarType.ToString().ToLower()}", () => TopAppBarType != BEnum.TopAppBarType.Standard && TopAppBarType != BEnum.TopAppBarType.ShortCollapsed)
                .AddIf($"mdc-top-app-bar--short mdc-top-app-bar--short-collapsed", () => TopAppBarType == BEnum.TopAppBarType.ShortCollapsed)
                .Add("app-bar");
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.topAppBar.init", HeaderElem, ScrollTarget);
    }
}
