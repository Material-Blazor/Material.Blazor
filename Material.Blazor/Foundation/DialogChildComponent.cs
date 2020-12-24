using Material.Blazor.Internal;

namespace Material.Blazor
{
    /// <summary>
    /// A direct ancestor of <see cref="InputComponent{T}"/> for dialogs to reference when intiating child
    /// components. We cannot use <see cref="InputComponent{T}"/> directly because its generics get in the way.
    /// This class allows <see cref="MBDialog"/> to control when child components are instantiated with
    /// Material Components Web JS.
    /// </summary>
    public abstract class DialogChildComponent : ComponentFoundation
    {
        /// <summary>
        /// A callback for use by <see cref="MBDialog"/> to request Material Theme instantiation.
        /// </summary>
        public abstract void RequestInstantiation();
    }
}
