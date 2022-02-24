using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uygulamaya hoşgeldiniz..");

            #region Kullanıcı bilgilerini iste
            Kisi kisi = new Kisi();

            Console.Write("Adınız: ");
            kisi.Ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            kisi.Soyad = Console.ReadLine();
            #endregion

            #region Veri geçerliliğini kontrol et
            if (string.IsNullOrWhiteSpace(kisi.Ad))
            {
                Console.WriteLine("Geçersiz bir ad girdiniz!");
                Console.Write("Uygulamadan çıkmak için bir tuşa basınız..");
                Console.ReadKey();
                return;
            }

            if (string.IsNullOrWhiteSpace(kisi.Soyad))
            {
                Console.WriteLine("Geçersiz bir soyad girdiniz!"); ;
                Console.Write("Uygulamadan çıkmak için bir tuşa basınız..");
                Console.ReadKey();
                return;
            }
            #endregion

            #region Kullanıcı adı oluştur
            string username = kisi.Ad.Substring(0, 1).ToLower() + kisi.Soyad.ToLower();
            Console.WriteLine("Kullanıcı adınız: {0}", username);
            #endregion
            
            Console.Write("Uygulamadan çıkmak için bir tuşa basınız..");
            Console.ReadKey();
        }
    }
}
