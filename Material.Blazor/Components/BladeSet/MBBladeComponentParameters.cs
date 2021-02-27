namespace Material.Blazor
{
    /// <summary>
    /// Parameters passed to a new blade via <see cref="MBBladeSet.AddBlade(string, MBBladeComponent, MBBladeComponentParameters, string, string)"/> must take
    /// one parameter of a class implementing this interface. That class then holds all the parameters required for the component.
    /// </summary>
    public class MBBladeComponentParameters : object { }
}
