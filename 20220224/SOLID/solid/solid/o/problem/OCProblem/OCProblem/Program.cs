using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                MusteriTur = MusteriTur.Standart
            };

            Console.WriteLine("{0} {1} için indirimli tutar: {2:0.00}TL", m1.Ad, m1.Soyad, m1.IndirimYap(1000));

            Musteri m2 = new Musteri
            {
                Ad = "Ayşe",
                Soyad = "Öz",
                MusteriTur = MusteriTur.Gumus
            };

            Console.WriteLine("{0} {1} için indirimli tutar: {2:0.00}TL", m2.Ad, m2.Soyad, m2.IndirimYap(1000));

            Console.ReadKey();
        }
    }
}
