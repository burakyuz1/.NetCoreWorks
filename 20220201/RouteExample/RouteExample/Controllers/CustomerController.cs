using Microsoft.AspNetCore.Mvc;

namespace RouteExample.Controllers
{
    //[Route("musteri")]
    public class CustomerController : Controller
    {
        [Route("listele")]
        //Veya
        //[Route("musteri/listele")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("sil/{id}")]
        public IActionResult Delete(int id)
        {
            return View(id);
        }


        [Route("guncelle/{id}")]

        public IActionResult Update(int id)
        {
            return View(id);
        }

        //Custom endpoint
        public IActionResult Add()
        {
            return View();
        }

    }
}
