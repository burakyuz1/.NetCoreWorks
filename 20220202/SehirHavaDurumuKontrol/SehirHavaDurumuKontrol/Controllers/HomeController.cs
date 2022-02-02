using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SehirHavaDurumuKontrol.Context;
using SehirHavaDurumuKontrol.Models;
using SehirHavaDurumuKontrol.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SehirHavaDurumuKontrol.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _db;

        public HomeController(ILogger<HomeController> logger, ProjectContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? bolgeId)
        {
            //BolgeSehirViewModel bolgeSehir = new BolgeSehirViewModel()
            //{
            //    BolgeId = bolgeId,
            //    Bolgeler = 

            //}

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
