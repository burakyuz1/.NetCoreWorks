using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISolution
{
    public class Sms : IMesaj
    {
        public string TelefonNumarasi { get; set; }

        public string Mesaj { get; set; }

        public void Gonder()
        {
            // sms gönder
        }
    }
}
