using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// A DRY inspired abstract class providing <see cref="MBSelect{TItem}"/> and <see cref="MBRadioButtonGroup{TItem}"/> with validation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MultiSelectComponent<T, TListElement> : InputComponent<IList<T>> where TListElement : MBSelectElement<T>
    {
        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<T, object> GetKeysFunc { get; set; }


        /// <summary>
        /// The item list to be represented as radio buttons
        /// </summary>
        [Parameter] public IEnumerable<TListElement> Items { get; set; }


        /// <summary>
        /// Generates keys for repeated elements in the multi select component.
        /// </summary>
        private protected Func<T, object> KeyGenerator { get; set; }


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


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (T item) { return item; };
        }
    }
}
