namespace SirketProjem
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            dataGridView1 = new DataGridView();
            BtnGeriF11 = new Button();
            txtBoxFiltrele = new TextBox();
            label2 = new Label();
            BtnAraF11 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 336);
            dataGridView1.TabIndex = 0;
            // 
            // BtnGeriF11
            // 
            BtnGeriF11.BackColor = SystemColors.ActiveCaption;
            BtnGeriF11.Location = new Point(12, 415);
            BtnGeriF11.Name = "BtnGeriF11";
            BtnGeriF11.Size = new Size(75, 29);
            BtnGeriF11.TabIndex = 1;
            BtnGeriF11.Text = "Geri";
            BtnGeriF11.UseVisualStyleBackColor = false;
            BtnGeriF11.Click += BtnGeriF11_Click;
            // 
            // txtBoxFiltrele
            // 
            txtBoxFiltrele.Location = new Point(12, 33);
            txtBoxFiltrele.Name = "txtBoxFiltrele";
            txtBoxFiltrele.Size = new Size(170, 23);
            txtBoxFiltrele.TabIndex = 2;
            txtBoxFiltrele.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 4;
            label2.Text = "Filtrele ";
            // 
            // BtnAraF11
            // 
            BtnAraF11.Image = (Image)resources.GetObject("BtnAraF11.Image");
            BtnAraF11.Location = new Point(188, 30);
            BtnAraF11.Name = "BtnAraF11";
            BtnAraF11.Size = new Size(43, 28);
            BtnAraF11.TabIndex = 6;
            BtnAraF11.Text = "Ara";
            BtnAraF11.UseVisualStyleBackColor = true;
            BtnAraF11.Click += BtnAraF11_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 456);
            Controls.Add(BtnAraF11);
            Controls.Add(label2);
            Controls.Add(txtBoxFiltrele);
            Controls.Add(BtnGeriF11);
            Controls.Add(dataGridView1);
            Name = "Form11";
            Text = "Filtreleme";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnGeriF11;
        private TextBox txtBoxFiltrele;
        private Label label2;
        private Button BtnAraF11;
    }
}