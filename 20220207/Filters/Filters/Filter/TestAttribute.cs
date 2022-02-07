using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filter
{
    public class TestAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string controllerName = context.HttpContext.Request.RouteValues["controller"].ToString();
            string actionName = context.HttpContext.Request.RouteValues["action"].ToString();
            System.Console.WriteLine($"OnActionExecuting: ct:{controllerName}/act:{actionName}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            string controllerName = context.HttpContext.Request.RouteValues["controller"].ToString();
            string actionName = context.HttpContext.Request.RouteValues["action"].ToString();
            System.Console.WriteLine($"OnActionExecuted: ct:{controllerName}/act:{actionName}");
        }



        public override void OnResultExecuting(ResultExecutingContext context)
        {
            string controllerName = context.HttpContext.Request.RouteValues["controller"].ToString();
            string actionName = context.HttpContext.Request.RouteValues["action"].ToString();
            System.Console.WriteLine($"OnResultExecuting: ct:{controllerName}/act:{actionName}");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            string controllerName = context.HttpContext.Request.RouteValues["controller"].ToString();
            string actionName = context.HttpContext.Request.RouteValues["action"].ToString();
            System.Console.WriteLine($"OnResultExecuted: ct:{controllerName}/act:{actionName}");
        }
    }
}
