using KanGrubuMvc.BaseClass;
using KanGrubuMvc.Models;
using KanGrubuMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KanGrubuMvc.Controllers
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
            List<Alici> alicilar = new List<Alici>()
            {
                new Alici()
                {
                    Grup = "A",
                    Rh = '+'
                },
                new Alici()
                {
                    Grup = "B",
                    Rh = '+'
                },
                new Alici()
                {
                    Grup = "AB",
                    Rh = '+'
                },
                new Alici()
                {
                    Grup = "A",
                    Rh = '-'
                },
                new Alici()
                {
                    Grup = "B",
                    Rh = '-'
                },
                new Alici()
                {
                    Grup = "AB",
                    Rh = '-'
                },
                new Alici()
                {
                    Grup = "0",
                    Rh = '+'
                },
                new Alici()
                {
                    Grup = "0",
                    Rh = '-'
                }
            };
            List<Verici> vericiler = new List<Verici>()
            {
                new Verici()
                {
                    Grup = "A",
                    Rh = '+'
                },
                new Verici()
                {
                    Grup = "B",
                    Rh = '+'
                },
                new Verici()
                {
                    Grup = "AB",
                    Rh = '+'
                },
                new Verici()
                {
                    Grup = "A",
                    Rh = '-'
                },
                new Verici()
                {
                    Grup = "B",
                    Rh = '-'
                },
                new Verici()
                {
                    Grup = "AB",
                    Rh = '-'
                },
                new Verici()
                {
                    Grup = "0",
                    Rh = '+'
                },
                new Verici()
                {
                    Grup = "0",
                    Rh = '-'
                }
            };

            KanGrubuViewModel kanGrubuViewModel = new KanGrubuViewModel()
            {
                Alicilar = alicilar,
                Vericiler = vericiler
            };
  
        
            return View(kanGrubuViewModel);
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
