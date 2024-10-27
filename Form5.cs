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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");

        private void BtnGeriF5_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void btnKaydetF5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAraF5_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string querry = " SELECT Name , LastName , BillNo FROM insertCustomer WHERE Name = @Name ";
                SqlCommand cmd = new SqlCommand(querry, baglan);
                cmd.Parameters.AddWithValue("@Name", txtBoxAra.Text);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dtb = new DataTable();
                dtb.Clear();
                sda.Fill(dtb);
                dataGridView1.DataSource = dtb;
                dataGridView1.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata oluştu lütfen daha sonra deneyiniz " + ex);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();

                SqlCommand cmd = new SqlCommand("SELECT Name, LastName, BillNo FROM insertCustomer", baglan);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                dataGridView1.DataSource = dtb; // DataTable'ı dataGridView'e bağlayın

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu, lütfen birazdan tekrar deneyiniz: " + ex.Message);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form7 Form7 = new Form7();
            Form7.Show();
            this.Hide();

        }

        private void BtnSilMusteriF5_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
