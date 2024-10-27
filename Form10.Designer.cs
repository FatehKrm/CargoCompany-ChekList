namespace SirketProjem
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label3 = new Label();
            BtnGeriF10 = new Button();
            BtnGosterF10 = new Button();
            BtnF11Goster = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(583, 19);
            label1.TabIndex = 0;
            label1.Text = "Bu kısımda Müşterilerin Getirilen Malların Tarihine göre Detayları Görebilirsiniz ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1131, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(635, 293);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label2.Location = new Point(806, 192);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 3;
            label2.Text = "Tarih Seçiniz ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(786, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(705, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label3.Location = new Point(777, 92);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 6;
            label3.Text = "Müşteri Seçiniz ";
            // 
            // BtnGeriF10
            // 
            BtnGeriF10.BackColor = SystemColors.ActiveCaption;
            BtnGeriF10.Location = new Point(786, 386);
            BtnGeriF10.Name = "BtnGeriF10";
            BtnGeriF10.Size = new Size(80, 26);
            BtnGeriF10.TabIndex = 7;
            BtnGeriF10.Text = "Geri";
            BtnGeriF10.UseVisualStyleBackColor = false;
            BtnGeriF10.Click += button1_Click;
            // 
            // BtnGosterF10
            // 
            BtnGosterF10.BackColor = Color.YellowGreen;
            BtnGosterF10.Location = new Point(826, 280);
            BtnGosterF10.Name = "BtnGosterF10";
            BtnGosterF10.Size = new Size(84, 30);
            BtnGosterF10.TabIndex = 8;
            BtnGosterF10.Text = "Göster";
            BtnGosterF10.UseVisualStyleBackColor = false;
            BtnGosterF10.Click += BtnGosterF10_Click;
            // 
            // BtnF11Goster
            // 
            BtnF11Goster.BackColor = SystemColors.ActiveCaption;
            BtnF11Goster.Location = new Point(927, 386);
            BtnF11Goster.Name = "BtnF11Goster";
            BtnF11Goster.Size = new Size(75, 26);
            BtnF11Goster.TabIndex = 9;
            BtnF11Goster.Text = "Aç";
            BtnF11Goster.UseVisualStyleBackColor = false;
            BtnF11Goster.Click += BtnF11Goster_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 450);
            Controls.Add(BtnF11Goster);
            Controls.Add(BtnGosterF10);
            Controls.Add(BtnGeriF10);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form10";
            Text = "Tarihçe";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label3;
        private Button BtnGeriF10;
        private Button BtnGosterF10;
        private Button BtnF11Goster;
    }
}