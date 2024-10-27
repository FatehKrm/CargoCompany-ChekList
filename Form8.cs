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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");


        private void btnGeriF8_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();

            txtBoxMusteriAdiSil.Clear();
            txtBoxMusteriSoyadiSil.Clear();
            txtBoxFaturaSilF8.Clear();

        }

        private void BtnGeriF8_Click_1(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();

            txtBoxMusteriAdiSil.Clear();
            txtBoxMusteriSoyadiSil.Clear();
            txtBoxFaturaSilF8.Clear();

        }

        private void BtnVazgecF8_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();

            txtBoxMusteriAdiSil.Clear();
            txtBoxMusteriSoyadiSil.Clear();
            txtBoxFaturaSilF8.Clear();


        }

        private void btnSilF8_Click(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                string querry = "DELETE FROM insertCustomer WHERE Name = '" + txtBoxMusteriAdiSil.Text + "' AND LastName = '" + txtBoxMusteriSoyadiSil.Text + "' AND BillNo = '"+txtBoxFaturaSilF8.Text+"' ";
                SqlCommand cmd = new SqlCommand(querry, baglan);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Veriler Başarıyla Silindi ");
                    txtBoxMusteriAdiSil.Clear();
                    txtBoxMusteriSoyadiSil.Clear();
                    txtBoxFaturaSilF8.Clear();

                }
                else
                {
                    MessageBox.Show("Girilen verilere uygun veri bulunamadı ");
                    txtBoxMusteriAdiSil.Clear();
                    txtBoxMusteriSoyadiSil.Clear();
                    txtBoxFaturaSilF8.Clear();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu Lütfen tekrar deneyiniz " + ex);
            }
            finally
            {
                baglan.Close();
            }




        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
