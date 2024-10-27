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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");


        private void BtnGunceliKaydet_Click(object sender, EventArgs e)
        {



            try
            {
                baglan.Open();
                string querry = "UPDATE insertCustomer " +
                 "SET Name = '" + txtBoxAdGuncelle.Text + "', " +
                 "    LastName = '" + txtBoxSoyadGuncelle.Text + "', " +
                 "    BillNo = '" + txtBoxMusteriFturaAdiF7Guncel.Text + "' " +
                 "WHERE Name = '" + txtBoxMusteriAdiF7.Text + "' " +
                 "AND LastName = '" + txtBoxMusteriSoyadiF7.Text + "' " +
                 "AND BillNo = '" + txtBoxMusteriFaturaF7.Text + "'";


                SqlCommand cmd = new SqlCommand(querry, baglan);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Veriler başarıyla Güncellendi");

                    txtBoxAdGuncelle.Clear();
                    txtBoxSoyadGuncelle.Clear();
                    txtBoxMusteriFturaAdiF7Guncel.Clear();
                    txtBoxMusteriAdiF7.Clear();
                    txtBoxMusteriSoyadiF7.Clear();
                    txtBoxMusteriFaturaF7.Clear();
                }
                else
                {
                    MessageBox.Show("Veiler Kaydedilemedi Belirtilen Verilere uygun kayıt bulunamadı ");

                    txtBoxAdGuncelle.Clear();
                    txtBoxSoyadGuncelle.Clear();
                    txtBoxMusteriFturaAdiF7Guncel.Clear();
                    txtBoxMusteriAdiF7.Clear();
                    txtBoxMusteriSoyadiF7.Clear();
                    txtBoxMusteriFaturaF7.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik Bir Hata Oluştu " + ex.Message);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void BtnGeri4_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }
    }
}
