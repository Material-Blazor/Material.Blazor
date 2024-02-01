using System;

namespace Material.Blazor;


/*
** MW3 menu-close event arguments
**
** This must match the ts definition found in material.blazor.custom.events.ts
*/
public class MenuSelectionReportEventArgs : EventArgs
{
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    public string? menuID { get; set; }
    public string? menuHeadline { get; set; }
    public string? reason { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
}
