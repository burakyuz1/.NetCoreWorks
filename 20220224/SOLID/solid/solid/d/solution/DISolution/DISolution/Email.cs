using DISolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISolution
{
    public class Email : IMesaj
    {
        public string GonderilenAdres { get; set; }

        public string Konu { get; set; }

        public string Icerik { get; set; }

        public void Gonder()
        {
            // mail gönder
        }
    }
}
