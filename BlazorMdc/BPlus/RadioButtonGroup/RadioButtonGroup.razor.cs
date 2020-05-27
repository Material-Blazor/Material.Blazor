using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace BPlus
{
    /// <summary>
    /// A group of <see cref="MdcRadioButton{TItem}"/>s displayed horizontally or vertically.
    /// </summary>
    public partial class RadioButtonGroup<TItem> : BBase.ValidatingInputComponentBase<TItem>
    {
        /// <summary>
        /// The item list to be represented as radio buttons
        /// </summary>
        [Parameter] public IEnumerable<BModel.ListElement<TItem>> Items { get; set; }


        /// <summary>
        /// Stack the radio buttons vertically if True, otherwise default horizontal placement.
        /// </summary>
        [Parameter] public bool Vertical { get; set; } = false;


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// </summary>
        [Parameter] public BEnum.ItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// Enables the Material Theme touch wrapper.
        /// </summary>
        [Parameter] public bool EnableTouchWrapper { get; set; } = true;


        private bool IsNotFirst { get;  set; } = false;
        private string RadioGroupName { get; set; } = BBase.Utilities.GenerateUniqueElementName();
        private BModel.ListElement<TItem>[] ItemArray { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemArray = Items.ToArray();

            BEnum.ItemValidation appliedItemValidation = CascadingDefaults.AppliedItemValidationRadioButtonGroup(ItemValidation);

            ForceShouldRenderToTrue = true;

            ReportingValue = ValidateItemList(ItemArray, appliedItemValidation);
        }
    }
}
