using BMdcFoundation;

using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BMdcPlus
{
    /// <summary>
    /// An autocomplete built using an <see cref="MdcTextField"/> with the anchor and drop
    /// down list implementation from a Material Theme select.
    /// </summary>
    public partial class Autocomplete : InputComponentFoundation<string>, IDisposable
    {
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
        [Parameter] public ETextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public ETextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string Label { get; set; } = "";


        /// <summary>
        /// Hides the label if True. Defaults to False.
        /// </summary>
        [Parameter] public bool NoLabel { get; set; } = false;


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
        [Parameter] public IIconFoundry? IconFoundry { get; set; }


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
        [Parameter] public IEnumerable<string> SelectItems { get; set; }
#nullable restore annotations


        private DotNetObjectReference<Autocomplete> ObjectReference { get; set; }
        private BMdc.TextField TextField { get; set; }
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
        }


        /// <inheritdoc/>
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


        /// <inheritdoc/>
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


        /// <inheritdoc/>
        private async Task OnInput(ChangeEventArgs args)
        {
            SelectInfo = BuildSelectList((string)args.Value);

            if (SelectInfo.FullMatchFound)
            {
                await CloseMenuAsync();
                ReportingValue = SelectInfo.SelectedText.Trim();
                SetParameters();
            }

            await OpenMenuAsync();
        }


        /// <inheritdoc/>
        private async Task OnTextFocusOutAsync()
        {
            await Task.Delay(100);

            if (!MenuHasFocus)
            {
                await CloseMenuAsync(true);

                if (SelectInfo.FullMatchFound || (AllowBlankResult && string.IsNullOrWhiteSpace(SelectInfo.SelectedText)))
                {
                    ReportingValue = SelectInfo.SelectedText.Trim();
                }

                SetParameters();
            }
        }


        /// <inheritdoc/>
        private void OnMenuFocusIn()
        {
            MenuHasFocus = true;
        }


        /// <inheritdoc/>
        private void OnMenuFocusOut()
        {
            MenuHasFocus = false;
        }


        /// <inheritdoc/>
        private async Task OnItemClickAsync(string menuValue)
        {
            await CloseMenuAsync();
            SelectInfo = BuildSelectList(menuValue);
            ReportingValue = menuValue.Trim();
            SetParameters();
        }


        /// <summary>
        /// Called by JS Interop to notify when the drop down is closed.
        /// </summary>
        /// <returns></returns>
        [JSInvokable("NotifyClosedAsync")]
        public async Task NotifyClosedAsync()
        {
            IsOpen = false;
            await Task.CompletedTask;
        }


        private async Task OpenMenuAsync(bool forceOpen = false)
        {
            if (!IsOpen || forceOpen)
            {
                IsOpen = true;
                await JsRuntime.InvokeAsync<string>("BlazorMdc.autoComplete.open", MenuReference, ObjectReference);
            }
        }


        private async Task CloseMenuAsync(bool forceClose = false)
        {
            if (IsOpen || forceClose)
            {
                IsOpen = false;
                await JsRuntime.InvokeAsync<string>("BlazorMdc.autoComplete.close", MenuReference, ObjectReference);
            }
        }


        /// <inheritdoc/>
        protected override bool ShouldRender()
        {
            return true;
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.autoComplete.init", TextField.TextFieldReference);
    }
}
