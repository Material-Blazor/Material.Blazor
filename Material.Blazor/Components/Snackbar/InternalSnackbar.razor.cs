using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public partial class InternalSnackbar : ComponentFoundation, IDisposable
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSnackbar.open", SnackbarReference, Snackbar.Settings.AppliedTimeout);
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        private DotNetObjectReference<InternalSnackbar> ObjectReference;
        protected override void OnInitialized()
        {
            ObjectReference = DotNetObjectReference.Create(this);
            base.OnInitialized();
        }

        public new void Dispose()
        {
            ObjectReference?.Dispose();
            base.Dispose();
        }

        [JSInvokable]
        public void Closed()
        {
            if (Snackbar.Settings.Closed)
            {
                return;
            }
            Snackbar.Settings.Closed = true;
            Snackbar.Settings.OnClose?.Invoke(Snackbar);
        }

        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSnackbar.init", SnackbarReference, ObjectReference);
        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSnackbar.destroy", SnackbarReference);
    }
}
