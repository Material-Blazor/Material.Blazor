using System.Drawing;

namespace Material.Blazor
{
    public class MBGridTextColorSpecification
    {
        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public bool Supress { get; set; } = false;
        public string Text { get; set; }
    }
}
