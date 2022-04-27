using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Drawing;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public partial class MBAppointment : ComponentFoundation
    {
        [Parameter] public MBScheduler SchedulerRef { get; set; }
        [Parameter] public MBSchedulerAppointment SchedulerAppointment { get; set; }
        [Parameter] public double Height { get; set; }
        [Parameter] public double Width { get; set; }
        [Parameter] public double X { get; set; }
        [Parameter] public double Y { get; set; }

        private string styleString { get; set; }

        #region HandleDragStart
        private async Task HandleDragStart(DragEventArgs dea)
        {
            SchedulerRef.CurrentDragSource = this;
            await SchedulerRef.HandleDragStart(dea);
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
        }

        #endregion

    }
}
