using System;
using BizimMarket.Context;
using BizimMarket.Models;
using BizimMarket.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

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

        public IActionResult Index(int? categoryId)
        {
            IQueryable<Product> products = _db.Products;
            if (categoryId.HasValue)
            {
                products = products.Where(x => x.CategoryId == categoryId);
            }

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                SelectedCategoryId = categoryId,
                Categories = _db.Categories.OrderBy(x => x.CategoryName).ToList(),
                Products = products.ToList()
            };
            return View(homeViewModel);
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