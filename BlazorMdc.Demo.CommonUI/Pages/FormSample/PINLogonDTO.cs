using System.ComponentModel.DataAnnotations;

namespace BlazorMdc.Demo
{
    public class PINLogonDTO
    {
        [Required (ErrorMessage="PIN is required")] public string PIN1 { get; set; }
        [Required(ErrorMessage = "Validation PIN is required")] public string PIN2 { get; set; }
    }
}
