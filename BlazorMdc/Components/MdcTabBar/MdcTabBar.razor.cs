using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme tab bar.
    /// </summary>
    public partial class MdcTabBar<TItem> : BBase.ComponentBase
    {
        private int _tabIndex;
        /// <summary>
        /// The tab index.
        /// </summary>
        [Parameter]
        public int TabIndex
        {
            get => _tabIndex;

            set
            {
                if (!HasRendered)
                {
                    _tabIndex = value;
                }
                else if (value != _tabIndex)
                {
                    SetTabIndex(value);
                    _tabIndex = value;
                }
            }
        }


        /// <summary>
        /// The change event callback for <see cref="TabIndex"/>.
        /// </summary>
        [Parameter] public EventCallback<int> TabIndexChanged { get; set; }


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
        /// CSS class. As a helper you can render with <see cref="PMdcIcon"/> with <see cref="PMdcIcon.TabBar"/>
        /// set to true. Note that Material Icons always render properly, while some wider Font Awesome
        /// icons for instance render too close to the tab text.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Icon { get; set; }


        private string StackClass => StackIcons ? "mdc-tab--stacked" : "";
        private ElementReference ElementReference { get; set; }
        private bool HasRendered { get; set; } = false;
        private bool AllowNextRender { get; set; } = false;
        private int StateNextIndex { get; set; } = -1;


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-tab-bar");
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            AllowNextRender = true;
        }


        private async Task OnTabClickAsync(int index)
        {
            if (index != TabIndex)
            {
                _tabIndex = index;
                await TabIndexChanged.InvokeAsync(index).ConfigureAwait(false);
            }
        }


        public void SetTabIndex(int index)
        {
            StateNextIndex = index;
            AllowNextRender = true;
            StateHasChanged();
        }


        /// <inheritdoc/>
        protected override bool ShouldRender()
        {
            if (AllowNextRender)
            {
                AllowNextRender = false;
                return true;
            }

            return false;
        }


        /// <inheritdoc/>
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeAsync<object>("BlazorMdc.tabBar.init", ElementReference);
                HasRendered = true;
            }
            else if (StateNextIndex >= 0)
            {
                await JsRuntime.InvokeAsync<object>("BlazorMdc.tabBar.setTab", ElementReference, StateNextIndex);
                StateNextIndex = -1;
            }
        }
    }
}
