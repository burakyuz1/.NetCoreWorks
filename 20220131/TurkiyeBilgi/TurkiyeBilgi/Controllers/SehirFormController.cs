using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TurkiyeBilgi.Models.Context;

namespace TurkiyeBilgi.Controllers
{
    public class SehirFormController : Controller
    {
        private readonly TurkiyeContext _db;
        public SehirFormController(TurkiyeContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            var model = _db.Sehirler.Include(x => x.Bolge).ToList();
            return View(model);
        }
    }
}
