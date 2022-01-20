using Microsoft.AspNetCore.Mvc;

namespace _00MVC_Giris.Controllers
{
    public class MathController : Controller
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public IActionResult Square(int num)
        {
            ViewBag.Number = num;


            ViewBag.Result = num * num;

            return View();
        }
    }
}
