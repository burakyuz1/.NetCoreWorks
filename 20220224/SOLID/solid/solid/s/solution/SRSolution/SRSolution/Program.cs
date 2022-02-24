using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesajlar.Hosgeldin();

            Kisi kisi = KisiVeriSaglayici.Oku();

            bool kullaniciGecerliMi = KisiDogrulayici.Dogrula(kisi);

            if (!kullaniciGecerliMi)
            {
                Mesajlar.UygulamayiSonlandir();
                return;
            }

            HesapOlusturucu.HesapOlustur(kisi);

            Mesajlar.UygulamayiSonlandir();
        }
    }
}
