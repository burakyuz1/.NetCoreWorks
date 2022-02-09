using System.Linq;
using BizimMarket.Context;
using BizimMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BizimMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunlerController : Controller
    {
        private readonly BizimMarketContext _db;

        public UrunlerController(BizimMarketContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            return View(_db.Products.Include(a=>a.Category).ToList());
        }

        public IActionResult Yeni()
        {
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
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Kategoriler = _db.Categories
                .Select(x => new SelectListItem(x.CategoryName, x.Id.ToString()))
                .ToList();
            
            return View();
        }
        
        
    }
}