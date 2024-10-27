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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");



        private int sira = 1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGeriF9_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();

        }

        private void BtnEkleF9_Click(object sender, EventArgs e)
        {

            string str = txtBoxKiloF9.Text;
            float floatValue;

            try
            {
                floatValue = float.Parse(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Uygun bir değer giriniz ! " + ex);
                return;
            }



            int rowIndex = dataGridView1.Rows.Add();
            if (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.Cells[0].Value = sira;
                row.Cells[1].Value = txtBoxMalTuruF9.Text;
                row.Cells[2].Value = txtBoxAdetF9.Text;
                row.Cells[3].Value = floatValue;

                sira++;   // important *
            }

            try
            {
                string MalListesiMusteriAdi = txtBoxAdF9.Text.Trim();

                baglan.Open();

                DateTime dateTime = dateTimePicker1.Value;
                string formattedDate = dateTime.ToString("yyyy-MM-dd");

                string querry = "insert into  MalListesi  (MalTuru , Kilo , Adet , MusteriAdi , MusteriSoyadi , Tarih ) values ( '" + txtBoxMalTuruF9.Text + "' , '" + txtBoxKiloF9.Text + "' , '" + txtBoxAdetF9.Text + "' , '" + txtBoxAdF9.Text + "' , '" + txtBoxSoyad.Text + "' , '" + formattedDate + "' ) ";

                SqlCommand cmd = new SqlCommand(querry, baglan);


                int i = cmd.ExecuteNonQuery();

                baglan.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu " + ex);
            }


            txtBoxAdetF9.Clear();
            txtBoxKiloF9.Clear();
            txtBoxMalTuruF9.Clear();

        }

        private void BtnKaydetF9_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" Bilgiler Başarıla kaydedildi ");

            txtBoxAdetF9.Clear();
            txtBoxKiloF9.Clear();
            txtBoxMalTuruF9.Clear();
            txtBoxAdF9.Clear();
            txtBoxSoyad.Clear();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

        }



        private void button1_Click(object sender, EventArgs e) // btnSilF9
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                dataGridView1.Rows.Remove(selectedRow);
            }

            try
            {
                baglan.Open();
                string querry = "DELETE FROM MalListesi WHERE MusteriAdi = '" + txtBoxAdF9.Text + "' AND MusteriSoyadi = '" + txtBoxSoyad.Text + "'  ";
                SqlCommand cmd = new SqlCommand(querry, baglan);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu  " + ex);
            }
            finally
            {
                baglan.Close();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

