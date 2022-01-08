using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApplication_Basic.Models;

namespace WebApplication_Basic.Pages
{
    public class TestModel : PageModel
    {
        public User User { get; set; } = new();

        public void OnGet()
        {
        }

        public void OnPost(User user)
        {
            User = user;    
        }
    }
}
