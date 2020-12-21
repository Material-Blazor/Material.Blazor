using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme segmented button orientated as a multi-select.
    /// </summary>
    public partial class MBSegmentedButtonMulti<TItem> : MultiSelectComponentFoundation<TItem, MBSegmentedButtonElement<TItem>>
    {
        private IDisposable ObjectReference { get; set; }
        private ElementReference SegmentedButtonReference { get; set; }
        private MBSegmentedButtonElement<TItem>[] ItemsArray => Items.ToArray();


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-segmented-button");

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;

            ObjectReference = DotNetObjectReference.Create(this);
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
        /// For Material Theme to notify of menu item selection via JS Interop.
        /// </summary>
        [JSInvokable("NotifySelectedAsync")]
        public async Task NotifySelectedAsync(bool[] areSelected)
        {
            var selectedIndexes = Enumerable.Range(0, areSelected.Length).Where(i => areSelected[i]);
            ComponentValue = ItemsArray.Where((item, index) => selectedIndexes.Contains(index)).Select(x => x.SelectedValue).ToArray();
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.setAreSelected", SegmentedButtonReference, Items.Select(x => Value.Contains(x.SelectedValue)).ToArray()));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.setDisabled", SegmentedButtonReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.init", SegmentedButtonReference, ObjectReference);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButtonMulti.destroy", SegmentedButtonReference);
    }
}
