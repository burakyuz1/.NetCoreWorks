using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProblem
{
    public class SmtpMesaj : IMesaj
    {
        public IList<string> GidecekAdresler { get; set; }

        public string MesajGovde { get; set; }

        public string Konu { get; set; }

        public IList<string> GidecekBccAddresler { get; set; }

        public bool Gonder()
        {
            // mailin gönderilmesi için gereken kodlar

            return true;
        }

        public override string ToString()
        {
            return "SMTP Mesajı";
        }
    }
}
