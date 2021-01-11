using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme select.
    /// </summary>
    public partial class MBSelect<TItem> : SingleSelectComponent<TItem, MBSelectElement<TItem>>
    {
#nullable enable annotations
        /// <summary>
        /// The select's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The select's <see cref="MBSelectInputStyle"/>.
        /// <para>Overrides <see cref="MBCascadingDefaults.SelectInputStyle"/></para>
        /// </summary>
        [Parameter] public MBSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// Regular, fullwidth or fixed positioning/width.
        /// </summary>
        [Parameter] public MBMenuSurfacePositioning MenuSurfacePositioning { get; set; } = MBMenuSurfacePositioning.Regular;


        /// <summary>
        /// The select's <see cref="MBTextAlignStyle"/>.
        /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
        /// </summary>
        [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// The leading icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// The select's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }
#nullable restore annotations


        private readonly string labelId = Utilities.GenerateUniqueElementName();
        private readonly string listboxId = Utilities.GenerateUniqueElementName();
        private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


        private string AlignClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
        private MBDensity AppliedDensity => CascadingDefaults.AppliedSelectDensity(Density);
        private MBSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);
        private string FloatingLabelClass { get; set; } = "";
        private Dictionary<TItem, MBSelectElement<TItem>> ItemDict { get; set; }
        private string MenuClass => MBMenu.GetMenuSurfacePositioningClass(MenuSurfacePositioning);
        private DotNetObjectReference<MBSelect<TItem>> ObjectReference { get; set; }
        private ElementReference SelectReference { get; set; }
        private string SelectedText { get; set; } = "";
        private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);


        private MBCascadingDefaults.DensityInfo DensityInfo
        {
            get
            {
                var d = CascadingDefaults.GetDensityCssClass(AppliedDensity);

                var suffix = AppliedInputStyle == MBSelectInputStyle.Filled ? "--filled" : "--outlined";
                suffix += string.IsNullOrWhiteSpace(LeadingIcon) ? "" : "-with-leading-icon";

                d.CssClassName += suffix;

                return d;
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemDict = Items.ToDictionary(i => i.SelectedValue);

            bool hasValue;

            (hasValue, ComponentValue) = ValidateItemList(ItemDict.Values, CascadingDefaults.AppliedItemValidation(ItemValidation));

            ClassMapperInstance
                .Add("mdc-select")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-select--filled", () => AppliedInputStyle == MBSelectInputStyle.Filled)
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == MBSelectInputStyle.Outlined)
                .AddIf("mdc-select--no-label", () => !ShowLabel)
                .AddIf("mdc-select--with-leading-icon", () => !string.IsNullOrWhiteSpace(LeadingIcon))
                .AddIf("mdc-select--disabled", () => AppliedDisabled);

            SelectedText = hasValue ? Items.Where(i => object.Equals(i.SelectedValue, ComponentValue)).FirstOrDefault().Label : "";
            FloatingLabelClass = string.IsNullOrWhiteSpace(SelectedText) ? "" : "mdc-floating-label--float-above";

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;

            ObjectReference = DotNetObjectReference.Create(this);
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
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
        public async Task NotifySelectedAsync(int index)
        {
            ComponentValue = ItemDict.Values.ElementAt(index).SelectedValue;
            await Task.CompletedTask;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSelect.setIndex", SelectReference, ItemDict.Keys.ToList().IndexOf(Value)));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSelect.setDisabled", SelectReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSelect.init", SelectReference, ObjectReference);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSelect.destroy", SelectReference);
    }
}
