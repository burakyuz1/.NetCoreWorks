<<<<<<< HEAD:20220208/BizimMarket-master/BizimMarket/Controllers/HomeController.cs
﻿using BizimMarket.Models;
=======
﻿using System;
using BizimMarket.Context;
using BizimMarket.Models;
using BizimMarket.ViewModels;
>>>>>>> d1a2ba354a9f60bbc8aca92e319f73057f9a494e:20220208/BizimMarket/BizimMarket/Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BizimMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BizimMarketContext _db;
        
        public HomeController(ILogger<HomeController> logger, BizimMarketContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? kategoriId)
        {
            IQueryable<Urun> urunler = _db.Urunler;

            if (kategoriId.HasValue)
                urunler = urunler.Where(x => x.KategoriId == kategoriId);

            var vm = new HomeViewModel()
            {
                KategoriId = kategoriId,
                Kategoriler = _db.Kategoriler.OrderBy(x => x.Ad).ToList(),
                Urunler = urunler.ToList()
            };

            return View(vm);
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
