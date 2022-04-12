using System;
using System.Drawing;
using System.Linq.Expressions;

namespace Material.Blazor
{
    public class MBSchedulerAppointment
    {
        public Color BackgroundColor { get; set; }
        public int Column { get; set; }
        public DateTime EndTime { get; set; }
        public Color ForegroundColor { get; set; }
        public DateTime StartTime { get; set; }
        public string Title { get; set; }
        public Guid Uid { get; set; }

        //public MBSchedulerAppointment() { }
        //public MBSchedulerAppointment(
        //    Color? backgroundColor = null,
        //    int column = 1,
        //    DateTime? endTime = null,
        //    Color? foregroundColor = null,
        //    DateTime? startTime = null,
        //    string title = "",
        //    Guid? uid = null)
        //{
        //    BackgroundColor = backgroundColor != null ? (Color)backgroundColor : Color.Aquamarine;
        //    Column = column;
        //    EndTime = endTime != null ? (DateTime)endTime : DateTime.MinValue;
        //    ForegroundColor = foregroundColor != null ? (Color)foregroundColor : Color.Black;
        //    StartTime = startTime != null ? (DateTime)startTime : DateTime.MinValue;
        //    Title = title;
        //    Uid = uid != null ? (Guid)uid : Guid.Empty;
        //}
    }
}
