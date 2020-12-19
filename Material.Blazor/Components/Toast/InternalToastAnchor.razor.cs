using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// An anchor component that displays toast notification that you display via
    /// <see cref="IMBToastService.ShowToast(MBToastLevel, string, string, MBToastCloseMethod?, string, string, IMBIconFoundry?, bool?, uint?, bool)"/>.
    /// Place this component at the top of either App.razor or MainLayout.razor.
    /// </summary>
    public partial class InternalToastAnchor : ComponentFoundation
    {
        [Inject] private IMBToastService ToastService { get; set; }


        private List<ToastInstance> DisplayedToasts { get; set; } = new List<ToastInstance>();
        private Queue<ToastInstance> PendingToasts { get; set; } = new Queue<ToastInstance>();
        private string PositionClass => $"mb-toast__{ToastService.Configuration.Position.ToString().ToLower()}";


        private readonly SemaphoreSlim displayedToastsSemaphore = new SemaphoreSlim(1);
        private readonly SemaphoreSlim pendingToastsSemaphore = new SemaphoreSlim(1);


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            ToastService.OnAdd += AddToast;
            ToastService.OnTriggerStateHasChanged += OnTriggerStateHasChanged;
        }


        public new void Dispose()
        {
            ToastService.OnAdd -= AddToast;
            ToastService.OnTriggerStateHasChanged -= OnTriggerStateHasChanged;

            base.Dispose();
        }


        /// <summary>
        /// Adds a toast to the anchor, enqueuing it ready for future display if the maximum number of toasts has been reached.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="settings"></param>
        private void AddToast(MBToastLevel level, MBToastSettings settings)
        {
            InvokeAsync(async () =>
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
                        displayedToastsSemaphore.Release();
                    }
                }
                finally
                {
                    pendingToastsSemaphore.Release();
                }

                StateHasChanged();
            });
        }


        private void OnTriggerStateHasChanged() => _ = InvokeAsync(StateHasChanged);


        private void FlushPendingToasts()
        {
            bool FlushNext() => PendingToasts.Count() > 0 && (ToastService.Configuration.MaxToastsShowing <= 0 || DisplayedToasts.Where(t => t.Settings.Status != ToastStatus.Hide).Count() < ToastService.Configuration.MaxToastsShowing);

            while (FlushNext())
            {
                var toastInstance = PendingToasts.Dequeue();

                DisplayedToasts.Add(toastInstance);

                if (toastInstance.Settings.AppliedCloseMethod != MBToastCloseMethod.CloseButton)
                {
                    InvokeAsync(() =>
                    {
                        var timeout = toastInstance.Settings.AppliedTimeout;
                        var toastTimer = new System.Timers.Timer(toastInstance.Settings.AppliedTimeout);
                        toastTimer.Elapsed += (sender, args) => { CloseToast(toastInstance.Id); };
                        toastTimer.AutoReset = false;
                        toastTimer.Start();
                    });
                }
            }

            StateHasChanged();
        }



        /// <summary>
        /// Closes a toast and removes it from the anchor, with a fade out routine.
        /// </summary>
        /// <param name="toastId"></param>
        public void CloseToast(Guid toastId)
        {
            InvokeAsync(async () =>
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
                    StateHasChanged();
                }
                finally
                {
                    displayedToastsSemaphore.Release();
                }

                var toastTimer = new System.Timers.Timer(500);
                toastTimer.Elapsed += (sender, args) => { RemoveToast(toastId); };
                toastTimer.AutoReset = false;
                toastTimer.Start();

                StateHasChanged();
            });
        }


        private void RemoveToast(Guid toastId)
        {
            InvokeAsync(async () =>
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

                    if (DisplayedToasts.Where(x => x.Settings.Status == ToastStatus.FadeOut).Count() == 0)
                    {
                        DisplayedToasts.RemoveAll(x => x.Settings.Status == ToastStatus.Hide);
                    }

                    StateHasChanged();

                    FlushPendingToasts();
                }
                finally
                {
                    displayedToastsSemaphore.Release();
                }
            });
        }
    }
}
