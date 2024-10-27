namespace SirketProjem
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            SutunSıra = new DataGridViewTextBoxColumn();
            sustunTur = new DataGridViewTextBoxColumn();
            stunAdet = new DataGridViewTextBoxColumn();
            sustunKilo = new DataGridViewTextBoxColumn();
            BtnKaydetF9 = new Button();
            BtnGeriF9 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxMalTuruF9 = new TextBox();
            txtBoxAdetF9 = new TextBox();
            txtBoxKiloF9 = new TextBox();
            BtnEkleF9 = new Button();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBoxAdF9 = new TextBox();
            txtBoxSoyad = new TextBox();
            BtnSilF9 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuBar;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(501, 12);
            label1.Name = "label1";
            label1.Size = new Size(520, 21);
            label1.TabIndex = 0;
            label1.Text = "Müşterini getirdiği mallarının bilgilerini doldurduktan sonra kaydediniz";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SutunSıra, sustunTur, stunAdet, sustunKilo });
            dataGridView1.Location = new Point(467, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(558, 303);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SutunSıra
            // 
            SutunSıra.HeaderText = "Sıra ";
            SutunSıra.Name = "SutunSıra";
            SutunSıra.ReadOnly = true;
            SutunSıra.Width = 50;
            // 
            // sustunTur
            // 
            sustunTur.HeaderText = "Tür";
            sustunTur.Name = "sustunTur";
            sustunTur.ReadOnly = true;
            sustunTur.Width = 170;
            // 
            // stunAdet
            // 
            stunAdet.HeaderText = "Adet";
            stunAdet.Name = "stunAdet";
            stunAdet.ReadOnly = true;
            stunAdet.Width = 120;
            // 
            // sustunKilo
            // 
            sustunKilo.HeaderText = "Kilo";
            sustunKilo.Name = "sustunKilo";
            sustunKilo.ReadOnly = true;
            sustunKilo.Width = 175;
            // 
            // BtnKaydetF9
            // 
            BtnKaydetF9.BackColor = SystemColors.Control;
            BtnKaydetF9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnKaydetF9.Location = new Point(53, 511);
            BtnKaydetF9.Name = "BtnKaydetF9";
            BtnKaydetF9.Size = new Size(79, 31);
            BtnKaydetF9.TabIndex = 2;
            BtnKaydetF9.Text = "Kaydet";
            BtnKaydetF9.UseVisualStyleBackColor = false;
            BtnKaydetF9.Click += BtnKaydetF9_Click;
            // 
            // BtnGeriF9
            // 
            BtnGeriF9.BackColor = SystemColors.Control;
            BtnGeriF9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnGeriF9.Location = new Point(144, 511);
            BtnGeriF9.Name = "BtnGeriF9";
            BtnGeriF9.Size = new Size(79, 31);
            BtnGeriF9.TabIndex = 3;
            BtnGeriF9.Text = "Gri";
            BtnGeriF9.UseVisualStyleBackColor = false;
            BtnGeriF9.Click += BtnGeriF9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuBar;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(227, 233);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mal Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuBar;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(239, 267);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Adet ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuBar;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(249, 308);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 6;
            label4.Text = "Kilo";
            // 
            // txtBoxMalTuruF9
            // 
            txtBoxMalTuruF9.Location = new Point(303, 233);
            txtBoxMalTuruF9.Name = "txtBoxMalTuruF9";
            txtBoxMalTuruF9.Size = new Size(126, 23);
            txtBoxMalTuruF9.TabIndex = 7;
            // 
            // txtBoxAdetF9
            // 
            txtBoxAdetF9.Location = new Point(303, 268);
            txtBoxAdetF9.Name = "txtBoxAdetF9";
            txtBoxAdetF9.Size = new Size(126, 23);
            txtBoxAdetF9.TabIndex = 8;
            // 
            // txtBoxKiloF9
            // 
            txtBoxKiloF9.Location = new Point(303, 305);
            txtBoxKiloF9.Name = "txtBoxKiloF9";
            txtBoxKiloF9.PlaceholderText = "örn 5,600";
            txtBoxKiloF9.Size = new Size(126, 23);
            txtBoxKiloF9.TabIndex = 9;
            // 
            // BtnEkleF9
            // 
            BtnEkleF9.BackColor = Color.DarkSeaGreen;
            BtnEkleF9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnEkleF9.Location = new Point(384, 352);
            BtnEkleF9.Name = "BtnEkleF9";
            BtnEkleF9.Size = new Size(75, 29);
            BtnEkleF9.TabIndex = 10;
            BtnEkleF9.Text = "Ekle";
            BtnEkleF9.UseVisualStyleBackColor = false;
            BtnEkleF9.Click += BtnEkleF9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.MenuBar;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(53, 22);
            label5.Name = "label5";
            label5.Size = new Size(242, 21);
            label5.TabIndex = 11;
            label5.Text = "Lütfen Müşteri Bilgilerini Giriniz ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(741, 150);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 13;
            label6.Text = "Tarih  : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(807, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtBoxAdF9
            // 
            txtBoxAdF9.Font = new Font("Segoe UI", 11F);
            txtBoxAdF9.Location = new Point(71, 68);
            txtBoxAdF9.Name = "txtBoxAdF9";
            txtBoxAdF9.PlaceholderText = "Ad ";
            txtBoxAdF9.Size = new Size(127, 27);
            txtBoxAdF9.TabIndex = 15;
            // 
            // txtBoxSoyad
            // 
            txtBoxSoyad.Font = new Font("Segoe UI", 11F);
            txtBoxSoyad.Location = new Point(71, 101);
            txtBoxSoyad.Name = "txtBoxSoyad";
            txtBoxSoyad.PlaceholderText = "Soyad";
            txtBoxSoyad.Size = new Size(127, 27);
            txtBoxSoyad.TabIndex = 16;
            // 
            // BtnSilF9
            // 
            BtnSilF9.BackColor = Color.IndianRed;
            BtnSilF9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnSilF9.Location = new Point(303, 352);
            BtnSilF9.Name = "BtnSilF9";
            BtnSilF9.Size = new Size(75, 27);
            BtnSilF9.TabIndex = 17;
            BtnSilF9.Text = "Sil";
            BtnSilF9.UseVisualStyleBackColor = false;
            BtnSilF9.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Menu;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(981, 547);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1054, 554);
            Controls.Add(BtnSilF9);
            Controls.Add(txtBoxSoyad);
            Controls.Add(txtBoxAdF9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnEkleF9);
            Controls.Add(txtBoxKiloF9);
            Controls.Add(txtBoxAdetF9);
            Controls.Add(txtBoxMalTuruF9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnGeriF9);
            Controls.Add(BtnKaydetF9);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form9";
            Text = "Getirilen Mal Listesi ";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SutunSıra;
        private DataGridViewTextBoxColumn sustunTur;
        private DataGridViewTextBoxColumn stunAdet;
        private DataGridViewTextBoxColumn sustunKilo;
        private Button BtnKaydetF9;
        private Button BtnGeriF9;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxMalTuruF9;
        private TextBox txtBoxAdetF9;
        private TextBox txtBoxKiloF9;
        private Button BtnEkleF9;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxAdF9;
        private TextBox txtBoxSoyad;
        private Button BtnSilF9;
        private PictureBox pictureBox1;
    }
}