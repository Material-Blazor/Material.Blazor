using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMdc
{
    /// <summary>
    /// A DRY inspired abstract class providing <see cref="MdcSelect{TItem}"/> and <see cref="PMdcRadioButtonGroup{TItem}"/> with validation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MdcValidatingInputComponentBase<T> : MdcInputComponentBase<T>
    {
        // This method was added in the interest of DRY and is used by MdcSelect & PMdcRadioButtonGroup
        /// <summary>
        /// Validates the item list against the validation specification.
        /// </summary>
        /// <param name="items">The item list</param>
        /// <param name="appliedItemValidation">Specification of the required validation <see cref="MdcItemValidation"/></param>
        /// <returns>The item in the list matching <see cref="MdcInputComponentBase{T}.UnderlyingValue"/></returns>
        /// <exception cref="ArgumentException"/>
        public T ValidateItemList(IEnumerable<MdcListElement<T>> items, MdcItemValidation appliedItemValidation)
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

            if (items.Where(i => object.Equals(i.SelectedValue, UnderlyingValue)).Count() == 0)
            {
                switch (appliedItemValidation)
                {
                    case MdcItemValidation.DefaultToFirst:
                        var firstOrDefault = items.FirstOrDefault().SelectedValue;
                        return firstOrDefault;

                    case MdcItemValidation.Exception:
                        string itemList = "{ ";
                        string prepend = "";

                        foreach (var item in items)
                        {
                            itemList += $"{prepend} '{item.SelectedValue}'";
                            prepend = ",";
                        }

                        itemList += " }";

                        throw new ArgumentException(componentName + $" cannot select item with data value of '{UnderlyingValue?.ToString()}' from {itemList}");

                    case MdcItemValidation.NoSelection:
                        return default;
                }
            }

            return UnderlyingValue;
        }
    }
}
