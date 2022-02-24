using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISolution
{
    // DI prensibini uyguladık ve artık üst seviye sınıfımız olan Bildirim, daha alt seviye olan Email ve Sms concrete sınıflara bağımlı değil. Onun yerine ortak bir interface olan IMesaj'a bağlı. Bu sayede concrete sınıflarımızdaki değişiklikler daha üst seviye olan Bildirim sınıfını olumsuz etkilemeyecek.

    public class Bildirim
    {
        private ICollection<IMesaj> _mesajlar;

        public Bildirim(ICollection<IMesaj> mesajlar)
        {
            _mesajlar = mesajlar;
        }

        public void Gonder()
        {
            foreach (var mesaj in _mesajlar)
            {
                mesaj.Gonder();
            }
        }
    }
}
