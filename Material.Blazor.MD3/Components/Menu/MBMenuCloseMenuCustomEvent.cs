using Microsoft.AspNetCore.Components;

namespace Material.Blazor.MenuClose;

[EventHandler(
    attributeName: "onmenuclose",
    eventArgsType: typeof(MenuCloseEventArgs),
    enableStopPropagation: true,
    enablePreventDefault: true)]
public static class EventHandlers
{
}
