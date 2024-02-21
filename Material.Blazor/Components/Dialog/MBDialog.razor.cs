using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// This is a general purpose Material Theme dialog.
/// </summary>
public partial class MBDialog : ComponentFoundation, IMBDialog
{
    /// <summary>
    /// The dialog title.
    /// </summary>
    [Parameter] public string Title { get; set; }


    /// <summary>
    /// Render fragment for the dialog custom header. This is outside of the Material Theme spec and is a "Plus" feature.
    /// </summary>
    [Parameter] public RenderFragment CustomHeader { get; set; }


    /// <summary>
    /// Render fragment for the dialog body.
    /// </summary>
    [Parameter] public RenderFragment Body { get; set; }


    /// <summary>
    /// Render fragment for the dialog buttons. Note that the dialog will 
    /// return actions to the consumer when the <c>data-mdc-dialog-action</c> attribute
    /// is set for a button: <see cref="MBButton"/> does this via its <see cref="MBButton.DialogAction"/>
    /// parameter.
    /// </summary>
    [Parameter] public RenderFragment Buttons { get; set; }


    /// <summary>
    /// The action returned by the dialog when the scrim is clicked. Defaults to "close". Setting
    /// this to "" will disable scrim click action.
    /// </summary>
    [Parameter] public string ScrimClickAction { get; set; } = "close";


    /// <summary>
    /// The action returned by the dialog when the escape key is pressed. Defaults to "close". Setting
    /// this to "" will disable the escape key action.
    /// </summary>
    [Parameter] public string EscapeKeyAction { get; set; } = "close";


    /// <summary>
    /// Dialogs by default apply <c>overflow: hidden;</c>. This means that selects or datepickers are often
    /// cropped. Set this parameter to true to make the dialog apply <c>overflow: visible;</c> to rectify this.
    /// Defaults to false.
    /// </summary>
    [Parameter] public bool OverflowVisible { get; set; } = false;


    private ElementReference DialogElem { get; set; }
    private bool HasBody => Body != null;
    private bool HasButtons => Buttons != null;
    private bool HasCustomHeader => CustomHeader != null;
    private bool HasTitle => !string.IsNullOrWhiteSpace(Title);
    private List<ComponentFoundation> LayoutChildren { get; set; } = new List<ComponentFoundation>();
    private DotNetObjectReference<MBDialog> ObjectReference { get; set; }
    private string OverflowClass => OverflowVisible ? "mb-dialog-overflow-visible" : "";

    private readonly string bodyId = Utilities.GenerateUniqueElementName();
    private readonly string headerId = Utilities.GenerateUniqueElementName();
    private readonly string titleId = Utilities.GenerateUniqueElementName();


    private TaskCompletionSource<string> CloseReasonTaskCompletionSource { get; set; }

    private TaskCompletionSource OpenedTaskCompletionSource { get; set; } = new();

    internal Task Opened => OpenedTaskCompletionSource.Task;
    private bool AfterDialogInitialization { get; set; } = false;
    private bool IsOpen { get; set; }
    private bool IsOpening { get; set; }
    private string OverrideReason { get; set; } = null;


    private bool _hasInstantiated = false;
    bool IMBDialog.HasInstantiated => _hasInstantiated;


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

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
    void IMBDialog.RegisterLayoutAction(ComponentFoundation child)
    {
        LayoutChildren.Add(child);
    }


    /// <summary>
    /// Shows the dialog. This first renders the Blazor markup and then allows
    /// Material Theme to open the dialog, subsequently initiating all embedded Blazor components.
    /// </summary>
    /// <returns>The action string resulting from dialog closure</returns>
    public async Task<string> ShowAsync()
    {
        if (IsOpen)
        {
            throw new InvalidOperationException("Cannot show MBDialog that is already open");
        }
        else
        {
            LayoutChildren.Clear();
            _hasInstantiated = false;
            CloseReasonTaskCompletionSource = new();
            OpenedTaskCompletionSource = new();
            IsOpen = true;
            IsOpening = true;
            await InvokeAsync(StateHasChanged);
            return await CloseReasonTaskCompletionSource.Task;
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
        else if (AfterDialogInitialization)
        {
            _hasInstantiated = true;
            AfterDialogInitialization = false;

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
            await InvokeJsVoidAsync("MaterialBlazor.MBDialog.show", DialogElem, ObjectReference, EscapeKeyAction, ScrimClickAction);
        }
        catch
        {
            _ = CloseReasonTaskCompletionSource?.TrySetCanceled();
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
            await InvokeJsVoidAsync("MaterialBlazor.MBDialog.hide", DialogElem);
        }
        else
        {
            throw new InvalidOperationException("Cannot hide MBDialog that is not already open");
        }
    }


    /// <summary>
    /// Hides the dialog and sets the reason.
    /// </summary>
    internal async Task HideAsync(string reason)
    {
        OverrideReason = reason;
        await HideAsync();
    }


    /// <summary>
    /// Do not use. This method is used internally for receiving the "dialog opened" event from javascript.
    /// </summary>
    [JSInvokable]
    public void NotifyOpened()
    {
        AfterDialogInitialization = true;
        _ = OpenedTaskCompletionSource.TrySetResult();
        _ = InvokeAsync(StateHasChanged);
    }


    /// <summary>
    /// Do not use. This method is used internally for receiving the "dialog closed" event from javascript.
    /// </summary>
    [JSInvokable]
    public async Task NotifyClosed(string reason)
    {
        reason = OverrideReason ?? reason;
        _ = (CloseReasonTaskCompletionSource?.TrySetResult(reason));
        // Allow enough time for the dialog closing animation before re-rendering
        await Task.Delay(150);
        IsOpen = false;
        await InvokeAsync(StateHasChanged);
    }
}
