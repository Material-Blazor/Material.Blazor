using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A component added to a blade via <see cref="MBBladeSet.AddBlade(string, MBBladeComponent{TParam}, TParam, string, string)"/>
    /// must implement this interface.
    /// </summary>
    public abstract class MBBladeComponent<TParam> : ComponentBase where TParam : MBBladeComponentParameters
    {
        /// <summary>
        /// The BladeSet is provided as a cascading value
        /// </summary>
        [CascadingParameter] protected MBBladeSet BladeSet { get; set; }


        /// <summary>
        /// The blade reference provided by the calling consumer
        /// </summary>
        [Parameter] public string BladeReference { get; set; }


        /// <summary>
        /// Parameters for a blade are held in this parameter, which is a class inheriting <see cref="MBBladeComponentParameters"/>.
        /// </summary>
        [Parameter] public TParam Parameters { get; set; }


        /// <summary>
        /// Indicates whether the blade is open.
        /// </summary>
        public bool IsOpen { get; private set; } = true;


        /// <summary>
        /// A utility function to close the blade, calling BladeSet.RemoveBladeAsync(), passing the blade reference.
        /// </summary>
        public Task CloseBladeAsync()
        {
            IsOpen = false;
            return BladeSet.RemoveBladeAsync(BladeReference);
        }
    }
}
