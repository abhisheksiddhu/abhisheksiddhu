using Microsoft.AspNetCore.Mvc;

namespace WebApplication_MVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Custom()
        {
            return View("~/CustomViewPath/Custom.cshtml");
        }

        public IActionResult CustomCall()
        {
            IActionResult actionResult = Custom();
            return actionResult;
        }
    }
}
