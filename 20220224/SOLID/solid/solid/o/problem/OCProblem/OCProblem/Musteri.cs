using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCProblem
{
    public enum MusteriTur
    {
        Standart,
        Gumus
        // Altin
    }

    public class Musteri
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public MusteriTur MusteriTur { get; set; }

        // Yeni bir müşteri türü ekledikçe metotta değişikliğe gitmek zorunda kalıyoruz.
        // Sınıflarda bu tür değişiklikler sınıfın kullanıldığı tüm yerlerde ön görülmedik sonuçlar doğurabilir.
        // Açık Kapalı prensipi değişiklik yapmak yerine sınıfların genişletilmeye açık yazılmasını önerir. (Çözüme bakınız.)
        public decimal IndirimYap(decimal toplamTutar)
        {
            if (MusteriTur == MusteriTur.Gumus)
            {
                return toplamTutar * 0.95m;
            }
            //else if (MusteriTur == MusteriTur.Altin)
            //{
            //    return toplamTutar * 0.90m;
            //}
            else
            {
                return toplamTutar;
            }
        }
    }
}
