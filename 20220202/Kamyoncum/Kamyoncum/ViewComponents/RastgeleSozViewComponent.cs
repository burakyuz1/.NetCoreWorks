using Kamyoncum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Kamyoncum.ViewComponents
{
    public class RastgeleSozViewComponent : ViewComponent
    {
        private readonly UygulamaContext _db;

        public RastgeleSozViewComponent(UygulamaContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool kalinMi)
        {
            int toplamAdet = await _db.Sozler.CountAsync();
            int atla = new Random().Next(toplamAdet);
            Soz soz = _db.Sozler.Skip(atla).Take(1).First();

            RastgeleSozViewModel rastgeleSozViewModel = new RastgeleSozViewModel()
            {
                Soz = soz,
                KalinMi = kalinMi
            };

            return View(rastgeleSozViewModel);
        }
    }
}
