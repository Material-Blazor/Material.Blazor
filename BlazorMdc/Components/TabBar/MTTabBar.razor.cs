using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme tab bar.
    /// </summary>
    public partial class MTTabBar<TItem> : InputComponentFoundation<int>
    {
        /// <summary>
        /// Stack icons vertically if True, otherwise icons are leading.
        /// </summary>
        [Parameter] public bool StackIcons { get; set; }


        /// <summary>
        /// The list of items for the tab bar.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// Label render fragments.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Label { get; set; }


        /// <summary>
        /// Icon render fragments requiring correct icon markup including the "mdc-tab__icon"
        /// CSS class. As a helper you can render with <see cref="MTIcon"/> with <see cref="MTIcon.TabBar"/>
        /// set to true. Note that Material Icons always render properly, while some wider Font Awesome
        /// icons for instance render too close to the tab text.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Icon { get; set; }


        /// <summary>
        /// The tab bar's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        private DotNetObjectReference<MTTabBar<TItem>> ObjectReference { get; set; }
        private string StackClass => StackIcons ? "mdc-tab--stacked" : "";
        private ElementReference ElementReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo
        {
            get
            {
                var d = CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedTabBarDensity(Density));

                d.CssClassName += StackIcons ? "--stacked" : "--unstacked";

                return d;
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ObjectReference = DotNetObjectReference.Create(this);

            ClassMapper
                .Add("mdc-tab-bar")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass);
            
            OnValueSet += OnValueSetCallback;
        }


        private bool _disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                ObjectReference?.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }


        /// <summary>
        /// For Material Theme to notify when a tab is clicked via JS Interop.
        /// </summary>
        /// <returns></returns>
        [JSInvokable("NotifyActivatedAsync")]
        public async Task NotifyActivatedAsync(int index)
        {
            ReportingValue = index;

            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("BlazorMdc.tabBar.activateTab", ElementReference, Value).ConfigureAwait(false));


        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeVoidAsync("BlazorMdc.tabBar.init", ElementReference, ObjectReference).ConfigureAwait(false);
    }
}
