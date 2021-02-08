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
    public abstract class SingleSelectComponent<T, TListElement> : InputComponent<T> where TListElement : MBSelectElement<T>
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
        /// The form of validation to apply when Value is first set, deciding whether to accept
        /// a value outside the <see cref="Items"/> list, replace it with the first list item or
        /// to throw an exception (the default).
        /// <para>Overrides <see cref="MBCascadingDefaults.ItemValidation"/></para>
        /// </summary>
        [Parameter] public MBItemValidation? ItemValidation { get; set; }


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
        /// <returns>The an indicator of whether an item was found and the item in the list matching <see cref="InputComponent{T}._cachedValue"/> or default if not found.</returns>
        /// <exception cref="ArgumentException"/>
        public (bool hasValue, T value) ValidateItemList(IEnumerable<MBSelectElement<T>> items, MBItemValidation appliedItemValidation)
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

            if (!items.Where(i => Equals(i.SelectedValue, Value)).Any())
            {
                switch (appliedItemValidation)
                {
                    case MBItemValidation.DefaultToFirst:
                        T defaultValue = items.FirstOrDefault().SelectedValue;
                        _ = ValueChanged.InvokeAsync(defaultValue);
                        AllowNextRender = true;
                        return (true, defaultValue);

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
                        _ = ValueChanged.InvokeAsync(default);
                        AllowNextRender = true;
                        return (false, default);
                }
            }

            return (true, Value);
        }
    }
}
