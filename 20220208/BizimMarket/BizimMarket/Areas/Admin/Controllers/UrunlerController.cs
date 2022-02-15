using BizimMarket.Areas.Admin.Models;
using BizimMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BizimMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunlerController : Controller
    {
        private readonly BizimMarketContext _db;
        private readonly IWebHostEnvironment _env;

        public UrunlerController(BizimMarketContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_db.Urunler.Include(x => x.Kategori).ToList());
        }

        public IActionResult Yeni()
        {
            KategorileriYukle();
            return View();
        }
        
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Yeni(YeniUrunViewModel vm)
        {
            if (ModelState.IsValid)
            {
                string dosyaAdi = ResimYukle(vm.Resim);

                Urun urun = new Urun()
                {
                    Ad = vm.Ad,
                    Fiyat = vm.Fiyat.Value,
                    KategoriId = vm.KategoriId.Value,
                    ResimYolu = dosyaAdi
                };
                _db.Add(urun);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return KategorileriYukle();
        }



        public IActionResult Duzenle(int id)
        {
            var urun = _db.Urunler.Find(id);
            if (urun == null) return NotFound();
            KategorileriYukle();
            var model = new DuzenleUrunViewModel()
            {
                Ad = urun.Ad,
                Fiyat = urun.Fiyat,
                KategoriId = urun.KategoriId,
                ResimYolu = urun.ResimYolu
            };
            return View(model);
        }

        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult Duzenle(DuzenleUrunViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var urun = _db.Urunler.Find(vm.Id);
                urun.Ad = vm.Ad;
                urun.Fiyat = vm.Fiyat.Value;
                urun.KategoriId = vm.KategoriId.Value;
                if (vm.Resim != null)
                {
                    ResimSil(urun.ResimYolu); //Eski resmi sil
                    urun.ResimYolu = ResimYukle(vm.Resim); // gelen resmi yükle.
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            KategorileriYukle();
            return View(vm);
        }


        public IActionResult Sil(int id)
        {
            Urun urun = _db.Urunler.Find(id);
            if (urun == null) return NotFound();

            ResimSil(urun.ResimYolu); // Fiziksel olarak silmek

            _db.Urunler.Remove(urun);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        private IActionResult KategorileriYukle()
        {
            ViewBag.Kategoriler = _db.Kategoriler
                .Select(x => new SelectListItem(x.Ad, x.Id.ToString()))
                .ToList();
            return View();
        }
        private string ResimYukle(IFormFile file)
        {
            string dosyaAdi = null;
            if (file != null)
            {
                dosyaAdi = Guid.NewGuid() + Path.GetExtension(file.FileName);
                string kaydetmeYolu = Path.Combine(_env.WebRootPath, "img", "urunler", dosyaAdi);
                using (var fs = new FileStream(kaydetmeYolu, FileMode.Create))
                {
                   file.CopyTo(fs);
                }
            }

            return dosyaAdi;
        }

        private void ResimSil(string dosyaYolu)
        {
            if (dosyaYolu == null) return;
            string silmeYolu = Path.Combine(_env.WebRootPath, "img", "urunler", dosyaYolu);
            try
            {
                System.IO.File.Delete(silmeYolu);
            }
            catch (Exception)
            {
            }
        }
    }
}
