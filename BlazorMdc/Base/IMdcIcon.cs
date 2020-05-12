﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    public interface IMdcIcon
    {
        public string Class { get; }

        public string Text { get; }

        public string IconName { get; }

        public bool RequiresWhiteFilter { get; }
    }
}
