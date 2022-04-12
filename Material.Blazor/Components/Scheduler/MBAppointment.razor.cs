using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System.Drawing;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public partial class MBAppointment : ComponentFoundation
    {
        [Parameter] public Color BackgroundColor { get; set; }
        [Parameter] public Color ForegroundColor { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public double Height { get; set; }
        [Parameter] public double Width { get; set; }
        [Parameter] public double X { get; set; }
        [Parameter] public double Y { get; set; }

        private string styleString { get; set; }

        #region OnInitializedAsync
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            styleString =
                "background: " + BackgroundColor.Name + ";" +
                "border-width: 0; " +
                "border-radius: 4px; " +
                "border-style: solid; " +
                "color: " + ForegroundColor.Name + ";" +
                "top: " + Y.ToString() + "px; " +
                "left: " + X.ToString() + "px; " +
                "position: absolute; " +
                "width: " + Width.ToString() + "px; " +
                "height: " + Height.ToString() + "px; ";
        }

        #endregion

    }
}
