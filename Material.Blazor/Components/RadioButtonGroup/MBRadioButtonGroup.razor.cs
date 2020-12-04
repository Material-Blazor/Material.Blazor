using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor
{
    /// <summary>
    /// A group of <see cref="MBRadioButton{TItem}"/>s displayed horizontally or vertically.
    /// </summary>
    public partial class MBRadioButtonGroup<TItem> : ValidatingInputComponentFoundation<TItem>
    {
        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


        /// <summary>
        /// The item list to be represented as radio buttons
        /// </summary>
        [Parameter] public IEnumerable<MBListElement<TItem>> Items { get; set; }


        /// <summary>
        /// The radio button's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        /// <summary>
        /// Stack the radio buttons vertically if True, otherwise default horizontal placement.
        /// </summary>
        [Parameter] public bool Vertical { get; set; } = false;


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// <para>Overrides <see cref="MBCascadingDefaults.ItemValidation"/></para>
        /// </summary>
        [Parameter] public MBItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// Enables the Material Theme touch wrapper.
        /// </summary>
        [Parameter] public bool EnableTouchWrapper { get; set; } = true;


        private MBListElement<TItem>[] ItemArray { get; set; }
        private Func<TItem, object> KeyGenerator { get; set; }
        private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemArray = Items.ToArray();

            MBItemValidation appliedItemValidation = CascadingDefaults.AppliedItemValidation(ItemValidation);

            ForceShouldRenderToTrue = true;

            ComponentValue = ValidateItemList(ItemArray, appliedItemValidation);

            ClassMapperInstance.AddIf("mb-mdc-radio-group-vertical", () => Vertical);
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
        }
    }
}
