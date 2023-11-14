namespace Material.Blazor
{
    public record MBChip
    {
        #region members

        public string Label { get; set; } = "";
        public string Link { get; set; } = "";
        public string LinkTarget { get; set; } = "_blank";
        public bool IsDisabled { get; set; } = false;
        public bool IsElevated { get; set; } = false;
        public bool IsRemovable { get; set; } = false;
        public MBChipType ChipType { get; set; } = MBChipType.Filter;
        public MBIconDescriptor Icon { get; set; } = null;

        #endregion
    }
}
