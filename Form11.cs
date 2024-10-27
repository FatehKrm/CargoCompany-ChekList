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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=LAPTOP-I1EN423K\MSSQLSERVER01;Initial Catalog=TravelTraffik ;Integrated Security=True;");


        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                string querry = "SELECT * FROM MalListesi ";
                baglan.Open();
                SqlCommand cmd = new SqlCommand(querry, baglan);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluşu " + ex);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void BtnGeriF11_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAraF11_Click(object sender, EventArgs e)
        {
           
                try
                {
                    baglan.Open();

                    string querry = "SELECT MalTuru, Kilo, Adet, MusteriAdi, MusteriSoyadi, Tarih FROM MalListesi WHERE MusteriAdi = @Name";
                    SqlCommand cmd = new SqlCommand(querry, baglan);
                    cmd.Parameters.AddWithValue("@Name", txtBoxFiltrele.Text);

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dtb = new DataTable();
                    sda.Fill(dtb);
                    dataGridView1.DataSource = dtb;
                    dataGridView1.AllowUserToAddRows = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglan.Close();
                }
            }

        }
    }
