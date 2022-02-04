using Caching.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memoryCache;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache)
        {
            _logger = logger;
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            string saat;
            if (!_memoryCache.TryGetValue("saat", out saat))
            {
                saat = DateTime.Now.ToLongTimeString();
                _memoryCache.Set("saat", saat, DateTimeOffset.Now.AddSeconds(10));
            }

            return View();
        }
        [ResponseCache(Duration = 60)]
        public IActionResult Privacy()
        {
            //Yukarıdaki responseCache, sunucuda tutar cache i. network tabında görebilirsin(response içinde)
            // herkesin tarayıcısı kendine.
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
