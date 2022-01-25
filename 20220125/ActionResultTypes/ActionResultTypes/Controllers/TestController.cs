using ActionResultTypes.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;

namespace ActionResultTypes.Controllers
{
    public class TestController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public TestController(IWebHostEnvironment env)
        {

            _env = env;
        }
        //ViewResult
        public IActionResult Index()
        {
            return View();
        }

        //RedirectResult
        public IActionResult AramaMotoru()
        {
            return Redirect("https://google.com.tr");
        }

        //RedirectToActionResult
        public IActionResult Anasayfa()
        {
            return RedirectToAction("Index", "Home");
        }

        //JSONResult
        public IActionResult Hava()
        {
            HavaDurumu havaDurumu = new HavaDurumu()
            {
                Yer = "Ankara",
                Sicaklik = -4m
            };
            return Json(havaDurumu);
        }

        //VirtualFileResult
        public IActionResult Ankara()
        {
            return File("~/img/ankara.jpg", "image/jpeg");
        }

        //NotFoundResult
        public IActionResult Para()
        {
            return NotFound();
        }

        //BadRequest
        public IActionResult Karekok(double sayi)
        {
            if (sayi < 0) return BadRequest();
            return Content(Math.Sqrt(sayi).ToString());
        }

        //EmptyResult
        public IActionResult Bosver()
        {
            return new EmptyResult();
        }

        //ContentResult : http
        public IActionResult Duyuru()
        {
            return Content("<h1> Ankara'da kar yağacak </h1>", "text/html", System.Text.Encoding.UTF8);
        }


        public IActionResult Cizim()
        {
            byte[] result;
            Image image = new Image<Rgba32>(400, 400, new Rgba32(0, 0, 0));

            IPath yourPolygon = new Star(x: 100.0f, y: 100.0f, prongs: 5, innerRadii: 20.0f, outerRadii: 30.0f);

            image.Mutate(x => x.Fill(Color.Red, yourPolygon)); // fill the star with red
            using (var ms = new MemoryStream())
            {
                image.Save(ms, new PngEncoder());
                result = ms.ToArray();
            }

            return File(result, "image/png");
        }

        public IActionResult Manzara()
        {

            var fs = new FileStream(_env.WebRootPath + @"\img\ankara.jpg", FileMode.Open);
            return File(fs, "image/jpeg");
        }
    }
}
