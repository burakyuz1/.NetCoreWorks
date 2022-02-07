using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BasitUyelikFiltering.Filters
{
    public class UyelereOzelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //context.HttpContext.Session.TryGetValue("kullaniciMail",out )

            string mail = context.HttpContext.Session.GetString("kullaniciMail");

            if (string.IsNullOrEmpty(mail))
            {
                context.Result = new RedirectToActionResult("Index", "Uyelik", null);
            }
        }
    }
}
