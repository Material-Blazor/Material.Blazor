﻿using BMdcFoundation;
using BMdcModel;
using Microsoft.AspNetCore.Components;

using System.Collections.Generic;
using System.Linq;

namespace BMdcPlus
{
    /// <summary>
    /// A group of <see cref="MdcRadioButton{TItem}"/>s displayed horizontally or vertically.
    /// </summary>
    public partial class RadioButtonGroup<TItem> : ValidatingInputComponentFoundation<TItem>
    {
        /// <summary>
        /// The item list to be represented as radio buttons
        /// </summary>
        [Parameter] public IEnumerable<ListElement<TItem>> Items { get; set; }


        /// <summary>
        /// Stack the radio buttons vertically if True, otherwise default horizontal placement.
        /// </summary>
        [Parameter] public bool Vertical { get; set; } = false;


        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// </summary>
        [Parameter] public EItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// Enables the Material Theme touch wrapper.
        /// </summary>
        [Parameter] public bool EnableTouchWrapper { get; set; } = true;


        private bool IsNotFirst { get;  set; } = false;
        private string RadioGroupName { get; set; } = Utilities.GenerateUniqueElementName();
        private ListElement<TItem>[] ItemArray { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ItemArray = Items.ToArray();

            EItemValidation appliedItemValidation = CascadingDefaults.AppliedItemValidationRadioButtonGroup(ItemValidation);

            ForceShouldRenderToTrue = true;

            ReportingValue = ValidateItemList(ItemArray, appliedItemValidation);
        }
    }
}
