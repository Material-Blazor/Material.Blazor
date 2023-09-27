using System;

namespace Material.Blazor.MD2.Internal;

/// <summary>
/// An instance of a snackbar message.
/// </summary>
public class SnackbarInstance
{
    /// <summary>
    /// The snackbar's unique id.
    /// </summary>
    public Guid Id { get; set; }


    /// <summary>
    /// The settings containing all data determining the snackbar's style and behaviour.
    /// </summary>
    public MBSnackbarSettings Settings { get; set; }
}
