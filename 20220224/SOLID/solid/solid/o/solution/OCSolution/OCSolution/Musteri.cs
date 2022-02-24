using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolution
{
    public class Musteri
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public virtual decimal IndirimYap(decimal toplamTutar)
        {
            return toplamTutar;
        }
    }
}
