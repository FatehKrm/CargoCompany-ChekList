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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");


        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string querry = "SELECT * FROM MalListesi";
                SqlCommand cmd = new SqlCommand(querry, baglan);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası oluştu lütfen Tekrar deneyiniz " + ex);
            }
            finally
            {
                baglan.Close();
            }


            try
            {
                baglan.Open();
                string querry = " SELECT DISTINCT MusteriAdi , MusteriSoyadi FROM MalListesi ";
                SqlCommand cmd = new SqlCommand(querry, baglan);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string MusteriAdi = reader["MusteriAdi"].ToString();
                    string MusteriSoyadi = reader["MusteriSoyadi"].ToString();
                    comboBox1.Items.Add(MusteriAdi);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Veriler getirilemedi! " + ex);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGosterF10_Click(object sender, EventArgs e)
        {

            string secilmisDeger = comboBox1.SelectedItem.ToString();
            DateTime dateTime = dateTimePicker1.Value;
            string formattedDate = dateTime.ToString("yyyy-MM-dd");

            baglan.Open();

            string querry = "SELECT * FROM MalListesi WHERE MusteriAdi = '" + secilmisDeger + "' AND Tarih = '" + formattedDate + "' ";
            SqlCommand cmd = new SqlCommand(querry, baglan);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;



            baglan.Close();
        }

        private void BtnF11Goster_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
