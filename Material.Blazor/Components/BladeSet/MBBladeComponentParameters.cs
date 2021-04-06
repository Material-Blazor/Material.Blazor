namespace Material.Blazor
{
    /// <summary>
    /// Parameters passed to a new blade via <see cref="MBBladeSet.AddBladeAsync{TComponent, TParameters}(string, TParameters, string, string, System.Action{string})"/> must take
    /// one parameter of a class implementing this interface. That class then holds all the parameters required for the component.
    /// </summary>
    public class MBBladeComponentParameters : object { }
}
