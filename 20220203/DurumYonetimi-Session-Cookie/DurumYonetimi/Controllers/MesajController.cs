using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DurumYonetimi.Controllers
{
    public class MesajController : Controller
    {
        public IActionResult Kaydet(string mesaj)
        {
            HttpContext.Session.SetString("mesaj", mesaj);
            return RedirectToAction("Index", "Home");
        }
    }
}
