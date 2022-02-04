using DurumYonetimi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace DurumYonetimi.Controllers
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
            ViewBag.Ad = Request.Cookies["ad"];

            TempData["mode"] = Request.Cookies["mode"];
            if (TempData["mode"] == null)
            {
                TempData["mode"] = "light";
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(string ad)
        {
            if (ad == "") return NotFound();
            Response.Cookies.Append("ad", ad); //Tarayıcı kapanana kadar çalışır.
            Response.Cookies.Append("ad", ad, new CookieOptions() { Expires = DateTime.Now.AddYears(10) }); // 10 yıl boyunca kayıtlı kalır.(tarayıcı kapanıp açılsa bile)
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [HttpPost]
        public IActionResult DarkMode(string mode)
        {
            TempData["mode"] = mode;

            Response.Cookies.Append("mode", mode, new CookieOptions() { Expires = DateTime.Now.AddYears(10) });
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
