using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSolution
{
    public class SmsMesaj : IMesaj
    {
        public IList<string> GidecekAdresler { get; set; }

        public string MesajGovde { get; set; }

        public bool Gonder()
        {
            // smsin gönderilmesi için gereken kodlar

            return true;
        }

        public override string ToString()
        {
            return "SMS Mesajı";
        }
    }
}
