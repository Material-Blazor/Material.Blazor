using System;
using System.Drawing;
using System.Linq.Expressions;

namespace Material.Blazor
{
    public class MBGridColumnConfiguration<TRowData>
    {
        public bool BoldHeader { get; private set; }
        public Func<TRowData, object> BackgroundColorExpression { get; set; }
        public Color BackgroundColorHeader { get; set; }
        public MB_Grid_ColumnType ColumnType { get; private set; }
        public Func<TRowData, object> DataExpression { get; set; }
        public Func<TRowData, object> ForegroundColorExpression { get; set; }
        public Color ForegroundColorHeader { get; set; }
        public string FormatString { get; set; }
        public bool IsPMI { get; set; }
        public Func<TRowData, object> SupressDisplayExpression { get; set; }
        public string Title { get; set; }
        public int Width { get; set; }

        private MBGridColumnConfiguration() { }
        public MBGridColumnConfiguration(
            Expression<Func<TRowData, object>> backgroundColorExpression = null,
            Color? backgroundColorHeader = null,
            bool boldHeader = true,
            MB_Grid_ColumnType columnType = MB_Grid_ColumnType.Text,
            Expression<Func<TRowData, object>> dataExpression = null,
            Expression<Func<TRowData, object>> foregroundColorExpression = null,
            Color? foregroundColorHeader = null,
            string formatString = null,
            bool isPMI = false,
            Expression<Func<TRowData, object>> supressDisplayExpression = null,
            string title = "",
            int width = 10)
        {
            BackgroundColorExpression = backgroundColorExpression?.Compile();// ?? Color.LightGray;
            BackgroundColorHeader = backgroundColorHeader ?? Color.LightGray;
            BoldHeader = boldHeader;
            ColumnType = columnType;
            DataExpression = dataExpression?.Compile();
            ForegroundColorExpression = foregroundColorExpression?.Compile();// ?? Color.Black;
            ForegroundColorHeader = foregroundColorHeader ?? Color.Black;
            FormatString = formatString;
            IsPMI = isPMI;
            SupressDisplayExpression = supressDisplayExpression?.Compile();
            Title = title;
            Width = width;
        }
    }
}
