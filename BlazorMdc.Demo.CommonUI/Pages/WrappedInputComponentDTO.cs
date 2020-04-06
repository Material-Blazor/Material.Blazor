//
//  2020-03-27  Mark Stega
//              Created
//

using System.ComponentModel.DataAnnotations;
namespace BlazorMdc.Demo.CommonUI.Pages
{
    public class LogonDTO
    {
        [Required(ErrorMessage = "PIN is required")] public string pPIN1 { get; set; }
        [Required(ErrorMessage = "Validation PIN is required")] public string pPIN2 { get; set; }
    }
}
