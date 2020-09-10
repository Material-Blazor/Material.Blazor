using BlazorMdc.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMdc
{
    /// <summary>
    /// A group of <see cref="MTRadioButton{TItem}"/>s displayed horizontally or vertically.
    /// </summary>
    public partial class MTRadioButtonGroup<TItem> : ValidatingInputComponentFoundation<TItem>
    {
        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


        /// <summary>
        /// The item list to be represented as radio buttons
        /// </summary>
        [Parameter] public IEnumerable<MTListElement<TItem>> Items { get; set; }


        /// <summary>
        /// The radio button's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        /// <summary>
        /// Stack the radio buttons vertically if True, otherwise default horizontal placement.
        /// </summary>
        [Parameter] public bool Vertical { get; set; } = false;


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// <para>Overrides <see cref="MTCascadingDefaults.ItemValidation"/></para>
        /// </summary>
        [Parameter] public MTItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// Enables the Material Theme touch wrapper.
        /// </summary>
        [Parameter] public bool EnableTouchWrapper { get; set; } = true;


        private MTListElement<TItem>[] ItemArray { get; set; }
        private Func<TItem, object> KeyGenerator { get; set; }
        private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemArray = Items.ToArray();

            MTItemValidation appliedItemValidation = CascadingDefaults.AppliedItemValidation(ItemValidation);

            ForceShouldRenderToTrue = true;

            ReportingValue = ValidateItemList(ItemArray, appliedItemValidation);

            ClassMapper.AddIf("bmdc-mdc-radio-group-vertical", () => Vertical);
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
        }
    }
}
