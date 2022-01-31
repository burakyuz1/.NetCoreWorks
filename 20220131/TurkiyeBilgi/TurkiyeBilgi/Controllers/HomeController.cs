using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using TurkiyeBilgi.Models;
using TurkiyeBilgi.Models.Context;

namespace TurkiyeBilgi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TurkiyeContext _db;

        public HomeController(ILogger<HomeController> logger, TurkiyeContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? bolgeId)
        {
            var vm = new HomeViewModel()
            {
                BolgeId = bolgeId,
                Sehirler = _db.Sehirler.Where(x => !bolgeId.HasValue || x.BolgeId == bolgeId).ToList(),
                Bolgeler = _db.Bolgeler.Select(x => new SelectListItem() { Text = x.BolgeAd, Value = x.Id.ToString() }).ToList()
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
