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
#nullable enable annotations
        /// <summary>
        /// The item list to be represented as a select
        /// </summary>
        [Parameter] public IEnumerable<MTListElement<TItem>> Items { get; set; }


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// <para>Overrides <see cref="MTCascadingDefaults.ItemValidation"/></para>
        /// </summary>
        [Parameter] public MTItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// The select's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The select's <see cref="BlazorMdc.MTSelectInputStyle"/>.
        /// <para>Overrides <see cref="MTCascadingDefaults.SelectInputStyle"/></para>
        /// </summary>
        [Parameter] public MTSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The select's <see cref="BlazorMdc.MTTextAlignStyle"/>.
        /// <para>Overrides <see cref="MTCascadingDefaults.TextAlignStyle"/></para>
        /// </summary>
        [Parameter] public MTTextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// The leading icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MTCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// The select's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }
#nullable restore annotations


        private ElementReference SelectReference { get; set; }

        private MTSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private MTDensity AppliedDensity => CascadingDefaults.AppliedSelectDensity(Density);

        private string SelectedText { get; set; } = "";

        private string FloatingLabelClass { get; set; } = "";

        private string AlignClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));

        private Dictionary<TItem, MTListElement<TItem>> ItemDict { get; set; }

        private DotNetObjectReference<MTSelect<TItem>> ObjectReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo
        {
            get
            {
                var d = CascadingDefaults.GetDensityInfo(AppliedDensity);

                var suffix = AppliedInputStyle == MTSelectInputStyle.Filled ? "--filled" : "--outlined";
                suffix += string.IsNullOrWhiteSpace(LeadingIcon) ? "" : "-with-leading-icon";

                d.CssClassName += suffix;

                return d;
            }
        }

        private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);



        private readonly string labelId = Utilities.GenerateUniqueElementName();

        private readonly string listboxId = Utilities.GenerateUniqueElementName();

        private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemDict = Items.ToDictionary(i => i.SelectedValue);

            ReportingValue = ValidateItemList(ItemDict.Values, CascadingDefaults.AppliedItemValidation(ItemValidation));

            ClassMapper
                .Add("mdc-select")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-select--filled", () => AppliedInputStyle == MTSelectInputStyle.Filled)
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == MTSelectInputStyle.Outlined)
                .AddIf("mdc-select--no-label", () => !ShowLabel)
                .AddIf("mdc-select--with-leading-icon", () => !string.IsNullOrWhiteSpace(LeadingIcon))
                .AddIf("mdc-select--disabled", () => AppliedDisabled);

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
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.setDisabled", SelectReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.select.init", SelectReference, ObjectReference);
    }
}
