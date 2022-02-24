using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProblem
{
    interface IMesaj
    {
        IList<string> GidecekAdresler { get; set; }

        IList<string> GidecekBccAddresler { get; set; }

        string MesajGovde { get; set; }

        string Konu { get; set; }

        bool Gonder();

    }
}
