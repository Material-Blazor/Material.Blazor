using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorMdc
{

    public class ListElement<T>
    {
        public T CheckedValue { get; set; }
        public string Label { get; set; }
        public string ButtonContainerClass { get; set; }
        public bool Disabled { get; set; } = false;
    }


}
