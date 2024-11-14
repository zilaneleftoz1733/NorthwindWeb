using Microsoft.AspNetCore.Identity;

namespace Northwind.Razor.Models
{
    public class MyUser : IdentityUser
    {
        public string TcNo { get; set; }
    }
}
