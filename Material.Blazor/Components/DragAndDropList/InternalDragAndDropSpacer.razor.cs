using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// For Material.Blazor internal use only.
/// </summary>
public partial class InternalDragAndDropSpacer : ComponentFoundation
{
    /// <summary>
    /// The spacer's index.
    /// </summary>
    [Parameter] public int Index { get; set; }


    /// <summary>
    /// True to show the drop zone.
    /// </summary>
    [Parameter] public bool ShowDropZone { get; set; }


    /// <summary>
    /// Action called when item is dropped on this spacer.
    /// </summary>
    [Parameter] public Func<int, Task> DropNotifier { get; set; }


    private string HoverClass { get; set; } = "";


    private void OnDragEnter()
    {
        HoverClass = "mb-drag-and-drop-list__hover";
        _ = InvokeAsync(StateHasChanged);
    }


    private void OnDragLeave()
    {
        HoverClass = string.Empty;
        _ = InvokeAsync(StateHasChanged);
    }


    private async Task OnDropAsync()
    {
        HoverClass = string.Empty;
        await DropNotifier(Index).ConfigureAwait(false);
    }
}
