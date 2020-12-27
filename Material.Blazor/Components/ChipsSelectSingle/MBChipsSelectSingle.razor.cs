using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme segmented button orientated as a single-select.
    /// </summary>
    public partial class MBChipsSelectSingle<TItem> : SingleSelectComponent<TItem, MBIconBearingSelectElement<TItem>>
    {
#nullable enable annotations
        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        private MBChipsSelectMulti<TItem> ChipsSelectMulti { get; set; }

        private IList<TItem> multiValues;
        private IList<TItem> MultiValues
        {
            get => multiValues;
            set
            {
                multiValues = value;
                ComponentValue = multiValues.FirstOrDefault();
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();


            MBItemValidation appliedItemValidation = CascadingDefaults.AppliedItemValidation(ItemValidation);

            bool hasValue;
            (hasValue, ComponentValue) = ValidateItemList(Items, appliedItemValidation);

            multiValues = new TItem[] { Value };

            SetComponentValue += OnValueSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => ChipsSelectMulti.SetSingleSelectValue(Value);
    }
}
