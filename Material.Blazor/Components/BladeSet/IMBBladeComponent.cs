using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// A component added to a blade via <see cref="MBBladeSet.AddBlade(string, IMBBladeComponent{TParam}, TParam, string, string)"/>
    /// must implement this interface.
    /// </summary>
    public interface IMBBladeComponent<TParam> : IComponent where TParam : MBBladeComponentParameters
    {
        /// <summary>
        /// Parameters for a blade are held in this parameter, which is a class inheriting <see cref="MBBladeComponentParameters"/>.
        /// </summary>
        [Parameter] public TParam Parameters { get; set; }
    }
}
