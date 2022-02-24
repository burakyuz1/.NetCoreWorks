using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolution
{
    public class AltinMusteri : Musteri
    {
        public override decimal IndirimYap(decimal toplamTutar)
        {
            return base.IndirimYap(toplamTutar) * 0.90m;
        }
    }
}
