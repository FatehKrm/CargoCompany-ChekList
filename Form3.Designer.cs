namespace SirketProjem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnMusteriEkle = new Button();
            BtnMusteriBilgi = new Button();
            BtnMalList = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            BtnTarihce = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-1, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 0;
            label1.Text = "Travel Traffic Kargo Menü ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 1;
            label2.Text = " + Müşteri Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(180, 19);
            label3.TabIndex = 2;
            label3.Text = "Müşteri Listesi /Bilgiler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 262);
            label4.Name = "label4";
            label4.Size = new Size(158, 19);
            label4.TabIndex = 3;
            label4.Text = "Getirilen Mal Listesi ";
            // 
            // BtnMusteriEkle
            // 
            BtnMusteriEkle.BackColor = SystemColors.ActiveCaption;
            BtnMusteriEkle.Location = new Point(215, 112);
            BtnMusteriEkle.Name = "BtnMusteriEkle";
            BtnMusteriEkle.Size = new Size(101, 30);
            BtnMusteriEkle.TabIndex = 4;
            BtnMusteriEkle.Text = "Ekle";
            BtnMusteriEkle.UseVisualStyleBackColor = false;
            BtnMusteriEkle.Click += BtnMusteriEkle_Click;
            // 
            // BtnMusteriBilgi
            // 
            BtnMusteriBilgi.BackColor = SystemColors.ActiveCaption;
            BtnMusteriBilgi.Location = new Point(215, 184);
            BtnMusteriBilgi.Name = "BtnMusteriBilgi";
            BtnMusteriBilgi.Size = new Size(101, 30);
            BtnMusteriBilgi.TabIndex = 5;
            BtnMusteriBilgi.Text = "Göster";
            BtnMusteriBilgi.UseVisualStyleBackColor = false;
            BtnMusteriBilgi.Click += BtnMusteriBilgi_Click;
            // 
            // BtnMalList
            // 
            BtnMalList.BackColor = SystemColors.ActiveCaption;
            BtnMalList.Location = new Point(215, 262);
            BtnMalList.Name = "BtnMalList";
            BtnMalList.Size = new Size(101, 30);
            BtnMalList.TabIndex = 6;
            BtnMalList.Text = "Oluştur";
            BtnMalList.UseVisualStyleBackColor = false;
            BtnMalList.Click += BtnMalList_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            label6.Location = new Point(12, 342);
            label6.Name = "label6";
            label6.Size = new Size(142, 19);
            label6.TabIndex = 10;
            label6.Text = "Müşteri Tarihçesi  ";
            // 
            // BtnTarihce
            // 
            BtnTarihce.BackColor = SystemColors.ActiveCaption;
            BtnTarihce.Location = new Point(215, 338);
            BtnTarihce.Name = "BtnTarihce";
            BtnTarihce.Size = new Size(101, 30);
            BtnTarihce.TabIndex = 11;
            BtnTarihce.Text = "Görüntüle ";
            BtnTarihce.UseVisualStyleBackColor = false;
            BtnTarihce.Click += BtnTarihce_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(904, 428);
            Controls.Add(BtnTarihce);
            Controls.Add(label6);
            Controls.Add(BtnMalList);
            Controls.Add(BtnMusteriBilgi);
            Controls.Add(BtnMusteriEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Menü";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnMusteriEkle;
        private Button BtnMusteriBilgi;
        private Button BtnMalList;
        private PictureBox pictureBox1;
        private Label label6;
        private Button BtnTarihce;
    }
}