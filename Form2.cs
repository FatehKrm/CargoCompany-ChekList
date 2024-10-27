using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketProjem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtBoxSifre.UseSystemPasswordChar = true;
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtBoxKullaniciAdi.Text;
            string sifre = txtBoxSifre.Text;

            try
            {
                baglan.Open();

                string querry = "SELECT * FROM userLog1 WHERE userName = '"+txtBoxKullaniciAdi.Text+"' AND passWord = '"+txtBoxSifre.Text+"' ";

                SqlDataAdapter sda = new SqlDataAdapter(querry , baglan);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);

            if (dtb.Rows.Count > 0)
                {
                    kullaniciAdi = txtBoxKullaniciAdi.Text;
                    sifre = txtBoxSifre.Text;

                    Form3 Form3 = new Form3();
                    Form3.Show();
                    this.Hide();

                }else
                {
                    MessageBox.Show("Hatalı şifre veya Kullanıcı adı girdiniz ");

                }


            }
            catch
            {

            }
            finally
            {
                baglan.Close();
            }

        }
    }
}
