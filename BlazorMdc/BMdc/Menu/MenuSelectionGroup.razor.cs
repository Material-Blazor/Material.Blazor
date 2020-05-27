﻿using Microsoft.AspNetCore.Components;

namespace BMdc
{
    /// <summary>
    /// A Material Theme menu selection group.
    /// </summary>
    public partial class MenuSelectionGroup
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
