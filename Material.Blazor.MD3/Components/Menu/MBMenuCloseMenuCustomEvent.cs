using Microsoft.AspNetCore.Components;

namespace Material.Blazor.MenuClose;

[EventHandler("onmenu-close",
    typeof(MenuCloseEventArgs),
    enableStopPropagation: true,
    enablePreventDefault: true)]
public static class EventHandlers
{
}
