using Microsoft.AspNetCore.Mvc;

using WebApplication_MVC.Filters;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class PartialTestController : Controller
    {
        public IActionResult Index()
        {
            List<DummyUser> users = Global.Data;
            return View(users);
        }

        public IActionResult Details()
        {
            DummyUser user = Global.Data.First();
            return PartialView("_DummyUserRow", user);
        }

        [CustomActionFilter,Microsoft.AspNetCore.Mvc.RequestSizeLimit(2000)]        
        public IActionResult ActionFilter()
        {
            object? value = ControllerContext.HttpContext.Items["filterkey"];
            Console.WriteLine(value);
            return View();
        }
    }
}
