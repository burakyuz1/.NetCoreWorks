using LoginSession.Extensions;
using LoginSession.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginSession.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            User loggedUser = HttpContext.Session.GetObject<User>("user");
            if (loggedUser != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            HttpContext.Session.SetObject("user", user);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Exit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


    }
}
