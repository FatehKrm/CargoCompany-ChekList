namespace SirketProjem
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            BtnGeriF5 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnAraF5 = new Button();
            dataGridView1 = new DataGridView();
            txtBoxAra = new TextBox();
            btnDuzenleF5 = new Button();
            BtnSilMusteriF5 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnGeriF5
            // 
            BtnGeriF5.BackColor = SystemColors.ActiveCaption;
            BtnGeriF5.Location = new Point(12, 411);
            BtnGeriF5.Name = "BtnGeriF5";
            BtnGeriF5.Size = new Size(92, 29);
            BtnGeriF5.TabIndex = 1;
            BtnGeriF5.Text = "Geri";
            BtnGeriF5.UseVisualStyleBackColor = false;
            BtnGeriF5.Click += BtnGeriF5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuBar;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 2;
            label1.Text = "Müşteri Listesi ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // BtnAraF5
            // 
            BtnAraF5.BackColor = SystemColors.ActiveCaption;
            BtnAraF5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnAraF5.ForeColor = SystemColors.ControlText;
            BtnAraF5.Location = new Point(307, 70);
            BtnAraF5.Name = "BtnAraF5";
            BtnAraF5.Size = new Size(110, 29);
            BtnAraF5.TabIndex = 6;
            BtnAraF5.Text = "Ara";
            BtnAraF5.UseVisualStyleBackColor = false;
            BtnAraF5.Click += BtnAraF5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(653, 301);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBoxAra
            // 
            txtBoxAra.Font = new Font("Segoe UI", 11F);
            txtBoxAra.Location = new Point(42, 71);
            txtBoxAra.Name = "txtBoxAra";
            txtBoxAra.Size = new Size(259, 27);
            txtBoxAra.TabIndex = 8;
            // 
            // btnDuzenleF5
            // 
            btnDuzenleF5.BackColor = Color.DarkSeaGreen;
            btnDuzenleF5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDuzenleF5.Location = new Point(686, 104);
            btnDuzenleF5.Name = "btnDuzenleF5";
            btnDuzenleF5.Size = new Size(149, 39);
            btnDuzenleF5.TabIndex = 9;
            btnDuzenleF5.Text = " Güncelle ";
            btnDuzenleF5.UseVisualStyleBackColor = false;
            btnDuzenleF5.Click += button1_Click;
            // 
            // BtnSilMusteriF5
            // 
            BtnSilMusteriF5.BackColor = Color.Red;
            BtnSilMusteriF5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnSilMusteriF5.Location = new Point(686, 149);
            BtnSilMusteriF5.Name = "BtnSilMusteriF5";
            BtnSilMusteriF5.Size = new Size(149, 39);
            BtnSilMusteriF5.TabIndex = 10;
            BtnSilMusteriF5.Text = "Sil";
            BtnSilMusteriF5.UseVisualStyleBackColor = false;
            BtnSilMusteriF5.Click += BtnSilMusteriF5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuBar;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(987, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(987, 450);
            Controls.Add(BtnSilMusteriF5);
            Controls.Add(btnDuzenleF5);
            Controls.Add(txtBoxAra);
            Controls.Add(dataGridView1);
            Controls.Add(BtnAraF5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(BtnGeriF5);
            Controls.Add(pictureBox2);
            Name = "Form5";
            Text = "Müşteri Listesi ";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGeriF5;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnAraF5;
        private DataGridView dataGridView1;
        private TextBox txtBoxAra;
        private Button btnDuzenleF5;
        private Button BtnSilMusteriF5;
        private PictureBox pictureBox2;
    }
}