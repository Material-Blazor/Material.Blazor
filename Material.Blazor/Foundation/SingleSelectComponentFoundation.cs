using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// A DRY inspired abstract class providing <see cref="MBSelect{TItem}"/> and <see cref="MBRadioButtonGroup{TItem}"/> with validation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SingleSelectComponentFoundation<T, TListElement> : InputComponentFoundation<T> where TListElement : MBSelectElement<T>
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
        /// Generates keys for repeated elements in the single select list.
        /// </summary>
        private protected Func<T, object> KeyGenerator { get; set; }


        // This method was added in the interest of DRY and is used by MBSelect & MBRadioButtonGroup
        /// <summary>
        /// Validates the item list against the validation specification.
        /// </summary>
        /// <param name="items">The item list</param>
        /// <param name="appliedItemValidation">Specification of the required validation <see cref="MBItemValidation"/></param>
        /// <returns>The item in the list matching <see cref="InputComponentFoundation{T}._cachedValue"/></returns>
        /// <exception cref="ArgumentException"/>
        public T ValidateItemList(IEnumerable<MBSelectElement<T>> items, MBItemValidation appliedItemValidation)
        {
            var componentName = Utilities.GetTypeName(GetType());
            
            if (!items.Any())
            {
                throw new ArgumentException(componentName + " requires a non-empty Items parameter.");
            }
            
            if (items.GroupBy(i => i.SelectedValue).Where(g => g.Count() > 1).Any())
            {
                throw new ArgumentException(componentName + " has multiple enties in the List with the same SelectedValue");
            }

            if (!items.Where(i => object.Equals(i.SelectedValue, Value)).Any())
            {
                switch (appliedItemValidation)
                {
                    case MBItemValidation.DefaultToFirst:
                        var firstOrDefault = items.FirstOrDefault().SelectedValue;
                        return firstOrDefault;

                    case MBItemValidation.Exception:
                        string itemList = "{ ";
                        string prepend = "";

                        foreach (var item in items)
                        {
                            itemList += $"{prepend} '{item.SelectedValue}'";
                            prepend = ",";
                        }

                        itemList += " }";

                        throw new ArgumentException(componentName + $" cannot select item with data value of '{Value?.ToString()}' from {itemList}");

                    case MBItemValidation.NoSelection:
                        return default;
                }
            }

            return Value;
        }
    }
}
