using System;
using System.Drawing;
using System.Linq.Expressions;

namespace Material.Blazor.MD2;

public class MBSchedulerAppointment
{
    public Color BackgroundColor { get; set; }
    public int Column { get; set; }
    public DateTime EndTime { get; set; }
    public Color ForegroundColor { get; set; }
    public int Height { get; set; }
    public int RelativeX { get; set; }
    public int RelativeY { get; set; }
    public DateTime StartTime { get; set; }
    public string Title { get; set; }
    public Guid Uid { get; set; }
    public int Width { get; set; }

}
