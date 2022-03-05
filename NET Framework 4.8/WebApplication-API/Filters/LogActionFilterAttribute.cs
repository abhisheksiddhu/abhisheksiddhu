using System;
using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApplication_API.Filters
{
	public class LogActionFilterAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(HttpActionContext actionContext)
		{		
            Log("OnActionExecuting", "", actionContext.ActionDescriptor.ActionName);
        }

		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{			
            Log("OnActionExecuted", "", actionExecutedContext.ActionContext.ActionDescriptor.ActionName);
        }

        private void Log(string methodName, string controllerName, string actionName)
        {
            var message = string.Format("{0} controller:{1} action:{2}", methodName, controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}