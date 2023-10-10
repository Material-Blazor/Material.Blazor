using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.MD2.Internal;

/// <summary>
/// For Material.Blazor.MD2 internal use only.
/// </summary>
public partial class InternalDragAndDropItem : ComponentFoundationMD2
{
    /// <summary>
    /// The item's index.
    /// </summary>
    [Parameter] public int Index { get; set; }


    /// <summary>
    /// Adds padding to user supplied content if true.
    /// </summary>
    [Parameter] public bool AutospaceContent { get; set; }


    /// <summary>
    /// The item's render fragment.
    /// </summary>
    [Parameter] public RenderFragment ChildContent { get; set; }


    /// <summary>
    /// Action called when item is dropped on this spacer.
    /// </summary>
    [Parameter] public Action<int> DragStartNotifier { get; set; }


    /// <summary>
    /// Action called when item is dropped on this spacer.
    /// </summary>
    [Parameter] public Action DragEndNotifier { get; set; }


    private string UserContentClass { get; set; } = "";


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.MD2
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync().ConfigureAwait(false);

        UserContentClass = "mb-drag-and-drop-list__user-content" + (AutospaceContent ? " mb-card__autostyled" : "");
    }


    private void OnDragStart()
    {
        DragStartNotifier(Index);
    }


    private void OnDragEnd()
    {
        DragEndNotifier();
    }
}
