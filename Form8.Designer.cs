namespace SirketProjem
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            btnCikF8 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBoxMusteriSoyadiSil = new TextBox();
            txtBoxMusteriAdiSil = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnSilF8 = new Button();
            BtnVazgecF8 = new Button();
            BtnGeriF8 = new Button();
            txtBoxFaturaSilF8 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCikF8
            // 
            btnCikF8.BackColor = SystemColors.ActiveCaption;
            btnCikF8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCikF8.Location = new Point(108, 411);
            btnCikF8.Name = "btnCikF8";
            btnCikF8.Size = new Size(75, 27);
            btnCikF8.TabIndex = 0;
            btnCikF8.Text = "Çık";
            btnCikF8.UseVisualStyleBackColor = false;
            btnCikF8.Click += btnGeriF8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 19);
            label1.TabIndex = 2;
            label1.Text = "Müşeteri Bilgilerini Silmek için kutuları doldurunuz ";
            // 
            // txtBoxMusteriSoyadiSil
            // 
            txtBoxMusteriSoyadiSil.Location = new Point(121, 119);
            txtBoxMusteriSoyadiSil.Name = "txtBoxMusteriSoyadiSil";
            txtBoxMusteriSoyadiSil.Size = new Size(150, 23);
            txtBoxMusteriSoyadiSil.TabIndex = 12;
            // 
            // txtBoxMusteriAdiSil
            // 
            txtBoxMusteriAdiSil.Location = new Point(121, 66);
            txtBoxMusteriAdiSil.Name = "txtBoxMusteriAdiSil";
            txtBoxMusteriAdiSil.Size = new Size(150, 23);
            txtBoxMusteriAdiSil.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label4.Location = new Point(23, 119);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 10;
            label4.Text = "Soyadı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 9;
            label2.Text = "Adı : ";
            // 
            // btnSilF8
            // 
            btnSilF8.BackColor = Color.LightCoral;
            btnSilF8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSilF8.Location = new Point(144, 262);
            btnSilF8.Name = "btnSilF8";
            btnSilF8.Size = new Size(92, 37);
            btnSilF8.TabIndex = 13;
            btnSilF8.Text = "Sil ";
            btnSilF8.UseVisualStyleBackColor = false;
            btnSilF8.Click += btnSilF8_Click;
            // 
            // BtnVazgecF8
            // 
            BtnVazgecF8.BackColor = Color.DarkSeaGreen;
            BtnVazgecF8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnVazgecF8.Location = new Point(23, 262);
            BtnVazgecF8.Name = "BtnVazgecF8";
            BtnVazgecF8.Size = new Size(92, 37);
            BtnVazgecF8.TabIndex = 14;
            BtnVazgecF8.Text = "Vazgeç";
            BtnVazgecF8.UseVisualStyleBackColor = false;
            BtnVazgecF8.Click += BtnVazgecF8_Click;
            // 
            // BtnGeriF8
            // 
            BtnGeriF8.BackColor = SystemColors.ActiveCaption;
            BtnGeriF8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BtnGeriF8.Location = new Point(17, 411);
            BtnGeriF8.Name = "BtnGeriF8";
            BtnGeriF8.Size = new Size(75, 27);
            BtnGeriF8.TabIndex = 15;
            BtnGeriF8.Text = "Geri";
            BtnGeriF8.UseVisualStyleBackColor = false;
            BtnGeriF8.Click += BtnGeriF8_Click_1;
            // 
            // txtBoxFaturaSilF8
            // 
            txtBoxFaturaSilF8.Location = new Point(121, 176);
            txtBoxFaturaSilF8.Name = "txtBoxFaturaSilF8";
            txtBoxFaturaSilF8.Size = new Size(150, 23);
            txtBoxFaturaSilF8.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label3.Location = new Point(18, 176);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 16;
            label3.Text = "Fatura Adı : ";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(871, 450);
            Controls.Add(txtBoxFaturaSilF8);
            Controls.Add(label3);
            Controls.Add(BtnGeriF8);
            Controls.Add(BtnVazgecF8);
            Controls.Add(btnSilF8);
            Controls.Add(txtBoxMusteriSoyadiSil);
            Controls.Add(txtBoxMusteriAdiSil);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCikF8);
            Name = "Form8";
            Text = "Müşteri Sil ";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCikF8;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBoxMusteriSoyadiSil;
        private TextBox txtBoxMusteriAdiSil;
        private Label label4;
        private Label label2;
        private Button btnSilF8;
        private Button BtnVazgecF8;
        private Button BtnGeriF8;
        private TextBox txtBoxFaturaSilF8;
        private Label label3;
    }
}