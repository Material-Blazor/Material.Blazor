using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme select.
    /// </summary>
    public partial class MTSelect<TItem> : ValidatingInputComponentFoundation<TItem>, IMTDialogChild, IDisposable
    {
        /// <summary>
        /// The item list to be represented as a select
        /// </summary>
        [Parameter] public IEnumerable<MTListElement<TItem>> Items { get; set; }


        /// <summary>
        /// The select's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// </summary>
        [Parameter] public MTItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// The select's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The select's <see cref="BlazorMdc.MTSelectInputStyle"/>.
        /// </summary>
        [Parameter] public MTSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The select's <see cref="BlazorMdc.MTTextAlignStyle"/>.
        /// </summary>
        [Parameter] public MTTextAlignStyle? TextAlignStyle { get; set; }


        private ElementReference SelectReference { get; set; }

        private MTSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private string SelectedText { get; set; } = "";

        private string FloatingLabelClass { get; set; } = "";

        private string AlignClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));

        private Dictionary<TItem, MTListElement<TItem>> ItemDict { get; set; }
        
        private DotNetObjectReference<MTSelect<TItem>> ObjectReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityInfo(CascadingDefaults.AppliedSelectDensity(Density));



        private readonly string labelId = Utilities.GenerateUniqueElementName();

        private readonly string listboxId = Utilities.GenerateUniqueElementName();

        private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemDict = Items.ToDictionary(i => i.SelectedValue);

            ReportingValue = ValidateItemList(ItemDict.Values, CascadingDefaults.AppliedItemValidationSelect(ItemValidation));

            ClassMapper
                .Add("mdc-select")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-select--filled", () => AppliedInputStyle == MTSelectInputStyle.Filled)
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == MTSelectInputStyle.Outlined)
                .AddIf("mdc-select--no-label", () => string.IsNullOrWhiteSpace(Label))
                .AddIf("mdc-select--disabled", () => Disabled);

            SelectedText = (Value is null) ? "" : Items.Where(i => object.Equals(i.SelectedValue, Value)).FirstOrDefault().Label;
            FloatingLabelClass = string.IsNullOrWhiteSpace(SelectedText) ? "" : "mdc-floating-label--float-above";

            OnValueSet += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;

            ObjectReference = DotNetObjectReference.Create(this);
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            ObjectReference?.Dispose();
        }


        /// <summary>
        /// For Material Theme to notify of menu item selection via JS Interop.
        /// </summary>
        [JSInvokable("NotifySelectedAsync")]
        public async Task NotifySelectedAsync(int index)
        {
            ReportingValue = ItemDict.Values.ElementAt(index).SelectedValue;
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.setIndex", SelectReference, ItemDict.Keys.ToList().IndexOf(Value)));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.setDisabled", SelectReference, Disabled));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.init", SelectReference, ObjectReference);
    }
}
