using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSolution
{
    interface IEmailMesaj : IMesaj
    {
        IList<string> GidecekBccAddresler { get; set; }

        string Konu { get; set; }
    }
}
