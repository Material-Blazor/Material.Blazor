using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc.Components
{
    public partial class MdcSelect<TEnum>
        where TEnum : struct
    {
    }

    public class MdcSelectBase<TEnum>
        where TEnum : struct
    {
        private TEnum _value;
        [Parameter]
        public TEnum Value
        {
            get => _value;
            set
            {
                if (value.ToString() != _value.ToString())
                {
                    _value = value;
                    ValueChanged.InvokeAsync(value);
                }
            }
        }

        [Parameter] public EventCallback<TEnum> ValueChanged { get; set; }

        protected internal string StrValue
        {
            get => Value.ToString();
            set
            {
                Enum.TryParse<TEnum>(value, true, out var result);
                Value = result;
            }
        }


    }
}
