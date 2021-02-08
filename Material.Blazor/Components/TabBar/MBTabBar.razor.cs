using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme tab bar.
    /// </summary>
    public partial class MBTabBar<TItem> : InputComponent<int>
    {
        /// <summary>
        /// A constant string to identify a cascading value to <see cref="MBIcon"/>, so that the
        /// icon can apply styling for use in a tab bar.
        /// </summary>
        internal const string TabBarIdentifier = "adc2d67b-9dfc-4e0c-b411-438707a248dc";


        /// <summary>
        /// Stack icons vertically if True, otherwise icons are leading.
        /// </summary>
        [Parameter] public bool StackIcons { get; set; }


        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


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
        /// CSS class. Note that Material Icons always render properly, while some wider Font Awesome
        /// icons for instance render too close to the tab text.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Icon { get; set; }


        /// <summary>
        /// The tab bar's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        private readonly object tabBarIdentifierObject = new object();

        private ElementReference ElementReference { get; set; }
        private DotNetObjectReference<MBTabBar<TItem>> ObjectReference { get; set; }
        private Func<TItem, object> KeyGenerator { get; set; }
        private string StackClass => StackIcons ? "mdc-tab--stacked" : "";

        private MBCascadingDefaults.DensityInfo DensityInfo
        {
            get
            {
                var d = CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedTabBarDensity(Density));

                d.CssClassName += StackIcons ? "--stacked" : "--unstacked";

                return d;
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ObjectReference = DotNetObjectReference.Create(this);

            ClassMapperInstance
                .Add("mdc-tab-bar")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass);

            SetComponentValue += OnValueSetCallback;
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
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
            ComponentValue = index;

            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTabBar.activateTab", ElementReference, Value).ConfigureAwait(false));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTabBar.init", ElementReference, ObjectReference).ConfigureAwait(false);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBTabBar.destroy", ElementReference).ConfigureAwait(false);
    }
}
