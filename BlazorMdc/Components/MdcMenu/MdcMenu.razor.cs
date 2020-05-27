using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme menu.
    /// </summary>
    public partial class MdcMenu : BBase.ComponentBase, IDisposable
    {
        /// <summary>
        /// A render fragement as a set of <see cref="MdcListItem"/>s.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        private DotNetObjectReference<MdcMenu> ObjectReference { get; set; }
        private ElementReference ElementReference { get; set; }
        private bool IsOpen { get; set; } = false;


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();
            
            ClassMapper
                .Add("mdc-menu mdc-menu-surface");

            ObjectReference = DotNetObjectReference.Create(this);
        }


        /// <inheritdoc/>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            ObjectReference?.Dispose();
        }


        /// <summary>
        /// For Material theme to notify of menu closure.
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
                return await JsRuntime.InvokeAsync<string>("BlazorMdc.menu.show", ElementReference, ObjectReference);
            }
        }
    }
}
