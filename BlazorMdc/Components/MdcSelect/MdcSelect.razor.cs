using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme select.
    /// </summary>
    public partial class MdcSelect<TItem> : MdcValidatingInputComponentBase<TItem>, IMdcDialogChild
    {
        /// <summary>
        /// The item list to be represented as a select
        /// </summary>
        [Parameter] public IEnumerable<MdcListElement<TItem>> Items { get; set; }


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// </summary>
        [Parameter] public MdcItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// The select's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The select's <see cref="MdcSelectInputStyle"/>.
        /// </summary>
        [Parameter] public MdcSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The select's <see cref="MdcTextAlignStyle"/>.
        /// </summary>
        [Parameter] public MdcTextAlignStyle? TextAlignStyle { get; set; }


        private ElementReference SelectReference { get; set; }
        private ElementReference ListboxReference { get; set; }
        private ElementReference UlReference { get; set; }
        private MdcSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);
        private string SelectedTextId { get; set; } = Utilities.GenerateUniqueElementName();
        private string LabelId { get; set; } = Utilities.GenerateUniqueElementName();
        private string SelectedText { get; set; } = "";
        private string FloatingLabelClass { get; set; } = "";
        private string AlignClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
        private Dictionary<TItem, MdcListElement<TItem>> ItemDict { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemDict = Items.ToDictionary(i => i.SelectedValue);

            ReportingValue = ValidateItemList(ItemDict.Values, CascadingDefaults.AppliedItemValidationSelect(ItemValidation));

            ClassMapper
                .Clear()
                .Add("mdc-select")
                .AddIf("mdc-select--outlined", () => (AppliedInputStyle == MdcSelectInputStyle.Outlined))
                .AddIf("mdc-select--disabled", () => Disabled);

            SelectedText = (Value is null) ? "" : Items.Where(i => object.Equals(i.SelectedValue, Value)).FirstOrDefault().Label;
            FloatingLabelClass = string.IsNullOrWhiteSpace(SelectedText) ? "" : "mdc-floating-label--float-above";
        }


        private async Task OnItemClickAsync(TItem dataValue)
        {
            ReportingValue = dataValue;
            await Task.CompletedTask;
        }


        /// <inheritdoc/>
        protected override void OnValueSet() => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.clickItem", UlReference, ItemDict[Value].Label));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.init", SelectReference);

    }
}
