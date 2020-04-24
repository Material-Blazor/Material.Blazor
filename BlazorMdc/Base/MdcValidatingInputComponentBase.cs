using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMdc
{
    public abstract class MdcValidatingInputComponentBase<T> : MdcInputComponentBase<T>
    {
        // This method was added in the interest of DRY and is used by MdcSelect & PMdcRadioButtonGroup
        public async Task ValidateItemListAsync(
            string componentName,
            MdcListElement<T>[] items,
            MdcItemValidation appliedItemValidation,
            Func<T, Task> onItemClickAsync)
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException(componentName + " requires a non-empty Items parameter.");
            }

            if ((appliedItemValidation == MdcItemValidation.DefaultToFirst) && (Value is null || string.IsNullOrEmpty(Value.ToString())))
            {
                await onItemClickAsync(items.FirstOrDefault().SelectedValue);
            }

            var multipleEntriesWithSameValue = false;
            for (int i = 0; i < (items.Count() - 2); i++)
            {
                for (int j = i + 1; j < items.Count(); j++)
                {
                    if (items[i].SelectedValue.Equals(items[j].SelectedValue))
                    {
                        multipleEntriesWithSameValue = true;
                    }
                }
            }

            if (multipleEntriesWithSameValue)
            {
                throw new ArgumentException(componentName + "  has multiple enties in the List with the same SelectedValue");
            }

            if (items.Where(i => object.Equals(i.SelectedValue, Value)).Count() == 0)
            {
                switch (appliedItemValidation)
                {
                    case MdcItemValidation.DefaultToFirst:
                        await onItemClickAsync(items.FirstOrDefault().SelectedValue);
                        break;

                    case MdcItemValidation.Exception:
                        string itemList = "{ ";
                        string prepend = "";

                        foreach (var item in items)
                        {
                            itemList += $"{prepend} '{item.SelectedValue}'";
                            prepend = ",";
                        }

                        itemList += " }";

                        throw new ArgumentException(componentName + $" cannot select item with data value of '{Value?.ToString()}' from {itemList}");

                    case MdcItemValidation.NoSelection:
                        break;
                }
            }
        }
    }

}
