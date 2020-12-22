using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme segmented button orientated as a single-select.
    /// </summary>
    public partial class MBSegmentedButtonSingle<TItem> : SingleSelectComponentFoundation<TItem, MBIconBearingSelectElement<TItem>>
    {
#nullable enable annotations
        /// <summary>
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// <para>Overrides <see cref="MBCascadingDefaults.ItemValidation"/></para>
        /// </summary>
        [Parameter] public MBItemValidation? ItemValidation { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        private MBSegmentedButtonMulti<TItem> SegmentedButtonMulti { get; set; }

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

            multiValues = new TItem[] { Value };

            SetComponentValue += OnValueSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => SegmentedButtonMulti.SetSingleSelectValue(Value);
    }
}
