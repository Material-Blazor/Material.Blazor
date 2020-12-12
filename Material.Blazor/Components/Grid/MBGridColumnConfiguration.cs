using System;
using System.Drawing;
using System.Linq.Expressions;

namespace Material.Blazor
{
    public class MBGridColumnConfiguration<TRowData>
    {
        public bool Bold { get; private set; }
        public Color BackgroundColor { get; private set; }
        public MB_Grid_ColumnType ColumnType { get; private set; }
        public Func<TRowData, object> DataExpression { get; set; }
        public Color ForegroundColor { get; private set; }
        public string FormatString { get; set; }
        public bool SupressDisplay { get; set; }
        public string Title { get; private set; }
        public int Width { get; set; }

        private MBGridColumnConfiguration() { }
        public MBGridColumnConfiguration(
            Color? backgroundColor = null,
            bool bold = false,
            MB_Grid_ColumnType columnType = MB_Grid_ColumnType.Text,
            Expression<Func<TRowData, object>> dataExpression = null,
            Color? foregroundColor = null,
            string formatString = null,
            bool supressDisplay = false,
            string title = "",
            int width = 10)
        {
            BackgroundColor = backgroundColor ?? Color.LightGray;
            Bold = bold;
            ColumnType = columnType;
            DataExpression = dataExpression?.Compile();
            ForegroundColor = foregroundColor ?? Color.Black;
            FormatString = formatString;
            SupressDisplay = supressDisplay;
            Title = title;
            Width = width;
        }
    }
}
