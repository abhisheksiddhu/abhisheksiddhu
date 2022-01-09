using Microsoft.AspNetCore.Mvc;

using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class DataController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Data Index";
            ViewBag.CallType = "Get Call";
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            ViewBag.CallType = "Post Call";
            return View(user);
        }

        [HttpGet]
        public IActionResult Tag()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Tag(User user)
        {
            return View(user);
        }

        [HttpGet]
        public IActionResult FormBind()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost, ActionName("FormBind")]
        public IActionResult FormBindPost()
        {
            User user = new User();
            user.Name = Request.Form["name"];
            user.Email = Request.Form["email"];
            user.UserName = Request.Form["username"];
            return View(user);
        }

        [HttpGet]
        public IActionResult FileBind()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> FileBind(User user)
        {
            var file = new FileInfo($"SavedFiles/{DateTime.Now.Ticks}-{user.Photo.FileName}");
            using (var stream = file.OpenWrite())
            {
                await user.Photo.OpenReadStream().CopyToAsync(stream);
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult CustomBind()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult CustomBind([Bind("Name,Email")] User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.WasFormValid = "Valid";
            }
            else
            {
                ViewBag.WasFormValid = "Invalid";
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult ModelUpdate()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> ModelUpdate(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                user.Email = "testemail";
            }
            await TryUpdateModelAsync(user);
            ModelState.Clear();
            if (TryValidateModel(user))
            {
                ViewBag.WasFormValid = "Valid";
            }
            else
            {
                ViewBag.WasFormValid = "Invalid";
            }
            return View(user);
        }
    }
}
