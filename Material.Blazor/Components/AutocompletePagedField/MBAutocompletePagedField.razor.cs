﻿using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Primitives;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// An autocomplete built using an <see cref="MBTextField"/> with the anchor and drop
/// down list implementation from a Material Theme select.
/// </summary>
public partial class MBAutocompletePagedField<TItem> : SingleSelectComponent<TItem, MBSelectElement<TItem>>
{
#nullable enable annotations
    /// <summary>
    /// Helper text that is displayed either with focus or persistently with <see cref="HelperTextPersistent"/>.
    /// </summary>
    [Parameter] public string HelperText { get; set; } = "";


    /// <summary>
    /// Makes the <see cref="HelperText"/> persistent if true.
    /// </summary>
    [Parameter] public bool HelperTextPersistent { get; set; } = false;


    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }


    /// <summary>
    /// The text input style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
    /// </summary>
    [Parameter] public MBTextInputStyle? TextInputStyle { get; set; }


    /// <summary>
    /// The text alignment style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
    /// </summary>
    [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }


    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }


    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? LeadingIcon { get; set; }


    /// <summary>
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? TrailingIcon { get; set; }


    /// <summary>
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


    /// <summary>
    /// The autcomplete field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// Debounce interval in milliseconds.
    /// </summary>
    [Parameter] public int? DebounceInterval { get; set; }
#nullable restore annotations


    /// <summary>
    /// The number of items to be displayed per column for a given paged selection.
    /// </summary>
    [Parameter] public int SelectItemsPerColumn { get; set; }


    /// <summary>
    /// Allow unmatched results.
    /// </summary>
    [Parameter] public bool AllowBlankResult { get; set; } = false;


    /// <summary>
    /// REQUIRED: an async method returning an enumerated selection list. Parameters
    /// are the search string, followed by the requested page number, and then the page size.
    /// </summary>
    [Parameter] public Func<string, int, int, Action<MBPagedSearchResult<TItem>>, Task> GetMatchingSelection { get; set; }


    /// <summary>
    /// REQUIRED: Gets a select element matching the supplied selected value.
    /// </summary>
    [Parameter] public Func<TItem, Action<MBSelectElement<TItem>>, Task> GetSelectElement { get; set; }



    private bool IsOpen { get; set; } = false;
    private DotNetObjectReference<MBAutocompletePagedField<TItem>> ObjectReference { get; set; }
    private bool MenuHasFocus { get; set; } = false;
    private bool SelectionClosedMenu { get; set; } = false;
    private ElementReference MenuReference { get; set; }
    private bool ResultsPending { get; set; } = false;
    private MBLinearProgressType MenuSurfaceLinearProgressType => ResultsPending ? MBLinearProgressType.Indeterminate : MBLinearProgressType.Closed;
    private MBSelectElement<TItem>[] SelectItems { get; set; } = Array.Empty<MBSelectElement<TItem>>();
    private string SearchText { get; set; } = "";
    private MBSearchResultTypes SearchResultType { get; set; } = MBSearchResultTypes.NoMatchesFound;
    public int MatchingItemCount { get; set; }
    private MBTextField TextField { get; set; }
    private int AppliedDebounceInterval => CascadingDefaults.AppliedDebounceInterval(DebounceInterval);
    private string CurrentValue { get; set; } = "";
    private Timer Timer { get; set; }
    private TItem PreviousComponentValue { get; set; } = default;
    private string PreviousSearchText { get; set; } = "";
    private int PageNumber { get; set; } = 0;
    private int[] PaginatorItemsPerPage { get; set; } = { 0 };



    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ForceShouldRenderToTrue = true;
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        if (!ComponentValue.Equals(PreviousComponentValue))
        {
            await RequerySearchText().ConfigureAwait(false);
        }

        if (SelectItemsPerColumn * 2 != PaginatorItemsPerPage[0])
        {
            PaginatorItemsPerPage[0] = SelectItemsPerColumn * 2;
        }
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
            Timer?.Dispose();
        }

        _disposed = true;

        base.Dispose(disposing);
    }


    /// <summary>
    /// Forces the component to re-query search text. This can be used if the search text associated
    /// with the component's value changes. For example if the Value parameter is a Guid but the search
    /// text associated with it changes in your app, call this method to update the component accordingly.
    /// </summary>
    /// <returns></returns>
    public async Task RequerySearchText()
    {
        await GetSelectElement(ComponentValue, ReceiveSelectElement).ConfigureAwait(false);


        void ReceiveSelectElement(MBSelectElement<TItem> selectElement)
        {
            SearchText = selectElement.Label;
            PreviousComponentValue = ComponentValue;
            PreviousSearchText = SearchText;
        }
    }


    private async Task GetSelectionAsync(string searchString)
    {
        if (GetMatchingSelection is null)
        {
            SelectItems = Array.Empty<MBSelectElement<TItem>>();
            SearchResultType = MBSearchResultTypes.NoMatchesFound;
            MatchingItemCount = 0;
        }
        else
        {
            if (PageNumber != 0)
            {
                _ = 1;
            }
            await GetMatchingSelection(searchString ?? "", PageNumber, 2 * SelectItemsPerColumn, ReceiveSearchItem).ConfigureAwait(false);
        }

        await InvokeAsync(StateHasChanged);


        void ReceiveSearchItem(MBPagedSearchResult<TItem> searchResult)
        {
            if (!searchResult.ResultsPending)
            {
                SelectItems = searchResult.MatchingItems.ToArray();
            }
            
            ResultsPending = searchResult.ResultsPending;
            SearchResultType = searchResult.SearchResultType;
            MatchingItemCount = searchResult.MatchingItemCount;

            _ = InvokeAsync(StateHasChanged);
        }
    }


    private void OnInput(ChangeEventArgs args)
    {
        Timer?.Dispose();
        var autoReset = new AutoResetEvent(false);
        Timer = new Timer(async _ => await GetSelectionAndDisplayMenuAsync(args.Value.ToString()).ConfigureAwait(false), autoReset, AppliedDebounceInterval, Timeout.Infinite);
    }


    private async Task GetSelectionAndDisplayMenuAsync(string searchString)
    {
        await GetSelectionAsync(searchString);

        if (SearchResultType == MBSearchResultTypes.FullMatchFound || (AllowBlankResult && ComponentValue.Equals(default)))
        {
            await CloseMenuAsync();
            ComponentValue = SelectItems[0].SelectedValue;
            SearchText = SelectItems[0].Label;
        }
        else if (SelectItems.Any())
        {
            await OpenMenuAsync();
        }
        else
        {
            await OpenMenuAsync();
        }

        await InvokeAsync(StateHasChanged);
    }



    private async Task OnTextChangeAsync()
    {
        await CloseMenuAsync(true);

        if (!MenuHasFocus)
        {
            await GetSelectionAsync(SearchText).ConfigureAwait(false);
        }
    }


    private async Task OnTextFocusInAsync()
    {
        await GetSelectionAsync(SearchText);

        if (!SelectionClosedMenu)
        {
            await OpenMenuAsync().ConfigureAwait(false);
        }

        SelectionClosedMenu = false;
    }


    private async Task OnTextFocusOutAsync()
    {
        if (!MenuHasFocus)
        {
            await CloseMenuAsync().ConfigureAwait(false);

            SearchText = PreviousSearchText;

            await InvokeAsync(StateHasChanged).ConfigureAwait(false);
        }
    }


    private void OnMenuFocusIn()
    {
        MenuHasFocus = true;
    }


    private void OnMenuFocusOut()
    {
        MenuHasFocus = false;
    }


    private async Task OnListItemClickAsync(int col, int listIndex)
    {
        var selectedElement = SelectItems[(col * SelectItemsPerColumn) + listIndex];

        ComponentValue = selectedElement.SelectedValue;

        SearchText = selectedElement.Label;

        SelectionClosedMenu = true;

        await CloseMenuAsync().ConfigureAwait(false);

        NotifyClosed();
    }


    private async Task OnPageTurn()
    {
        await GetSelectionAndDisplayMenuAsync(SearchText).ConfigureAwait(false);
    }


    /// <summary>
    /// For Material Theme to notify when the drop down is closed via JS Interop.
    /// </summary>
    /// <returns></returns>
    [JSInvokable]
    public void NotifyClosed()
    {
        IsOpen = false;

        _ = InvokeAsync(StateHasChanged);
    }


    private async Task OpenMenuAsync(bool forceOpen = false)
    {
        if (!IsOpen || forceOpen)
        {
            IsOpen = true;
            await InvokeJsVoidAsync("MaterialBlazor.MBAutocompleteTextField.open", MenuReference);
        }
    }


    private async Task CloseMenuAsync(bool forceClose = false)
    {
        if (IsOpen || forceClose)
        {
            IsOpen = false;
            await InvokeJsVoidAsync("MaterialBlazor.MBAutocompleteTextField.close", MenuReference);
        }
    }


    /// <inheritdoc/>
    internal override async Task InstantiateMcwComponent()
    {
        ObjectReference ??= DotNetObjectReference.Create(this);

        await InvokeJsVoidAsync("MaterialBlazor.MBAutocompleteTextField.init", TextField.ElementReference, MenuReference, ObjectReference).ConfigureAwait(false);
    }
}
