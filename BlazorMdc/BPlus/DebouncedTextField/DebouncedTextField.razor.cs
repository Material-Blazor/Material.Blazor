using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading;

namespace BPlus
{
    /// <summary>
    /// A Material Theme debounced text field.
    /// </summary>
    public partial class DebouncedTextField : BBase.InputComponentBase<string>, IDisposable
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public BEnum.TextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public BEnum.TextAlignStyle? TextAlignStyle { get; set; }


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
        /// <para><c>IconFoundry="BModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BModel.IIconFoundry? IconFoundry { get; set; }


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
