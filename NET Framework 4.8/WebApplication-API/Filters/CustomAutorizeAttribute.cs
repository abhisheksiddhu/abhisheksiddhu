using System.Web.Mvc;

namespace WebApplication_API.Filters
{
	public class CustomAutorizeAttribute : AuthorizeAttribute
	{
		public override void OnAuthorization(AuthorizationContext filterContext)
		{
			base.OnAuthorization(filterContext);
			string headervalue = filterContext.HttpContext.Request.Headers["ABCD"];
			if (headervalue == "")
			{
				filterContext.RequestContext.HttpContext.Response.Write("");
			}
		}
	}
}