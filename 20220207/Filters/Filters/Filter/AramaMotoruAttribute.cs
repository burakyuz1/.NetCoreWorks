using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filter
{
    public class AramaMotoruAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Query["yonlen"] == "google")
            {
                context.Result = new RedirectResult("https://google.com.tr");
            }
        }
    }
}
