using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
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
public partial class MBAutocompleteTextFieldAsync : InputComponent<string>
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
    /// Allow unmatched results.
    /// </summary>
    [Parameter] public bool AllowBlankResult { get; set; } = false;


    /// <summary>
    /// An async method returning an enumerated selection list.
    /// </summary>
    [Parameter]
    public Func<string, Task<MBAutocompleteAsyncSearchResult>> GetMatchingSelection { get; set; }



    private bool IsOpen { get; set; } = false;
    private DotNetObjectReference<MBAutocompleteTextFieldAsync> ObjectReference { get; set; }
    private bool MenuHasFocus { get; set; } = false;
    private ElementReference MenuReference { get; set; }
    private string[] SelectItems { get; set; } = Array.Empty<string>();
    private MBSearchResultTypes SearchResultType { get; set; } = MBSearchResultTypes.NoMatchesFound;
    public int MatchingItemCount { get; set; }
    public int MaxItemCount { get; set; }
    private MBTextField TextField { get; set; }
    private int AppliedDebounceInterval => CascadingDefaults.AppliedDebounceInterval(DebounceInterval);
    private string CurrentValue { get; set; } = "";
    private Timer Timer { get; set; }



    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ObjectReference = DotNetObjectReference.Create(this);

        ForceShouldRenderToTrue = true;
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


    private async Task GetSelectionAsync(string searchString)
    {
        if (GetMatchingSelection is null)
        {
            SelectItems = Array.Empty<string>();
            SearchResultType = MBSearchResultTypes.NoMatchesFound;
            MatchingItemCount = 0;
            MaxItemCount = 0;
        }
        else
        {
            var searchResult = await GetMatchingSelection.Invoke(searchString ?? "");

            SelectItems = searchResult.MatchingItems.ToArray();
            SearchResultType = searchResult.SearchResultType;
            MatchingItemCount = searchResult.MatchingItemCount;
            MaxItemCount = searchResult.MaxItemCount;
        }

        await InvokeAsync(StateHasChanged);
    }


    private void OnInput(ChangeEventArgs args)
    {
        Timer?.Dispose();
        var autoReset = new AutoResetEvent(false);
        Timer = new Timer(OnTimerComplete, autoReset, AppliedDebounceInterval, Timeout.Infinite);


        async void OnTimerComplete(object stateInfo)
        {
            Console.WriteLine(args.Value.ToString());
            await GetSelectionAsync(args.Value.ToString());

            if (SearchResultType == MBSearchResultTypes.FullMatchFound || (AllowBlankResult && string.IsNullOrWhiteSpace(ComponentValue)))
            {
                await CloseMenuAsync();
                ComponentValue = SelectItems[0];
            }
            else if (SelectItems.Any())
            {
                await OpenMenuAsync();
            }
            else
            {
                await OpenMenuAsync();
            }
        }
    }


    private async Task OnTextChangeAsync()
    {
        await CloseMenuAsync(true);

        if (!MenuHasFocus)
        {
            await GetSelectionAsync(ComponentValue);
        }
    }


    private async Task OnTextFocusOutAsync()
    {
        if (!SelectItems.Any())
        {
            await CloseMenuAsync();
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


    /// <summary>
    /// For Material Theme to notify when the drop down is closed via JS Interop.
    /// </summary>
    /// <returns></returns>
    [JSInvokable]
    public void NotifyClosed()
    {
        IsOpen = false;

        ComponentValue = Value?.Trim() ?? "";

        StateHasChanged();
    }


    /// <summary>
    /// For Material Theme to notify of menu item selection via JS Interop.
    /// </summary>
    /// <returns></returns>
    [JSInvokable]
    public void NotifySelected(string value)
    {
        ComponentValue = value;

        NotifyClosed();
    }


    private async Task OpenMenuAsync(bool forceOpen = false)
    {
        if (!IsOpen || forceOpen)
        {
            IsOpen = true;
            await InvokeJsVoidAsync("MaterialBlazor.MBAutoCompleteTextField.open", MenuReference);
        }
    }


    private async Task CloseMenuAsync(bool forceClose = false)
    {
        if (IsOpen || forceClose)
        {
            IsOpen = false;
            await InvokeJsVoidAsync("MaterialBlazor.MBAutoCompleteTextField.close", MenuReference);
        }
    }


    /// <inheritdoc/>
    internal override Task InstantiateMcwComponent() => InvokeJsVoidAsync("MaterialBlazor.MBAutoCompleteTextField.init", TextField.ElementReference, MenuReference, ObjectReference);
}
