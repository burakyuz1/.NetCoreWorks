using KanGrubuMvc.BaseClass;
using KanGrubuMvc.Models;
using KanGrubuMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace KanGrubuMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KanGrubuViewModel kanGrubuViewModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Seed Datas
            List<KanGrubu> kanGruplari = new List<KanGrubu>()
            {
                new KanGrubu()
                {
                    Grup = "0",
                    Rh = '-'
                },
                new KanGrubu()
                {
                    Grup = "0",
                    Rh = '+'
                },
                new KanGrubu()
                {
                    Grup = "A",
                    Rh = '-'
                },
                new KanGrubu()
                {
                    Grup = "A",
                    Rh = '+'
                },
                new KanGrubu()
                {
                    Grup = "B",
                    Rh = '-'
                },
                new KanGrubu()
                {
                    Grup = "B",
                    Rh = '+'
                },
                new KanGrubu()
                {
                    Grup = "AB",
                    Rh = '-'
                },
                new KanGrubu()
                {
                    Grup = "AB",
                    Rh = '+'
                }
            };


            List<Alici> alicilar = new List<Alici>();
            List<Verici> vericiler = new List<Verici>();
            foreach (var kanGrubu in kanGruplari)
            {
                Alici alici = new Alici()
                {
                    Grup = kanGrubu.Grup,
                    Rh = kanGrubu.Rh
                };
                alicilar.Add(alici);

                Verici verici = new Verici()
                {
                    Grup = kanGrubu.Grup,
                    Rh = kanGrubu.Rh
                };
                vericiler.Add(verici);

            }

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
