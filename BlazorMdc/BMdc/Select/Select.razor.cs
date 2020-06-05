using BMdcFoundation;

using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// A Material Theme select.
    /// </summary>
    public partial class Select<TItem> : ValidatingInputComponentFoundation<TItem>, IDialogChild
    {
        /// <summary>
        /// The item list to be represented as a select
        /// </summary>
        [Parameter] public IEnumerable<ListElement<TItem>> Items { get; set; }


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// </summary>
        [Parameter] public EItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// The select's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The select's <see cref="BlazorMdc.SelectInputStyle"/>.
        /// </summary>
        [Parameter] public ESelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The select's <see cref="BlazorMdc.TextAlignStyle"/>.
        /// </summary>
        [Parameter] public ETextAlignStyle? TextAlignStyle { get; set; }


        private ElementReference SelectReference { get; set; }
        private ElementReference ListboxReference { get; set; }
        private ElementReference UlReference { get; set; }
        private ESelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);
        private string SelectedTextId { get; set; } = BMdcFoundation.Utilities.GenerateUniqueElementName();
        private string LabelId { get; set; } = BMdcFoundation.Utilities.GenerateUniqueElementName();
        private string SelectedText { get; set; } = "";
        private string FloatingLabelClass { get; set; } = "";
        private string AlignClass => BMdcFoundation.Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
        private Dictionary<TItem, ListElement<TItem>> ItemDict { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemDict = Items.ToDictionary(i => i.SelectedValue);

            ReportingValue = ValidateItemList(ItemDict.Values, CascadingDefaults.AppliedItemValidationSelect(ItemValidation));

            ClassMapper
                .Add("mdc-select")
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == ESelectInputStyle.Outlined)
                .AddIf("mdc-select--disabled", () => Disabled);

            SelectedText = (Value is null) ? "" : Items.Where(i => object.Equals(i.SelectedValue, Value)).FirstOrDefault().Label;
            FloatingLabelClass = string.IsNullOrWhiteSpace(SelectedText) ? "" : "mdc-floating-label--float-above";

            OnValueSet += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;
        }


        private async Task OnItemClickAsync(TItem dataValue)
        {
            ReportingValue = dataValue;
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.clickItem", UlReference, ItemDict[Value].Label));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.setDisabled", SelectReference, Disabled));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.init", SelectReference);
    }
}
