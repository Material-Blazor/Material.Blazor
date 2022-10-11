using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// For Material.Blazor internal use only.
/// </summary>
public partial class InternalDragAndDropItem : ComponentFoundation
{
    /// <summary>
    /// The item's index.
    /// </summary>
    [Parameter] public int Index { get; set; }


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


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();


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
