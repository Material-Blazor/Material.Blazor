using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme segmented button orientated as a multi-select.
    /// </summary>
    public partial class MBChipsSelectMulti<TItem> : MultiSelectComponentFoundation<TItem, MBIconBearingSelectElement<TItem>>
    {
        /// <summary>
        /// If this component is rendered inside a single-select segmented button, add the "" class.
        /// </summary>
        [CascadingParameter] private MBSegmentedButtonSingle<TItem> ChipsSelectSingle { get; set; }


        private MBIconBearingSelectElement<TItem>[] ItemsArray { get; set; }
        private bool IsSingleSelect { get; set; }
        private IDisposable ObjectReference { get; set; }
        private Dictionary<string, object>[] ChipSpanAttributes { get; set; }
        private ElementReference ChipsReference { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            IsSingleSelect = ChipsSelectSingle != null;

            ClassMapperInstance
                .Add("mdc-chip-set")
                .AddIf("mdc-chip-set--filter", () => !IsSingleSelect)
                .AddIf("mdc-chip-set--choice", () => IsSingleSelect);

            ItemsArray = Items.ToArray();

            ChipSpanAttributes = new Dictionary<string, object>[ItemsArray.Length];

            for (int i = 0; i < ItemsArray.Length; i++)
            {
                ChipSpanAttributes[i] = new();

                var selected = Value.Contains(ItemsArray[i].SelectedValue);

                ChipSpanAttributes[i].Add("class", "mdc-chip__primary-action");
                ChipSpanAttributes[i].Add("tabindex", "0");

                if (IsSingleSelect)
                {
                    ChipSpanAttributes[i].Add("role", "button");
                }
                else
                {
                    ChipSpanAttributes[i].Add("role", "checkbox");
                    ChipSpanAttributes[i].Add("aria-checked", selected.ToString().ToLower());
                }
            }

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;

            ObjectReference = DotNetObjectReference.Create(this);
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
            }

            _disposed = true;

            base.Dispose(disposing);
        }


        /// <summary>
        /// For Material Theme to notify of menu item selection via JS Interop.
        /// </summary>
        [JSInvokable("NotifyMultiSelectedAsync")]
        public async Task NotifyMultiSelectedAsync(bool[] selected)
        {
            var selectedIndexes = Enumerable.Range(0, selected.Length).Where(i => selected[i]);
            ComponentValue = ItemsArray.Where((item, index) => selectedIndexes.Contains(index)).Select(x => x.SelectedValue).ToArray();
            await Task.CompletedTask;
        }


        /// <summary>
        /// For Material Theme to notify of menu item selection via JS Interop.
        /// </summary>
        [JSInvokable("NotifySingleSelectedAsync")]
        public async Task NotifySingleSelectedAsync(int index)
        {
            ComponentValue = new TItem[] { ItemsArray[index].SelectedValue };
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBChipsSelectMulti.setSelected", ChipsReference, Items.Select(x => Value.Contains(x.SelectedValue)).ToArray()));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBChipsSelectMulti.setDisabled", ChipsReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBChipsSelectMulti.init", ChipsReference, IsSingleSelect, ObjectReference);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBChipsSelectMulti.destroy", ChipsReference);


        /// <summary>
        /// Used by <see cref="MBSegmentedButtonSingle{TItem}"/> to set the value.
        /// </summary>
        /// <param name="value"></param>
        internal void SetSingleSelectValue(TItem value)
        {
            Value = new TItem[] { value };
            OnValueSetCallback(this, null);
        }
    }
}
