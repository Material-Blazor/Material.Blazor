using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMdc.Internal
{
    /// <summary>
    /// A DRY inspired abstract class providing <see cref="MdcSelect{TItem}"/> and <see cref="PMdcRadioButtonGroup{TItem}"/> with validation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ValidatingInputComponentFoundation<T> : InputComponentFoundation<T>
    {
        // This method was added in the interest of DRY and is used by MdcSelect & PMdcRadioButtonGroup
        /// <summary>
        /// Validates the item list against the validation specification.
        /// </summary>
        /// <param name="items">The item list</param>
        /// <param name="appliedItemValidation">Specification of the required validation <see cref="MTItemValidation"/></param>
        /// <returns>The item in the list matching <see cref="InputComponentFoundation{T}._underlyingValue"/></returns>
        /// <exception cref="ArgumentException"/>
        public T ValidateItemList(IEnumerable<MTListElement<T>> items, MTItemValidation appliedItemValidation)
        {
            var componentName = Utilities.GetTypeName(GetType());
            
            if (items.Count() == 0)
            {
                throw new ArgumentException(componentName + " requires a non-empty Items parameter.");
            }
            if (items.GroupBy(i => i.SelectedValue).Where(g => g.Count() > 1).Count() > 0)
            {
                throw new ArgumentException(componentName + " has multiple enties in the List with the same SelectedValue");
            }

            if (items.Where(i => object.Equals(i.SelectedValue, Value)).Count() == 0)
            {
                switch (appliedItemValidation)
                {
                    case MTItemValidation.DefaultToFirst:
                        var firstOrDefault = items.FirstOrDefault().SelectedValue;
                        return firstOrDefault;

                    case MTItemValidation.Exception:
                        string itemList = "{ ";
                        string prepend = "";

                        foreach (var item in items)
                        {
                            itemList += $"{prepend} '{item.SelectedValue}'";
                            prepend = ",";
                        }

                        itemList += " }";

                        throw new ArgumentException(componentName + $" cannot select item with data value of '{Value?.ToString()}' from {itemList}");

                    case MTItemValidation.NoSelection:
                        return default;
                }
            }

            return Value;
        }
    }
}
