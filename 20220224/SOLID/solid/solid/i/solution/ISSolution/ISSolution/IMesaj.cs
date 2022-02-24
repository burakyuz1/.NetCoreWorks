using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSolution
{
    // artık Interface Segregation prensibine uygun olarak bu interface'de sadece tüm mesaj sınıflarını ilgilendiren metot ve property'ler yer alıyor
    interface IMesaj
    {
        IList<string> GidecekAdresler { get; set; }

        string MesajGovde { get; set; }

        bool Gonder();

    }
}
