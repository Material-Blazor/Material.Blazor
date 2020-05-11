using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    internal interface IIconBase
    {
        public string Class { get; }

        public string Text { get; }

        public string IconName { get; }
    }
}
