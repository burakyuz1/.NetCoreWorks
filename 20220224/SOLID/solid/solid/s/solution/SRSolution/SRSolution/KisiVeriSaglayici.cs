using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRSolution
{
    public class KisiVeriSaglayici
    {
        public static Kisi Oku()
        {
            // Kullanıcı bilgisi iste
            Kisi kisi = new Kisi();

            Console.Write("Adınız: ");
            kisi.Ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            kisi.Soyad = Console.ReadLine();

            return kisi;
        }
    }
}
