namespace BlazorMdc
{
    public class MdcListElement<T>
    {
        public T SelectedValue { get; set; }

        public string Label { get; set; }

        public string ButtonContainerClass { get; set; }

        public bool Disabled { get; set; } = false;
    }
}
