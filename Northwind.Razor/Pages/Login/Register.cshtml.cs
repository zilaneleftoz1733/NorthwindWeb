using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Razor.Pages.Login
{
    public class RegisterModel : PageModel
    {

        [BindProperty]
        public RegisterVM Input { get; set; } = new RegisterVM();
        public void OnGet()
        {
        }




        
    }
    public class RegisterVM
    {
        [Required(ErrorMessage = "Email Zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required(ErrorMessage ="Tc No Zorunludur")]
        [Length(11,11,ErrorMessage ="11 Karakter olmak zorundadir")]
        [DisplayName("Tcno")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Þifre Zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Þifre Zorunludur")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
        
    }
}
