using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketProjem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void BtnMusteriBilgi_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();

        }

        private void BtnMalList_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
            this.Hide();

        }

        private void BtnCikarF3_Click(object sender, EventArgs e)
        {


        }

        private void BtnTarihce_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
            this.Hide();
        }
    }
}
