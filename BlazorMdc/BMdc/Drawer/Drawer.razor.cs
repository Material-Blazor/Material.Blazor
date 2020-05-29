using BMdcBase;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme drawer.
    /// </summary>
    public partial class Drawer : BMdcBase.ComponentBase
    {
        /// <summary>
        /// The drawer contents.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }


        /// <summary>
        /// Determines whether the drawer should be open on startup. Defaults to False.
        /// </summary>
        [Parameter] public bool StartOpen { get; set; } = false;


        /// <summary>
        /// The drawer can be dismissed if True. Defaults to True.
        /// </summary>
        [Parameter] public bool IsDismissible { get; set; } = true;


        /// <summary>
        /// Closes the drawer when <see cref="NotifyNavigation"/> is called if True.
        /// Defaults to True.
        /// </summary>
        [Parameter] public bool CloseOnNavigate { get; set; } = true;


        private ElementReference DrawerElem { get; set; }


        private bool isOpen;


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-drawer")
                .AddIf("mdc-drawer--dismissible", () => IsDismissible)
                .AddIf("mdc-drawer--open", () => StartOpen);

            isOpen = StartOpen;
        }



        /// <summary>
        /// Toggles the drawer's state.
        /// </summary>
        public void Toggle() => Toggle(!isOpen);


        /// <summary>
        /// Toggles the drawer's state to the requested value.
        /// </summary>
        public void Toggle(bool open)
        {
            isOpen = open;
            InvokeAsync(async () => await InitializeMdcComponent());
        }


        /// <summary>
        /// Called by the consumer to tell the drawer that navigation has
        /// taken place.
        /// </summary>
        public void NotifyNavigation()
        {
            if (CloseOnNavigate)
            {
                Toggle(false);
            }
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.drawer.toggle", DrawerElem, isOpen);
    }
}
