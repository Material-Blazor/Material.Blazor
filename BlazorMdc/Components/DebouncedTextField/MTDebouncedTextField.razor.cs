using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

using System;
using System.Threading;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme debounced text field.
    /// </summary>
    public partial class MTDebouncedTextField : InputComponentFoundation<string>
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// <para>Overrides <see cref="MTCascadingDefaults.TextInputStyle"/></para>
        /// </summary>
        [Parameter] public MTTextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// <para>Overrides <see cref="MTCascadingDefaults.TextAlignStyle"/></para>
        /// </summary>
        [Parameter] public MTTextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string? Label { get; set; }


        /// <summary>
        /// Prefix text.
        /// </summary>
        [Parameter] public string? Prefix { get; set; }


        /// <summary>
        /// Suffix text.
        /// </summary>
        [Parameter] public string? Suffix { get; set; }


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
        /// <para>Overrides <see cref="MTCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// The text field's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


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


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        private bool _disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                Timer?.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }


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
