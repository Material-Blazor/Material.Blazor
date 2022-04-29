#define SchedulerLogging

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public partial class MBAppointment : ComponentFoundation
    {
        [Parameter] public MBScheduler SchedulerRef { get; set; }
        [Parameter] public MBSchedulerAppointment SchedulerAppointment { get; set; }
        [Parameter] public int Height { get; set; }
        [Parameter] public int Width { get; set; }
        [Parameter] public int X { get; set; }
        [Parameter] public int Y { get; set; }

        private string styleString { get; set; }

        #region HandleDragStart
        private async Task HandleDragStart(DragEventArgs dea)
        {
            await SchedulerRef.HandleDragStart(dea);//, SchedulerAppointment);
        }

        #endregion

        #region OnInitializedAsync
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            styleString =
                "background: " + SchedulerAppointment.BackgroundColor.Name + ";" +
                "border-width: 0; " +
                "border-radius: 4px; " +
                "border-style: solid; " +
                "color: " + SchedulerAppointment.ForegroundColor.Name + ";" +
                "top: " + Y.ToString() + "px; " +
                "left: " + X.ToString() + "px; " +
                "position: absolute; " +
                "width: " + Width.ToString() + "px; " +
                "height: " + Height.ToString() + "px; ";

#if SchedulerLogging
            var l = 
                "MBAppointment.OnOnitializedAsync X/Y: " + 
                X.ToString() + 
                "/" + 
                Y.ToString();
            SchedulerLogDebug(l);
#endif
        }

        #endregion

        #region SchedulerLogging

#if SchedulerLogging
        private void SchedulerLogDebug(string message)
        {
            LoggingService.LogDebug(message);
        }

        private void SchedulerLogTrace(string message)
        {
            LoggingService.LogTrace(message);
        }

#endif

        #endregion

    }
}
