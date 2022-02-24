using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBildirimGonder_Click(object sender, EventArgs e)
        {
            var mesajlar = new List<IMesaj>
            {
                new Sms(),
                new Email()
            };

            Bildirim bildirim = new Bildirim(mesajlar);
            bildirim.Gonder();
        }
    }
}
