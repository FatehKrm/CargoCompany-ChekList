namespace SirketProjem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            BtnGeri4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxMusteriAdi = new TextBox();
            txtBoxMusteriSoyadi = new TextBox();
            txtBoxMusteriFturaAdi = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            BtnBigileriKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnGeri4
            // 
            BtnGeri4.BackColor = SystemColors.ActiveCaption;
            BtnGeri4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGeri4.Location = new Point(185, 401);
            BtnGeri4.Name = "BtnGeri4";
            BtnGeri4.Size = new Size(75, 28);
            BtnGeri4.TabIndex = 0;
            BtnGeri4.Text = "Geri";
            BtnGeri4.UseVisualStyleBackColor = false;
            BtnGeri4.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Bilgileri : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(398, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 355);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 3;
            label2.Text = "Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label3.Location = new Point(33, 209);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 4;
            label3.Text = "Cinsiyet  : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label4.Location = new Point(33, 135);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 5;
            label4.Text = "Soyadı : ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label5.Location = new Point(12, 294);
            label5.Name = "label5";
            label5.Size = new Size(130, 19);
            label5.TabIndex = 6;
            label5.Text = "Fatura Kod Adı : ";
            // 
            // txtBoxMusteriAdi
            // 
            txtBoxMusteriAdi.Location = new Point(120, 71);
            txtBoxMusteriAdi.Name = "txtBoxMusteriAdi";
            txtBoxMusteriAdi.Size = new Size(150, 23);
            txtBoxMusteriAdi.TabIndex = 7;
            txtBoxMusteriAdi.TextChanged += txtBoxMusteriAdi_TextChanged;
            // 
            // txtBoxMusteriSoyadi
            // 
            txtBoxMusteriSoyadi.Location = new Point(120, 135);
            txtBoxMusteriSoyadi.Name = "txtBoxMusteriSoyadi";
            txtBoxMusteriSoyadi.Size = new Size(150, 23);
            txtBoxMusteriSoyadi.TabIndex = 8;
            // 
            // txtBoxMusteriFturaAdi
            // 
            txtBoxMusteriFturaAdi.Location = new Point(158, 294);
            txtBoxMusteriFturaAdi.Name = "txtBoxMusteriFturaAdi";
            txtBoxMusteriFturaAdi.PlaceholderText = "Örn.Sh01";
            txtBoxMusteriFturaAdi.Size = new Size(144, 23);
            txtBoxMusteriFturaAdi.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(141, 210);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(240, 210);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // BtnBigileriKaydet
            // 
            BtnBigileriKaydet.BackColor = SystemColors.ActiveCaption;
            BtnBigileriKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnBigileriKaydet.Location = new Point(33, 401);
            BtnBigileriKaydet.Name = "BtnBigileriKaydet";
            BtnBigileriKaydet.Size = new Size(75, 28);
            BtnBigileriKaydet.TabIndex = 13;
            BtnBigileriKaydet.Text = "Kaydet";
            BtnBigileriKaydet.UseVisualStyleBackColor = false;
            BtnBigileriKaydet.Click += BtnBigileriKaydet_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBigileriKaydet);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtBoxMusteriFturaAdi);
            Controls.Add(txtBoxMusteriSoyadi);
            Controls.Add(txtBoxMusteriAdi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(BtnGeri4);
            Name = "Form4";
            Text = "Müşteri Ekle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGeri4;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxMusteriAdi;
        private TextBox txtBoxMusteriSoyadi;
        private TextBox txtBoxMusteriFturaAdi;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button BtnBigileriKaydet;
    }
}