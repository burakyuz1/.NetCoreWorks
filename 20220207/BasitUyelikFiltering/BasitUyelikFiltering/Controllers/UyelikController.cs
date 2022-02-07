using BasitUyelikFiltering.Models;
using BasitUyelikFiltering.Models.Context;
using BasitUyelikFiltering.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BasitUyelikFiltering.Controllers
{
    public class UyelikController : Controller
    {
        private readonly ProjeContext _db;

        public UyelikController(ProjeContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel kullanici)
        {
            if (ModelState.IsValid)
            {
                Kullanici user = _db.Kullanicilar.Where(x => x.Password == kullanici.Parola && x.Email == kullanici.Email).FirstOrDefault();
                if (user != null)
                {
                    HttpContext.Session.SetString("kullaniciId", user.Id.ToString());
                    HttpContext.Session.SetString("kullaniciMail", user.Email.ToString());
                    TempData["mesaj"] = "Başarılı Giriş";
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "email ya da parola hatalı");
            }
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Remove("kullaniciMail");
            HttpContext.Session.Remove("kullaniciId");
            TempData["mesaj"] = "Başarılı Çıkış";
            return RedirectToAction("Index", "Home");

        }
    }
}
