using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProblem
{
    // Buradaki sorun: Bildirim sınıfı Sms ve Email sınıflarına göre daha üst seviye bir sınıftır. DI prensibine göre üst seviye sınıflar alt seviye sınıflara bağlı olmamalıdır. Bunun yerine üst seviye ve alt seviye sınıflar abstract sınıflara bağlı (depend) olmalıdır.
    public class Bildirim
    {
        private Email _email;
        private Sms _sms;

        public Bildirim()
        {
            _email = new Email();
            _sms = new Sms();
        }

        public void Gonder()
        {
            _email.EmailGonder();
            _sms.SmsGonder();
        }
    }
}
