using Microsoft.AspNetCore.Components;
using Material.Blazor.Internal;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.ComponentModel;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme segmented button orientated as a multi-select.
    /// </summary>
    public partial class MBSegmentedButtonMulti<TItem> : InputComponentFoundation<IList<TItem>>// where TList : IList<TItem>
    {
#nullable enable annotations
        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<IList<TItem>, object> GetKeysFunc { get; set; }


        /// <summary>
        /// The item list to be represented as a select
        /// </summary>
        [Parameter] public IEnumerable<MBSegmentedButtonElement<IList<TItem>>> Items { get; set; }


        ///// <summary>
        ///// The form of validation to apply when Value is first set, deciding whether to accept
        ///// a value outside the <see cref="Items"/> list, replace it with the first list item or
        ///// to throw an exception (the default).
        ///// <para>Overrides <see cref="MBCascadingDefaults.ItemValidation"/></para>
        ///// </summary>
        //[Parameter] public MBItemValidation? ItemValidation { get; set; }


        ///// <summary>
        ///// The select's label.
        ///// </summary>
        //[Parameter] public string Label { get; set; }


        ///// <summary>
        ///// The select's <see cref="MBSelectInputStyle"/>.
        ///// <para>Overrides <see cref="MBCascadingDefaults.SelectInputStyle"/></para>
        ///// </summary>
        //[Parameter] public MBSelectInputStyle? SelectInputStyle { get; set; }


        ///// <summary>
        ///// The select's <see cref="MBTextAlignStyle"/>.
        ///// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
        ///// </summary>
        //[Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }


        ///// <summary>
        ///// The leading icon's name. No leading icon shown if not set.
        ///// </summary>
        //[Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        //private readonly string labelId = Utilities.GenerateUniqueElementName();
        //private readonly string listboxId = Utilities.GenerateUniqueElementName();
        //private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


        //private Dictionary<TItem, MBSegmentedButtonElement<TItem>> ItemDict { get; set; }
        private Func<IList<TItem>, object> KeyGenerator { get; set; }
        private IDisposable ObjectReference { get; set; }
        //private object ObjectReference;
        private ElementReference SegmentedButtonReference { get; set; }
        //private string SelectedText { get; set; } = "";


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            //ItemDict = Value.ToDictionary(i => i.SelectedValue);

            ClassMapperInstance
                .Add("mdc-segmented-button");

            //SelectedText = (Value is null) ? "" : Value.Where(i => object.Equals(i.SelectedValue, Value)).FirstOrDefault().Label;

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;

            ObjectReference = DotNetObjectReference.Create(this);
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (IList<TItem> items) { return items; };
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
        [JSInvokable("NotifySelectedAsync")]
        public async Task NotifySelectedAsync(IList<TItem> pressedStates)
        {
            //var arr = ItemDict.Values.ToArray();

            //for (int i = 0; i < pressedStates.Length; i++)
            //{
            //    arr[i].IsSelected = pressedStates[i];
            //}

            ComponentValue = pressedStates;
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButton.setSelected", SegmentedButtonReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButton.setDisabled", SegmentedButtonReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButton.init", SegmentedButtonReference, ObjectReference);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSegmentedButton.destroy", SegmentedButtonReference);
    }
}
