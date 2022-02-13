using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication_MVC.Filters
{
    public class CustomActionFilterAttribute : ActionFilterAttribute // Attribute, IAsyncActionFilter
    {
        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    base.OnActionExecuting(context);
        //    context.HttpContext.Items["filterkey"] = "filterdata23fdgbv";
        //}

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    base.OnActionExecuted(context);
        //    context.HttpContext.Response.StatusCode = 201;
        //}

        //public void OnActionExecuted(ActionExecutedContext context)
        //{
        //    context.HttpContext.Response.StatusCode = 201;
        //}

        //public void OnActionExecuting(ActionExecutingContext context)
        //{
        //    context.HttpContext.Items["filterkey"] = "filterdata";
        //}

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.HttpContext.Items["filterkey"] = "filterdata";
            await next();
            context.HttpContext.Response.StatusCode = 201;
        }

        public void OnResultExecuted(ResultExecutedContext context) => throw new NotImplementedException();
        public void OnResultExecuting(ResultExecutingContext context) => throw new NotImplementedException();
    }
}
