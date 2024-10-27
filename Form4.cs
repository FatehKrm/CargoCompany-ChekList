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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnBigileriKaydet_Click(object sender, EventArgs e)

        {

         
            if (txtBoxMusteriAdi.Text == "" || txtBoxMusteriSoyadi.Text == "" || txtBoxMusteriFturaAdi.Text == "")
            {
                MessageBox.Show("Kutulara boş veri giremezsiniz ");

            }
            else
            {

                try
                {
                    baglan.Open();

                    SqlCommand cmd = new SqlCommand("insert into insertCustomer(Name , LastName , BillNo ) values ('" + txtBoxMusteriAdi.Text + "' , '" + txtBoxMusteriSoyadi.Text + "' , '" + txtBoxMusteriFturaAdi.Text + "') ", baglan);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show(" Bilgiler kaydedildi ");
                    }
                    else
                    {
                        MessageBox.Show("Beklenmedik  bir hata oluştu lütfen tekrar deneyin ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu lütfen tekrar deneyiniz " + ex);
                }
                finally
                {
                    baglan.Close();
                }


                txtBoxMusteriAdi.Clear();
                txtBoxMusteriSoyadi.Clear();
                txtBoxMusteriFturaAdi.Clear();


            }




        }

        private void txtBoxMusteriAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
