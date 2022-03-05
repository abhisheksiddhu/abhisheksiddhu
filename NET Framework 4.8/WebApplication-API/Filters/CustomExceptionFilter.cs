using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace WebApplication_API.Filters
{
	public class CustomExceptionFilter : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext actionExecutedContext)
		{
			base.OnException(actionExecutedContext);

			if (actionExecutedContext.Exception is NotImplementedException)
			{
				actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.NotImplemented)
				{
					Content = new StringContent("method not implemented")
				};
			}
			else
			{
				actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent("generic message")
				};
			}
		}
	}
}