using Microsoft.AspNetCore.Mvc;

namespace _00MVC_Giris.Controllers
{
    public class CoffeesController : Controller
    {
        public string KenyaCoffee()
        {
            return "It has a mouth-watering acidity (sharpness). Kenya, which has distinctive grapefruit and grape flavors in its taste, presents the acidity (sharpness) and citrus flavors that are characteristic of the region where it is grown.";
        }

        public IActionResult TurkishCoffee()
        {
            return View();
        }

        public string LatteCoffee()
        {
            return "Caffè latte (Italian: [kafˌfɛ lˈlatte][1][2]), often shortened to just latte (/ˈlɑːteɪ, ˈlæteɪ/)[3][4] in English, is a coffee drink of Italian origin made with espresso and steamed milk.";
        }

     
    }
}
