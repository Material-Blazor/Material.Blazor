using System;

namespace Material.Blazor.MenuClose;


/*
** MW3 menu-close event arguments
**
** This must match the ts definition found in material.blazor.custom.events.ts
*/
public class MenuCloseEventArgs : EventArgs
{
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    public string? CustomProperty1 { get; set; }
    public string? CustomProperty2 { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
}
