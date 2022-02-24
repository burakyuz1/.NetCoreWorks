using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRSolution
{
    public static class HesapOlusturucu
    {
        public static void HesapOlustur(Kisi kisi)
        {
            // Kullanıcı adı oluştur
            string username = kisi.Ad.Substring(0, 1).ToLower() + kisi.Soyad.ToLower();
            Console.WriteLine("Kullanıcı adınız: {0}", username);
        }
    }
}
