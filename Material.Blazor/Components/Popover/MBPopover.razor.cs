using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// Similar to <see cref="MBMenuSurface"/> in functionality, but with lazy rendering and
/// late instantiation of layout children as per <see cref="MBDialog"/>.
/// </summary>
public partial class MBPopover : ComponentFoundation, IMBLayoutParent
{
    /// <summary>
    /// A render fragement as a set of <see cref="MBListItem"/>s.
    /// </summary>
    [Parameter] public RenderFragment ChildContent { get; set; }


    /// <summary>
    /// Regular, fullwidth or fixed positioning/width.
    /// </summary>
    [Parameter] public MBMenuSurfacePositioning MenuSurfacePositioning { get; set; } = MBMenuSurfacePositioning.Regular;


    /// <summary>
    /// Called when the menu is opened.
    /// </summary>
    [Parameter] public Action OnMenuOpened { get; set; }


    /// <summary>
    /// Called when the menu is closed.
    /// </summary>
    [Parameter] public Action OnMenuClosed { get; set; }


    private DotNetObjectReference<MBPopover> ObjectReference { get; set; }
    private ElementReference ElementReference { get; set; }
    private List<ComponentFoundation> LayoutChildren { get; set; } = new List<ComponentFoundation>();


    private bool AfterPopoverInitialization { get; set; } = false;
    private bool IsOpen { get; set; }
    private bool IsOpening { get; set; }

    private bool _hasInstantiated = false;
    bool IMBLayoutParent.HasInstantiated => _hasInstantiated;


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _ = ConditionalCssClasses
            .AddIf(GetMenuSurfacePositioningClass(MenuSurfacePositioning), () => MenuSurfacePositioning != MBMenuSurfacePositioning.Regular);

        ObjectReference = DotNetObjectReference.Create(this);
    }


    private bool _disposed = false;
    protected override void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            ObjectReference?.Dispose();
        }

        _disposed = true;

        base.Dispose(disposing);
    }


    /// <inheritdoc/>
    void IMBLayoutParent.RegisterLayoutAction(ComponentFoundation child)
    {
        LayoutChildren.Add(child);
    }


    /// <summary>
    /// Shows the popover. This first renders the Blazor markup and then allows
    /// Material Theme to open the popover, subsequently initiating all embedded Blazor components.
    /// </summary>
    /// <returns>The action string resulting from dialog closure</returns>
    public async Task ShowAsync()
    {
        if (IsOpen)
        {
            throw new InvalidOperationException("Cannot show MBPopover that is already open");
        }
        else
        {
            LayoutChildren.Clear();
            _hasInstantiated = false;
            IsOpen = true;
            IsOpening = true;
            await InvokeAsync(StateHasChanged);
        }
    }



    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (IsOpening)
        {
            IsOpening = false;
            await InvokeShowAsync();
        }
        else if (AfterPopoverInitialization)
        {
            _hasInstantiated = true;
            AfterPopoverInitialization = false;

            foreach (var child in LayoutChildren)
            {
                EnqueueJSInteropAction(child.InstantiateMcwComponent);
            }
        }
    }


    /// <summary>
    /// Invokes the javascript code to open the dialog.
    /// </summary>
    private async Task InvokeShowAsync()
    {
        try
        {
            await InvokeJsVoidAsync("MaterialBlazor.MBPopover.show", ElementReference, ObjectReference);
        }
        catch
        {
            // do nothing
        }
    }


    /// <summary>
    /// Hides the dialog first by allowing Material Theme to close it gracefully, then
    /// removing the Blazor markup.
    /// </summary>
    public async Task HideAsync()
    {
        if (IsOpen)
        {
            await InvokeJsVoidAsync("MaterialBlazor.MBPopover.hide", ElementReference);
        }
        else
        {
            throw new InvalidOperationException("Cannot hide MBPopover that is not already open");
        }
    }


    /// <summary>
    /// For Material Theme to notify of menu closure via JS Interop.
    /// </summary>
    [JSInvokable()]
    public void NotifyOpened()
    {
        AfterPopoverInitialization = true;
        OnMenuOpened?.Invoke();
        _ = InvokeAsync(StateHasChanged);
    }


    /// <summary>
    /// For Material Theme to notify of menu closure via JS Interop.
    /// </summary>
    [JSInvokable()]
    public async Task NotifyClosed()
    {
        IsOpen = false;
        OnMenuClosed?.Invoke();
        // Allow enough time for the dialog closing animation before re-rendering
        await Task.Delay(150);
        await InvokeAsync(StateHasChanged);
    }


    /// <inheritdoc/>
    internal override async Task InstantiateMcwComponent()
    {
        if (!_disposed)
        {
            await InvokeJsVoidAsync("MaterialBlazor.MBMenuSurface.init", ElementReference, ObjectReference).ConfigureAwait(false);
        }
    }


    /// <summary>
    /// Returns a menu surface class determined by the parameter.
    /// </summary>
    /// <param name="surfacePositioning"></param>
    /// <returns></returns>
    internal static string GetMenuSurfacePositioningClass(MBMenuSurfacePositioning surfacePositioning)
    {
        return surfacePositioning switch
        {
            MBMenuSurfacePositioning.FullWidth => "mdc-menu-surface--fullwidth",
            MBMenuSurfacePositioning.Fixed => "mdc-menu-surface--fixed",
            _ => ""
        };
    }
}
