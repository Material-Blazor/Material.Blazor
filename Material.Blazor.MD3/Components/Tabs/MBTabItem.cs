namespace Material.Blazor
{
    public record MBTabItem
    {
        #region members

        public string Headline { get; set; } = "";
        public bool IconIsInline { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public bool IsDisabled { get; set; } = false;
        public bool IsPrimary { get; set; } = true;
        public MBIconDescriptor Icon { get; set; } = null;
        public string TabAriaControls { get; set; } = null;
        public string TabId { get; set; } = null;

        #endregion
    }
}
