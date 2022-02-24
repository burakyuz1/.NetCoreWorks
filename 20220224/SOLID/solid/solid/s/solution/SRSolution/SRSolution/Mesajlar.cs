using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRSolution
{
    public static class Mesajlar
    {
        public static void Hosgeldin()
        {
            Console.WriteLine("Uygulamaya hoşgeldiniz..");
        }

        public static void UygulamayiSonlandir()
        {
            Console.Write("Uygulamadan çıkmak için bir tuşa basınız..");
            Console.ReadKey();
        }

        public static void DogrulamaHatasiGoster(string alanAdi)
        {
            Console.WriteLine($"Geçersiz bir {alanAdi} girdiniz!");
        }
    }
}
