using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lstKuslar.Items.Add(new Kartal());
            lstKuslar.Items.Add(new Serce());
            lstKuslar.Items.Add(new DeveKusu());
        }

        private void btnUcur_Click(object sender, EventArgs e)
        {
            foreach (var kus in lstKuslar.Items)
            {
                if (kus is UcabilenKus)
                {
                    MessageBox.Show(((UcabilenKus)kus).Uc());
                }
            }
        }
    }
}
