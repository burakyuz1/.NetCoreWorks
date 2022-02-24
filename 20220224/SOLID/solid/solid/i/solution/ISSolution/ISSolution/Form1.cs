using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstMesajlar.Items.Add(new SmtpMesaj());
            lstMesajlar.Items.Add(new SmsMesaj());
        }

        private void btnMesajlariGonder_Click(object sender, EventArgs e)
        {
            foreach (IMesaj mesaj in lstMesajlar.Items)
            {
                mesaj.Gonder();
            }
        }
    }
}
