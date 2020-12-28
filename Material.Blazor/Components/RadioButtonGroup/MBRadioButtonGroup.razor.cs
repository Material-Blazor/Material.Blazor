using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// A group of <see cref="MBRadioButton{TItem}"/>s displayed horizontally or vertically.
    /// </summary>
    public partial class MBRadioButtonGroup<TItem> : SingleSelectComponent<TItem, MBSelectElement<TItem>>
    {
        /// <summary>
        /// The radio button's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        /// <summary>
        /// Stack the radio buttons vertically if True, otherwise default horizontal placement.
        /// </summary>
        [Parameter] public bool Vertical { get; set; } = false;


        private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            MBItemValidation appliedItemValidation = CascadingDefaults.AppliedItemValidation(ItemValidation);

            ForceShouldRenderToTrue = true;

            bool hasValue;

            (hasValue, ComponentValue) = ValidateItemList(Items, appliedItemValidation);

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
