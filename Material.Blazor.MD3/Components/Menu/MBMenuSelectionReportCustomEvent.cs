using Microsoft.AspNetCore.Components;

namespace Material.Blazor.MenuClose;

[EventHandler(
    attributeName: "onmenuselectionreport",
    eventArgsType: typeof(MenuSelectionReportEventArgs),
    enableStopPropagation: false,
    enablePreventDefault: false)]
public static class EventHandlers
{
}
