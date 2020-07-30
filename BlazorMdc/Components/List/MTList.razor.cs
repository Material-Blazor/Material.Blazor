using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme list implementing one and two line MT web component
    /// standards. It also implements a BlazorMdc interpretation of the specification for a three line
    /// list item.
    /// </summary>
    public partial class MTList<TItem> : ComponentFoundation
    {
        /// <summary>
        /// The list style.
        /// <para>Overrides <see cref="MTCascadingDefaults.ListStyle"/></para>
        /// </summary>
        [Parameter] public MTListStyle? ListStyle { get; set; }


        /// <summary>
        /// The list type.
        /// <para>Overrides <see cref="MTCascadingDefaults.ListType"/></para>
        /// </summary>
        [Parameter] public MTListType? ListType { get; set; }


        /// <summary>
        /// The items to display in the list.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// The icon render fragment to use if <c>!<see cref="SuppressIcons"/></c>.
        /// Note that you will be expected to render your own icon, and can use <see cref="MTIcon"/>.
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
        /// Shows a <see cref="MTListDivider"/> between list items if True. Defaults to False.
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
        /// The lists's density if it is a single line list. Ignored if <see cref="ListType"/> is <see cref="MTListType.Dense"/>
        /// </summary>
        [Parameter] public MTDensity? SingleLineDensity { get; set; }


        /// <summary>
        /// Hides "line two" if True. Defaults to False.
        /// </summary>
        [Parameter] public bool HideLineTwo { get; set; } = false;


        /// <summary>
        /// Hides "line three" if True. Defaults to False.
        /// </summary>
        [Parameter] public bool HideLineThree { get; set; } = false;



        private ElementReference ElementReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedListSingleLineDensity(SingleLineDensity));

        private MTListStyle AppliedListStyle => CascadingDefaults.AppliedStyle(ListStyle);

        private MTListType AppliedListType => CascadingDefaults.AppliedType(ListType);

        private int NumberOfLines { get; set; }
        private bool HasLineTwo { get; set; }
        private bool HasLineThree { get; set; }
        private string TitleClass { get; set; }
        private string LineTwoClass { get; set; }
        private string LineThreeClass { get; set; }
        private string ListItemClass => "mdc-list-item__text bmdc-full-width" + (AppliedDisabled ? " mdc-list-item--disabled" : "");


        protected override void OnInitialized()
        {
            ClassMapper
                .Add("mdc-list")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass && NumberOfLines == 1 && AppliedListType != MTListType.Dense)
                .AddIf("mdc-card--outlined", () => (CascadingDefaults.AppliedStyle(AppliedListStyle) == MTListStyle.Outlined))
                .AddIf("mdc-list--two-line", () => (NumberOfLines == 2))
                .AddIf("bmdc-list--three-line", () => (NumberOfLines == 3))
                .AddIf("mdc-list--non-interactive", () => NonInteractive)
                .AddIf("mdc-list--dense", () => AppliedListType == MTListType.Dense)
                .AddIf("mdc-list--avatar-list", () => AppliedListType == MTListType.Avatar);
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


        private async Task OnItemClickAsync(int index)
        { 
            if (KeyboardInteractions && !AppliedDisabled) await OnClick.InvokeAsync(index); 
        }

        private async Task OnItemMouseDownAsync(int index)
        {
            if (KeyboardInteractions && !AppliedDisabled) await OnMouseDown.InvokeAsync(index);
        }

        private async Task OnItemKeyDownAsync(int index)
        {
            if (KeyboardInteractions && !AppliedDisabled) await OnKeyDown.InvokeAsync(index);
        }

        private async Task OnItemTouchStartAsync(int index)
        {
            if (KeyboardInteractions && !AppliedDisabled) await OnTouchStart.InvokeAsync(index);
        }


        /// <summary>
        /// Callback for value the Disabled value setter. MTList is a special case where Blazor MDC re-renders the component when Disabled is set.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.list.init", ElementReference, (KeyboardInteractions && !AppliedDisabled), Ripple));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.list.init", ElementReference, (KeyboardInteractions && !AppliedDisabled), Ripple);
    }
}
