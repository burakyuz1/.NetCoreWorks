using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRSolution
{
    public static class KisiDogrulayici
    {
        public static bool Dogrula(Kisi kisi)
        {
            // Ad ve soyad geçerli mi?
            if (string.IsNullOrWhiteSpace(kisi.Ad))
            {
                Mesajlar.DogrulamaHatasiGoster("ad");
                return false;
            }

            if (string.IsNullOrWhiteSpace(kisi.Soyad))
            {
                Mesajlar.DogrulamaHatasiGoster("soyad");
                return false;
            }

            return true;
        }
    }
}
