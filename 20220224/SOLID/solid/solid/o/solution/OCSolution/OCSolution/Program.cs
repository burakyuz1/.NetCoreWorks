using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new GumusMusteri
            {
                Ad = "Ali",
                Soyad = "Yılmaz"
            };

            Console.WriteLine("{0} {1} için indirimli tutar: {2:0.00}TL", m1.Ad, m1.Soyad, m1.IndirimYap(1000));

            Musteri m2 = new AltinMusteri
            {
                Ad = "Ayşe",
                Soyad = "Öz"
            };

            Console.WriteLine("{0} {1} için indirimli tutar: {2:0.00}TL", m2.Ad, m2.Soyad, m2.IndirimYap(1000));

            Console.ReadKey();
        }
    }
}
