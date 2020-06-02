using BMdcFoundation;

using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme list implementing one and two line MT web component
    /// standards. It also implements a BlazorMdc interpretation of the specification for a three line
    /// list item.
    /// </summary>
    public partial class List<TItem> : ComponentFoundation
    {
        /// <summary>
        /// The list style.
        /// </summary>
        [Parameter] public eListStyle? ListStyle { get; set; }


        /// <summary>
        /// The items to display in the list.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// The icon render fragment to use if <c>!<see cref="SuppressIcons"/></c>.
        /// Note that you will be expected to render your own icon, and can use <see cref="BMdcPlus.Icon"/>.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Icon { get; set; }


        /// <summary>
        /// The title line render fragment.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Title { get; set; }


        /// <summary>
        /// The "line two" render fragment.
        /// </summary>
        [Parameter] public RenderFragment<TItem> LineTwo { get; set; }


        /// <summary>
        /// The "line three" render fragment.
        /// </summary>
        [Parameter] public RenderFragment<TItem> LineThree { get; set; }


        /// <summary>
        /// The actions render fragment.
        /// </summary>
        [Parameter] public RenderFragment<TItem> Actions { get; set; }
        //[Parameter] public RenderFragment<TItem> ContextMenu { get; set; }


        /// <summary>
        /// An @onclick event handler returning the index of the relevant list item.
        /// </summary>
        [Parameter] public EventCallback<int> OnClick { get; set; }
        
        
        /// <summary>
        /// An @onmousedown event handler returning the index of the relevant list item.
        /// </summary>
        [Parameter] public EventCallback<int> OnMouseDown { get; set; }
        
        
        /// <summary>
        /// An @onkeydown event handler returning the index of the relevant list item.
        /// </summary>
        [Parameter] public EventCallback<int> OnKeyDown { get; set; }
        
        
        /// <summary>
        /// An @ontouchstart event handler returning the index of the relevant list item.
        /// </summary>
        [Parameter] public EventCallback<int> OnTouchStart { get; set; }


        /// <summary>
        /// Shows an <see cref="ListDivider"/> between list items if True. Defaults to False.
        /// </summary>
        [Parameter] public bool ShowSeparators { get; set; } = false;


        /// <summary>
        /// Allows keyboard interactions if True. Defaults to False.
        /// </summary>
        [Parameter] public bool KeyboardInteractions { get; set; } = false;


        /// <summary>
        /// Applies ripple to the list item if True. Defaults to False.
        /// </summary>
        [Parameter] public bool Ripple { get; set; } = false;


        /// <summary>
        /// Sets the non interative Material Theme class if True. Defaults to False.
        /// </summary>
        [Parameter] public bool NonInteractive { get; set; }


        /// <summary>
        /// Suppresses icon display if True. Defaults to False.
        /// </summary>
        [Parameter] public bool SuppressIcons { get; set; }


        /// <summary>
        /// Sets the dense Material Theme class if true.  Defaults to False.
        /// </summary>
        [Parameter] public bool Dense { get; set; } = false;


        /// <summary>
        /// Sets the avatar list Material Theme class if true. Defaults to False. 
        /// </summary>
        [Parameter] public bool AvatarList { get; set; } = false;


        /// <summary>
        /// Hides "line two" if True. Defaults to False.
        /// </summary>
        [Parameter] public bool HideLineTwo { get; set; } = false;


        /// <summary>
        /// Hides "line three" if True. Defaults to False.
        /// </summary>
        [Parameter] public bool HideLineThree { get; set; } = false;



        private ElementReference ElementReference { get; set; }
        private int NumberOfLines { get; set; }
        private bool HasLineTwo { get; set; }
        private bool HasLineThree { get; set; }
        private string TitleClass { get; set; }
        private string LineTwoClass { get; set; }
        private string LineThreeClass { get; set; }


        protected override void OnInitialized()
        {
            ClassMapper
                .Add("mdc-list")
                .AddIf("mdc-card--outlined", () => (CascadingDefaults.AppliedStyle(ListStyle) == eListStyle.Outlined))
                .AddIf("mdc-list--two-line", () => (NumberOfLines == 2))
                .AddIf("bmdc-list--three-line", () => (NumberOfLines == 3))
                .AddIf("mdc-list--non-interactive", () => NonInteractive)
                .AddIf("mdc-list--dense", () => Dense)
                .AddIf("mdc-list--avatar-list", () => AvatarList);
        }

        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            HasLineTwo = LineTwo != null && !HideLineTwo;
            HasLineThree = LineThree != null && !HideLineThree;

            NumberOfLines = 1;
            if (HasLineTwo) NumberOfLines++;
            if (HasLineThree) NumberOfLines++;

            TitleClass = (NumberOfLines == 1) ? "" : "mdc-list-item__primary-text";
            LineTwoClass = "mdc-list-item__secondary-text bmdc-full-width";
            LineThreeClass = "mdc-list-item__secondary-text" + ((NumberOfLines == 3) ? " line-three" : "") + " bmdc-full-width";
        }


        private async Task OnItemClickAsync(int index) => await OnClick.InvokeAsync(index);

        private async Task OnItemMouseDownAsync(int index) => await OnMouseDown.InvokeAsync(index);

        private async Task OnItemKeyDownAsync(int index) => await OnKeyDown.InvokeAsync(index);

        private async Task OnItemTouchStartAsync(int index) => await OnTouchStart.InvokeAsync(index);


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.list.init", ElementReference, KeyboardInteractions, Ripple);
    }
}
