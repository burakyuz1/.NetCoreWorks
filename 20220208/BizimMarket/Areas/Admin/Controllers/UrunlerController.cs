<<<<<<< HEAD:20220208/BizimMarket-master/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
﻿using BizimMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System.Linq;
using BizimMarket.Context;
using BizimMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
>>>>>>> d1a2ba354a9f60bbc8aca92e319f73057f9a494e:20220208/BizimMarket/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs

namespace BizimMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunlerController : Controller
    {
        private readonly BizimMarketContext _db;
<<<<<<< HEAD:20220208/BizimMarket-master/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
        private readonly IWebHostEnvironment _webHost;

        public UrunlerController(BizimMarketContext db, IWebHostEnvironment webHost)
        {
            _db = db;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View(_db.Urunler.Include(x => x.Kategori).ToList());
=======

        public UrunlerController(BizimMarketContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            return View(_db.Products.Include(a=>a.Category).ToList());
>>>>>>> d1a2ba354a9f60bbc8aca92e319f73057f9a494e:20220208/BizimMarket/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
        }

        public IActionResult Yeni()
        {
<<<<<<< HEAD:20220208/BizimMarket-master/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
            ViewBag.Kategoriler = _db.Kategoriler
                .Select(x => new SelectListItem(x.Ad, x.Id.ToString()))
                .ToList();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Yeni(YeniUrunViewModel vm)
        {
            //bir action'daki parametreye formdan gelen modelin aktarılmasına model binding denir.
            //Model binding işlemi esnasında prop ların üzerindeki validation attribute'lar da dikkate alınır. ona göre ModelState belirlenir.
            //Burada validate ettiğimiz gibi, annotation ile de edilebilir.
        
            if (ModelState.IsValid)
            {
                string dosyaAdi = null;
                if (vm.Resim != null)
                {
                    dosyaAdi = Guid.NewGuid() + Path.GetExtension(vm.Resim.FileName);
                    string kaydetmeYolu = Path.Combine(_webHost.WebRootPath, "img", "urunler", dosyaAdi);
                    using (FileStream fs = new FileStream(kaydetmeYolu, FileMode.CreateNew))
                    {
                        vm.Resim.CopyTo(fs);
                    } 
                }
                Urun urun = new Urun()
                {
                    Ad = vm.Ad,
                    Fiyat = vm.Fiyat.Value,
                    KategoriId = vm.KategoriId.Value,
                    ResimYolu = dosyaAdi
                };
                _db.Add(urun);
=======
            ViewBag.Kategoriler = _db.Categories
                .Select(x => new SelectListItem(x.CategoryName, x.Id.ToString()))
                .ToList();
            return View();
        }
        
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Yeni(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Add(product);
>>>>>>> d1a2ba354a9f60bbc8aca92e319f73057f9a494e:20220208/BizimMarket/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

<<<<<<< HEAD:20220208/BizimMarket-master/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
            ViewBag.Kategoriler = _db.Kategoriler
                .Select(x => new SelectListItem(x.Ad, x.Id.ToString()))
                .ToList();
            return View();
        }
    }
}
=======
            ViewBag.Kategoriler = _db.Categories
                .Select(x => new SelectListItem(x.CategoryName, x.Id.ToString()))
                .ToList();
            
            return View();
        }
        
        
    }
}
>>>>>>> d1a2ba354a9f60bbc8aca92e319f73057f9a494e:20220208/BizimMarket/BizimMarket/Areas/Admin/Controllers/UrunlerController.cs
