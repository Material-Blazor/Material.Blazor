﻿using System.Drawing;

namespace Material.Blazor.MD2;

public class MBGridTextColorSpecification
{
    public Color BackgroundColor { get; set; }
    public Color ForegroundColor { get; set; }
    public bool Suppress { get; set; } = false;
    public string Text { get; set; }
}
