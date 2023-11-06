namespace Material.Blazor
{
    public record MBListItem
    {
        #region members

        public string Headline { get; set; } = "";
        public string HeadlineColor { get; set; } = "black";
        public string HeadlineSupport { get; set; } = "";
        public string HeadlineSupportColor { get; set; } = "black";
        public string ImageSource { get; set; } = "";
        public string ImageStyle { get; set; } = "";
        public bool IsDisabled { get; set; } = false;
        public string Link { get; set; } = "";
        public string LinkTarget { get; set; } = "_blank";
        public MBListItemType ListItemType { get; set; } = MBListItemType.Regular;
        public MBIconDescriptor LeadingIcon { get; set; } = null;
        public MBIconDescriptor TrailingIcon { get; set; } = null;

        #endregion
    }
}
