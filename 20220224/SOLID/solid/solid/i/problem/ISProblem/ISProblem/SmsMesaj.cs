using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProblem
{
    public class SmsMesaj : IMesaj
    {
        public IList<string> GidecekAdresler { get; set; }

        public string MesajGovde { get; set; }

        // SMS'lerde konu alanı olmadığı için IMesaj interface'i tarafından implement edilmeye zorlanan bu property implement edilemiyor. Interface Segregation prensibine göre bir interface onu kullanan class'ların ihtiyacı olmayan metot ya da özellikleri uygulamaya zorlamamalı
        public string Konu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // aynı şekilde bcc de emaillere özgüdür
        public IList<string> GidecekBccAddresler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
