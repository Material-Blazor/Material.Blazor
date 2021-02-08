using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public partial class InternalSnackbar : ComponentFoundation
    {
        /// <summary>
        /// The unique <see cref="SnackbarInstance"/> for this snackbar.
        /// </summary>
        [Parameter] public SnackbarInstance Snackbar { get; set; }


        private ElementReference SnackbarReference { get; set; }
        
        private string Stacked => Snackbar.Settings.Stacked ? "mdc-snackbar--stacked" : null;
        
        private string Leading => Snackbar.Settings.Leading ? "mdc-snackbar--leading" : null;

        private DotNetObjectReference<InternalSnackbar> ObjectReference { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            ObjectReference = DotNetObjectReference.Create(this);
            base.OnInitialized();
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        public new void Dispose()
        {
            ObjectReference?.Dispose();
            base.Dispose();
        }


        /// <summary>
        /// Called by Material Components Web when a snackbar is closed, setting the Closed parameter in settings
        /// and calling any OnClose listeners.
        /// </summary>
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
        
        
        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSnackbar.open", SnackbarReference, Snackbar.Settings.AppliedTimeout);
            }
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
