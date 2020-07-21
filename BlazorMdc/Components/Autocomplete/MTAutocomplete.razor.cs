using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// An autocomplete built using an <see cref="MTTextField"/> with the anchor and drop
    /// down list implementation from a Material Theme select.
    /// </summary>
    public partial class MTAutocomplete : InputComponentFoundation<string>, IDisposable
    {
        private IEnumerable<string> selectItems;
        private IEnumerable<string> newSelectItems = null;

        private class SelectionInfo
        {
            public string SelectedText { get; set; }
            public IEnumerable<string> SelectList { get; set; }
            public bool PotentialMatchesFound => SelectList.Count() > 0;
            public bool FullMatchFound => (SelectList.Count() == 1) && SelectList.Contains(SelectedText);
        }


        private class SelectionItem
        {
            public string Item { get; set; }
            public bool IgnoreWhitespace { get; set; }
            public string SearchTarget => IgnoreWhitespace ? Regex.Replace(Item, @"\s+", String.Empty) : Item;
        }


#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public MTTextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public MTTextAlignStyle? TextAlignStyle { get; set; }


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
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Ignores whitespace when searching the items list.
        /// </summary>
        [Parameter] public bool IgnoreWhitespace { get; set; } = false;


        /// <summary>
        /// Allow unmatched results.
        /// </summary>
        [Parameter] public bool AllowBlankResult { get; set; } = false;


        /// <summary>
        /// Forces the search string to match only from the start of each select item.
        /// </summary>
        [Parameter] public bool MatchFromItemStart { get; set; } = false;


        /// <summary>
        /// List of items to select from.
        /// </summary>
        [Parameter] public IEnumerable<string> SelectItems 
        { 
            get => selectItems;
            set
            {
                if (IsOpen)
                {
                    newSelectItems = value;
                }
                else
                {
                    selectItems = value;
                }
            }
        }
#nullable restore annotations


        private DotNetObjectReference<MTAutocomplete> ObjectReference { get; set; }
        private MTTextField TextField { get; set; }
        private ElementReference SelectReference { get; set; }
        private ElementReference MenuReference { get; set; }
        private SelectionItem[] MySelectItems { get; set; }
        private SelectionInfo SelectInfo { get; set; } = new SelectionInfo();
        private bool IsOpen { get; set; } = false;
        private bool MenuHasFocus { get; set; } = false;


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ObjectReference = DotNetObjectReference.Create(this);

            ForceShouldRenderToTrue = true;
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            ObjectReference?.Dispose();
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            SetParameters();
        }


        private void SetParameters()
        {
            MySelectItems = (from i in SelectItems
                             select new SelectionItem
                             {
                                 Item = i,
                                 IgnoreWhitespace = IgnoreWhitespace
                             }).ToArray();

            SelectInfo = BuildSelectList(ReportingValue);

            StateHasChanged();
        }


        private SelectionInfo BuildSelectList(string fieldText)
        {
            var regexOptions = RegexOptions.IgnoreCase | (IgnoreWhitespace ? RegexOptions.IgnorePatternWhitespace : 0);

            var fullMatchRegex = new Regex($"^{fieldText}$", regexOptions);
            var fullMatches = (from f in MySelectItems
                               where fullMatchRegex.Matches(f.SearchTarget).Count > 0
                               select f.Item).ToArray();

            if (fullMatches.Count() > 0)
            {
                return new SelectionInfo()
                {
                    SelectedText = fullMatches.FirstOrDefault(),
                    SelectList = fullMatches
                };
            }

            var startMatch = MatchFromItemStart ? "^" : "";
            var partialMatchRegex = new Regex($"{startMatch}{fieldText}", regexOptions);
            var partialMatches = (from f in MySelectItems
                                  where partialMatchRegex.Matches(f.SearchTarget).Count > 0
                                  select f.Item).ToArray();

            return new SelectionInfo()
            {
                SelectedText = fieldText,
                SelectList = partialMatches
            };
        }


        private async Task OnInput(ChangeEventArgs args)
        {
            SelectInfo = BuildSelectList((string)args.Value);

            if (SelectInfo.FullMatchFound || (AllowBlankResult && string.IsNullOrWhiteSpace(SelectInfo.SelectedText)))
            {
                await CloseMenuAsync();
                ReportingValue = SelectInfo.SelectedText.Trim();
                SetParameters();
            }

            await OpenMenuAsync();
        }


        private async Task OnTextChangeAsync()
        {
            await CloseMenuAsync(true);

            if (!MenuHasFocus)
            {
                if (SelectInfo.FullMatchFound || (AllowBlankResult && string.IsNullOrWhiteSpace(SelectInfo.SelectedText)))
                {
                    ReportingValue = SelectInfo.SelectedText.Trim();
                }

                SetParameters();
            }
        }


        private async Task OnTextFocusOutAsync()
        {
            if (SelectInfo.SelectList.Count() == 0)
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
        [JSInvokable("NotifyClosedAsync")]
        public async Task NotifyClosedAsync()
        {
            IsOpen = false;

            SelectInfo.SelectedText = Value;

            if (newSelectItems != null)
            {
                selectItems = newSelectItems;
                newSelectItems = null;
            }

            StateHasChanged();

            await Task.CompletedTask;
        }


        /// <summary>
        /// For Material Theme to notify of menu item selection via JS Interop.
        /// </summary>
        /// <returns></returns>
        [JSInvokable("NotifySelectedAsync")]
        public async Task NotifySelectedAsync(string value)
        {
            ReportingValue = value;

            await NotifyClosedAsync();
        }


        private async Task OpenMenuAsync(bool forceOpen = false)
        {
            if (!IsOpen || forceOpen)
            {
                IsOpen = true;
                await JsRuntime.InvokeAsync<string>("BlazorMdc.autoComplete.open", MenuReference);
            }
        }


        private async Task CloseMenuAsync(bool forceClose = false)
        {
            if (IsOpen || forceClose)
            {
                IsOpen = false;
                await JsRuntime.InvokeAsync<string>("BlazorMdc.autoComplete.close", MenuReference);
            }
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.autoComplete.init", TextField.ElementReference, MenuReference, ObjectReference);
    }
}
