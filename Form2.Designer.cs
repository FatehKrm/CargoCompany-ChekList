namespace SirketProjem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxKullaniciAdi = new TextBox();
            txtBoxSifre = new TextBox();
            pictureBox1 = new PictureBox();
            BtnGiris2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(540, 25);
            label1.TabIndex = 0;
            label1.Text = "Giriş yapmak için Lütfen kullanıcı adınız ve şifrenizi giriniz ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(97, 91);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(155, 146);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 3;
            label4.Text = "Şifre : ";
            label4.Click += label4_Click;
            // 
            // txtBoxKullaniciAdi
            // 
            txtBoxKullaniciAdi.Location = new Point(244, 91);
            txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            txtBoxKullaniciAdi.Size = new Size(170, 23);
            txtBoxKullaniciAdi.TabIndex = 4;
            // 
            // txtBoxSifre
            // 
            txtBoxSifre.Location = new Point(244, 144);
            txtBoxSifre.Name = "txtBoxSifre";
            txtBoxSifre.Size = new Size(170, 23);
            txtBoxSifre.TabIndex = 5;
            txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // BtnGiris2
            // 
            BtnGiris2.BackColor = SystemColors.ActiveCaption;
            BtnGiris2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGiris2.Location = new Point(201, 244);
            BtnGiris2.Name = "BtnGiris2";
            BtnGiris2.Size = new Size(85, 32);
            BtnGiris2.TabIndex = 7;
            BtnGiris2.Text = "Giriş ";
            BtnGiris2.UseVisualStyleBackColor = false;
            BtnGiris2.Click += BtnGiris2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 344);
            Controls.Add(BtnGiris2);
            Controls.Add(txtBoxSifre);
            Controls.Add(txtBoxKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtBoxKullaniciAdi;
        private TextBox txtBoxSifre;
        private PictureBox pictureBox1;
        private Button BtnGiris2;
    }
}