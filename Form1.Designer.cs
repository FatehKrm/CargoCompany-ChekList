namespace SirketProjem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnGiris1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(125, 50);
            label1.TabIndex = 0;
            label1.Text = "Travel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold);
            label2.Location = new Point(38, 59);
            label2.Name = "label2";
            label2.Size = new Size(229, 47);
            label2.TabIndex = 1;
            label2.Text = "Traffic Kargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.YellowGreen;
            label3.Location = new Point(54, 166);
            label3.Name = "label3";
            label3.Size = new Size(135, 27);
            label3.TabIndex = 2;
            label3.Text = "Hoşgeldiniz ";
            // 
            // BtnGiris1
            // 
            BtnGiris1.BackColor = SystemColors.ActiveCaption;
            BtnGiris1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGiris1.Location = new Point(68, 276);
            BtnGiris1.Name = "BtnGiris1";
            BtnGiris1.Size = new Size(107, 31);
            BtnGiris1.TabIndex = 3;
            BtnGiris1.Text = "Giriş Yap";
            BtnGiris1.UseVisualStyleBackColor = false;
            BtnGiris1.Click += BtnGiris1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 272);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 374);
            Controls.Add(pictureBox1);
            Controls.Add(BtnGiris1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnGiris1;
        private PictureBox pictureBox1;
    }
}
