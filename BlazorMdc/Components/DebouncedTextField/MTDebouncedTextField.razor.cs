using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

using System;
using System.Threading;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme debounced text field.
    /// </summary>
    public partial class MTDebouncedTextField : MTInputComponentBase<string>, IDisposable
    {
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
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Debounce interval in milliseconds.
        /// </summary>
        [Parameter] public int? DebounceInterval { get; set; }
#nullable restore annotations


        private Timer Timer { get; set; }
        private string CurrentValue { get; set; } = "";
        private int AppliedDebounceInterval => CascadingDefaults.AppliedDebounceInterval(DebounceInterval);


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();
            CurrentValue = Value;
        }


        /// <inheritdoc/>
        public void Dispose() => Timer?.Dispose();


        private void OnTextInput(ChangeEventArgs eventArgs)
        {
            Timer?.Dispose();
            CurrentValue = eventArgs.Value.ToString();
            var autoReset = new AutoResetEvent(false);
            Timer = new Timer(OnTimerComplete, autoReset, AppliedDebounceInterval, Timeout.Infinite);
        }


        private void OnTimerComplete(object stateInfo) => InvokeAsync(() => ReportingValue = CurrentValue);
    }
}
