using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SehirBolgeCustomTagHelper.Models;
using SehirBolgeCustomTagHelper.Models.Context;
using SehirBolgeCustomTagHelper.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace SehirBolgeCustomTagHelper.Controllers
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

            BolgeSehirViewModel bolgeSehirViewModel = new BolgeSehirViewModel()
            {
                BolgeId = bolgeId,
                Sehirler = _db.Sehirler.Where(x => (bolgeId != null) ? x.BolgeId == bolgeId : x.Id > 0).ToList(),
                Bolgeler = _db.Bolgeler.Select(x => new SelectListItem() { Text = x.BolgeAd, Value = x.Id.ToString() }).ToList()
            };
            return View(bolgeSehirViewModel);
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
