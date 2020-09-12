using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme menu.
    /// </summary>
    public partial class MBMenu : ComponentFoundation
    {
        /// <summary>
        /// A render fragement as a set of <see cref="MBListItem"/>s.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        private DotNetObjectReference<MBMenu> ObjectReference { get; set; }
        private ElementReference ElementReference { get; set; }
        private bool IsOpen { get; set; } = false;


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();
            
            ClassMapper
                .Add("mdc-menu mdc-menu-surface mdc-menu-surface--fixed");

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
        /// For Material Theme to notify of menu closure via JS Interop.
        /// </summary>
        [JSInvokable("NotifyClosedAsync")]
        public async Task NotifyClosedAsync()
        {
            IsOpen = false;
            await Task.CompletedTask;
        }


        /// <summary>
        /// Toggles the menu open and closed.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ToggleAsync()
        {
            if (IsOpen)
            {
                return await JsRuntime.InvokeAsync<string>("BlazorMdc.menu.hide", ElementReference);
            }
            else
            {
                return await JsRuntime.InvokeAsync<string>("BlazorMdc.menu.show", ElementReference);
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeAsync<string>("BlazorMdc.menu.init", ElementReference, ObjectReference);
            }
        }
    }
}
