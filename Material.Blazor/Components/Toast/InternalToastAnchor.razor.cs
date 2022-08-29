using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// An anchor component that displays toast notification that you display via
/// <see cref="IMBToastService.ShowToast(MBToastLevel, string, string, MBNotifierCloseMethod?, string, string, IMBIconFoundry?, bool?, uint?, bool)"/>.
/// Place this component at the top of either App.razor or MainLayout.razor.
/// </summary>
public partial class InternalToastAnchor : ComponentFoundation
{
    [Inject] private IMBToastService ToastService { get; set; }


    private List<ToastInstance> DisplayedToasts { get; set; } = new List<ToastInstance>();
    private Queue<ToastInstance> PendingToasts { get; set; } = new Queue<ToastInstance>();
    private string PositionClass => $"mb-toast__{ToastService.Configuration.Position.ToString().ToLower()}".Replace("_top", "_top-").Replace("_center", "_center-").Replace("_bottom", "_bottom-");


    private readonly SemaphoreSlim displayedToastsSemaphore = new SemaphoreSlim(1);
    private readonly SemaphoreSlim pendingToastsSemaphore = new SemaphoreSlim(1);


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        ToastService.OnAdd += AddToast;
        ToastService.OnTriggerStateHasChanged += InvokeStateHasChanged;
    }


    protected override void Dispose(bool disposing)
    {
        ToastService.OnAdd -= AddToast;
        ToastService.OnTriggerStateHasChanged -= InvokeStateHasChanged;

        base.Dispose(disposing);
    }


    /// <summary>
    /// Adds a toast to the anchor, enqueuing it ready for future display if the maximum number of toasts has been reached.
    /// </summary>
    /// <param name="level"></param>
    /// <param name="settings"></param>
    private void AddToast(MBToastLevel level, MBToastSettings settings)
    {
        InvokeAsync(async () => await AddToastAsync(level, settings).ConfigureAwait(false));
    }



    /// <summary>
    /// Adds a toast to the anchor, enqueuing it ready for future display if the maximum number of toasts has been reached.
    /// </summary>
    /// <param name="level"></param>
    /// <param name="settings"></param>
    private async Task AddToastAsync(MBToastLevel level, MBToastSettings settings)
    {
        settings.Configuration = ToastService.Configuration;
        settings.Level = level;

        var toastInstance = new ToastInstance
        {
            Id = Guid.NewGuid(),
            TimeStamp = DateTime.Now,
            Settings = settings
        };

        await pendingToastsSemaphore.WaitAsync();

        try
        {
            PendingToasts.Enqueue(toastInstance);

            await displayedToastsSemaphore.WaitAsync();

            try
            {
                FlushPendingToasts();
            }
            finally
            {
                _ = displayedToastsSemaphore.Release();
            }
        }
        finally
        {
            _ = pendingToastsSemaphore.Release();
        }

        InvokeStateHasChanged();
    }


    private void InvokeStateHasChanged()
    {
        _ = InvokeAsync(StateHasChanged);
    }


    private void FlushPendingToasts()
    {
        bool FlushNext() => PendingToasts.Any() && (ToastService.Configuration.MaxToastsShowing <= 0 || DisplayedToasts.Count(t => t.Settings.Status != ToastStatus.Hide) < ToastService.Configuration.MaxToastsShowing);

        while (FlushNext())
        {
            var toastInstance = PendingToasts.Dequeue();

            DisplayedToasts.Add(toastInstance);

            if (toastInstance.Settings.AppliedCloseMethod != MBNotifierCloseMethod.DismissButton)
            {
                var toastTimer = new System.Timers.Timer(toastInstance.Settings.AppliedTimeout);
                toastTimer.Elapsed += async (sender, args) => await CloseToastAsync(toastInstance.Id).ConfigureAwait(false);
                toastTimer.AutoReset = false;
                toastTimer.Start();
            }
        }

        InvokeStateHasChanged();
    }



    /// <summary>
    /// Closes a toast and removes it from the anchor, with a fade out routine.
    /// </summary>
    /// <param name="toastId"></param>
    public async Task CloseToastAsync(Guid toastId)
    {
        await displayedToastsSemaphore.WaitAsync();

        try
        {
            var toastInstance = DisplayedToasts.SingleOrDefault(x => x.Id == toastId);

            if (toastInstance is null)
            {
                return;
            }

            toastInstance.Settings.Status = ToastStatus.FadeOut;
            InvokeStateHasChanged();
        }
        finally
        {
            _ = displayedToastsSemaphore.Release();
        }

        var removeTimer = new System.Timers.Timer(500);
        removeTimer.Elapsed += async (sender, args) => await RemoveToastAsync(toastId).ConfigureAwait(false);
        removeTimer.AutoReset = false;
        removeTimer.Start();
    }


    private async Task RemoveToastAsync(Guid toastId)
    {
        await displayedToastsSemaphore.WaitAsync();

        try
        {
            var toastInstance = DisplayedToasts.SingleOrDefault(x => x.Id == toastId);

            if (toastInstance is null)
            {
                return;
            }

            toastInstance.Settings.Status = ToastStatus.Hide;

            if (!DisplayedToasts.Any(x => x.Settings.Status == ToastStatus.FadeOut))
            {
                _ = DisplayedToasts.RemoveAll(x => x.Settings.Status == ToastStatus.Hide);
            }

            InvokeStateHasChanged();

            FlushPendingToasts();
        }
        finally
        {
            displayedToastsSemaphore.Release();
        }
    }
}
