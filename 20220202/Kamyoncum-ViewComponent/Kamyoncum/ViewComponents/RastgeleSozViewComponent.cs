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


            //async yapmasaydık, eğer 30 kişi aynı anda db den sözlerin count'unu çekmek istediğinde boşta thread kalmadığı için 31. kişi 1. kişinin threadini beklemek zorunda kalırdı.
            // fakat async yaparak db deki sözlerin gelmesini beklerken thread db sorgusunun bitmesini beklemeden diğer işlemini yapmaya gider.
            // dolayısıyla 31. kişi de boş boş beklememiş olur. 
            // peki neden await yaptık?
            // çünkü async olarak çalıştığı için thread sözlerin count'ını çekmesini beklemeden çeker gider alt satıra, e dolayısıyla sözlerin sayımı bitmeden ilgili satırdan ayrılabilir.
            // biz de await diyerek, buradaki işlemini bitir. öyle devam et demiş olduk.
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
