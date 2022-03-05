using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

using WebApplication_API.Models;

namespace WebApplication_API.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		[Filters.LogActionFilter]
		[Filters.CustomExceptionFilter]
		public IEnumerable<string> Get()
		{
			throw new System.NotImplementedException();

			return new string[] { "value1", "value2", "value3" };
		}

		// GET api/values/5
		public string Get(int id) => "value";

		// POST api/values
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody] Address value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}

		[Route("fileupload")]
		public async Task<string> FileUpload()
		{
			//var form = Request.Form["photo"];
			//var file = Request.Files["photo"];

			//if (file != null)
			//{
			//	var fs = new FileInfo($"D:/Temp/{DateTime.Now.Ticks}-{file.FileName}");

			//	using (var strean = fs.OpenWrite())
			//	{
			//		await file.InputStream.CopyToAsync(strean);
			//	}
			//}

			var multipartStream = await Request.Content.ReadAsMultipartAsync();
			foreach (HttpContent image in multipartStream.Contents)
			{
				var fs = new FileInfo($"D:/Temp/{DateTime.Now.Ticks}");

				using (var strean = fs.OpenWrite())
				{
					await image.CopyToAsync(strean);
				}
			}

			return "file uploaded successfully";
		}
	}
}
