using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplication_UI.Controllers
{
	public class HomeController : Controller
	{
		[Filters.LogActionFilter]
		public async Task<ActionResult> Index()
		{
			//HttpClient httpClient = new HttpClient();
			//HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44366/api/books");
			//string responseString = await response.Content.ReadAsStringAsync();
			string responseString = "acas";

			return View("Index", model: responseString);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public async Task<ActionResult> FileUpload()
		{
			var form = Request.Form["photo"];
			var file = Request.Files["photo"];

			if (file != null)
			{
				var fs = new FileInfo($"D:/{DateTime.Now.Ticks}-{file.FileName}");

				using (var strean = fs.OpenWrite())
				{
					await file.InputStream.CopyToAsync(strean);
				}
			}

			return View();
		}
	}
}