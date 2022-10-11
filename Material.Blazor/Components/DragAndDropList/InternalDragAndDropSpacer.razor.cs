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
    /// Gives the separator a distinct with for use between cards.
    /// </summary>
    [Parameter] public bool AutospaceContent { get; set; }


    /// <summary>
    /// True to show the drop zone.
    /// </summary>
    [Parameter] public bool ShowDropZone { get; set; }


    /// <summary>
    /// Action called when item is dropped on this spacer.
    /// </summary>
    [Parameter] public Func<int, Task> DropNotifier { get; set; }


    private string HoverClass { get; set; } = "";
    private string SeparatorClass { get; set; } = "";
    private ElementReference ElementReference { get; set; }
    private bool InitiateDropTarget { get; set; } = false;


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync().ConfigureAwait(false);

        SeparatorClass = "mb-drag-and-drop-list__separator" + (AutospaceContent ? " mb-drag-and-drop-list__autospaced" : "");
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        InitiateDropTarget = ShowDropZone;
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnInitializedAsync().ConfigureAwait(false);

        if (InitiateDropTarget)
        {
            await InvokeJsVoidAsync("MaterialBlazor.MBDragAndDropList.initDropTarget", ElementReference).ConfigureAwait(false);
            InitiateDropTarget = false;
        }
    }


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
