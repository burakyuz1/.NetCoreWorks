using LoginSession.Extensions;
using LoginSession.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace LoginSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (!IsLogged()) return RedirectToAction("Index", "Login");
            return View();
        }

        public IActionResult Privacy()
        {
            if (!IsLogged()) return RedirectToAction("Index", "Login");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool IsLogged()
        {
            User loggedUser = HttpContext.Session.GetObject<User>("user");
            if (loggedUser == null) return false;
            return true;
        }
    }
}
