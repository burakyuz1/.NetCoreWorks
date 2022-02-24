using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSolution
{
    public class SmtpMesaj : IEmailMesaj
    {
        public IList<string> GidecekAdresler { get; set; }

        public IList<string> GidecekBccAddresler { get; set; }

        public string MesajGovde { get; set; }

        public string Konu { get; set; }

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
