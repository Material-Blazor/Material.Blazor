﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public record MBMenuItem
    {
        #region members

        public string Headline { get; set; } = "";
        public string HeadlineColor { get; set; } = "black";
        public string Identifier { get; set; } = "";
        public bool IsDisabled { get; set; } = false;
        public MBMenuItemType ItemType { get; set; } = MBMenuItemType.Regular;
        public MBIconDescriptor LeadingIcon { get; set; } = null;
        public bool SuppressLeadingIcon { get; set; } = false;
        public MBIconDescriptor TrailingIcon { get; set; } = null;

        #endregion
    }
}
