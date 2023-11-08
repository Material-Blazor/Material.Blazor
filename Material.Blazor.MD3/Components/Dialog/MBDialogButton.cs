namespace Material.Blazor
{
    public record MBDialogButton
    {
        #region members

        public string ButtonLabel { get; set; }
        public string ButtonValue { get; set; }
        public MBIconDescriptor Icon { get; set; } = null;

        #endregion
    }
}
