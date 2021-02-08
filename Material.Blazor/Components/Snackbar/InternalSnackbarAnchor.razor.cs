using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// An anchor component that displays snackbar notification that you display via
    /// <see cref="IMBSnackbarService.ShowSnackbar"/>.
    /// Place this component at the top of either App.razor or MainLayout.razor.
    /// </summary>
    public partial class InternalSnackbarAnchor : ComponentFoundation
    {
        [Inject] private IMBSnackbarService SnackbarService { get; set; }


        private SnackbarInstance ActiveSnackbar;
        private ConcurrentQueue<SnackbarInstance> PendingSnackbars = new ConcurrentQueue<SnackbarInstance>();

        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            SnackbarService.OnAdd += AddSnackbar;
            SnackbarService.OnTriggerStateHasChanged += OnTriggerStateHasChanged;
        }

        public new void Dispose()
        {
            SnackbarService.OnAdd -= AddSnackbar;
            SnackbarService.OnTriggerStateHasChanged -= OnTriggerStateHasChanged;

            base.Dispose();
        }


        /// <summary>
        /// Adds a snackbar to the anchor, enqueuing it ready for future display if the maximum number of snackbars has been reached.
        /// </summary>
        /// <param name="settings"></param>
        private void AddSnackbar(MBSnackbarSettings settings)
        {
            settings.Configuration = SnackbarService.Configuration;

            var snackbarInstance = new SnackbarInstance
            {
                Id = Guid.NewGuid(),
                TimeStamp = DateTime.Now,
                Settings = settings
            };

            PendingSnackbars.Enqueue(snackbarInstance);
            ShowNextSnackbarAsync();
        }

        private void OnTriggerStateHasChanged()
        {
            try
            {
                _ = InvokeAsync(StateHasChanged);
            }
            catch
            {
                // It is entirely possible that the renderer has been disposed, so just ignore errors on calling StateHasChanged
            }
        }
        private readonly SemaphoreSlim queue_semaphore = new SemaphoreSlim(1, 1);
        private async Task ShowNextSnackbarAsync()
        {
            await queue_semaphore.WaitAsync();
            try
            {
                if (ActiveSnackbar != null) // if there is an active snackbar, we shouldn't try to display the next
                {
                    return;
                }
                if (!PendingSnackbars.TryDequeue(out var snackbarInstance)) // if there is no next snackbar, don't do anything
                {
                    return;
                }
                // register the close event, which simply removes this snackbar and goes back here
                // then make this instance active and render.
                snackbarInstance.Settings.OnClose = RemoveClosedSnackbarAndDisplayNextAsync;
                ActiveSnackbar = snackbarInstance;
                await InvokeAsync(StateHasChanged);
            }
            finally
            {
                queue_semaphore.Release();
            }
        }
        private async Task RemoveClosedSnackbarAndDisplayNextAsync(SnackbarInstance instance)
        {
            await queue_semaphore.WaitAsync();
            try
            {
                ActiveSnackbar = null;
                instance.Settings.OnClose = null;
            }
            finally
            {
                queue_semaphore.Release();
            }
            await ShowNextSnackbarAsync();
        }
    }
}
