namespace YoungFit.PL
{
    partial class UyeOlmadanDevamEtForm
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
            label1 = new Label();
            nudVucutAgirligi = new NumericUpDown();
            label2 = new Label();
            txtBoyCm = new TextBox();
            label3 = new Label();
            btnBKIHesapla = new Button();
            btnUyeOlIptal = new Button();
            label4 = new Label();
            lblBKI = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudVucutAgirligi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(54, 106);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 0;
            label1.Text = "Vücut Ağırlığı (KG) :";
            // 
            // nudVucutAgirligi
            // 
            nudVucutAgirligi.Location = new Point(265, 104);
            nudVucutAgirligi.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudVucutAgirligi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudVucutAgirligi.Name = "nudVucutAgirligi";
            nudVucutAgirligi.Size = new Size(120, 34);
            nudVucutAgirligi.TabIndex = 1;
            nudVucutAgirligi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 156);
            label2.Name = "label2";
            label2.Size = new Size(233, 28);
            label2.TabIndex = 0;
            label2.Text = "Boyunuzu Giriniz (cm) :";
            // 
            // txtBoyCm
            // 
            txtBoyCm.Location = new Point(252, 156);
            txtBoyCm.Name = "txtBoyCm";
            txtBoyCm.Size = new Size(133, 34);
            txtBoyCm.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(252, 22);
            label3.Name = "label3";
            label3.Size = new Size(229, 32);
            label3.TabIndex = 3;
            label3.Text = "Beden Kitle İndeksi";
            // 
            // btnBKIHesapla
            // 
            btnBKIHesapla.BackColor = Color.Beige;
            btnBKIHesapla.FlatStyle = FlatStyle.Popup;
            btnBKIHesapla.Location = new Point(20, 206);
            btnBKIHesapla.Name = "btnBKIHesapla";
            btnBKIHesapla.Size = new Size(365, 38);
            btnBKIHesapla.TabIndex = 4;
            btnBKIHesapla.Text = "BKİ Hesapla";
            btnBKIHesapla.UseVisualStyleBackColor = false;
            btnBKIHesapla.Click += btnBKIHesapla_Click;
            // 
            // btnUyeOlIptal
            // 
            btnUyeOlIptal.BackColor = Color.Beige;
            btnUyeOlIptal.FlatStyle = FlatStyle.Popup;
            btnUyeOlIptal.Location = new Point(409, 374);
            btnUyeOlIptal.Name = "btnUyeOlIptal";
            btnUyeOlIptal.Size = new Size(102, 41);
            btnUyeOlIptal.TabIndex = 4;
            btnUyeOlIptal.Text = "İptal";
            btnUyeOlIptal.UseVisualStyleBackColor = false;
            btnUyeOlIptal.Click += btnUyeOlIptal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(20, 265);
            label4.Name = "label4";
            label4.Size = new Size(231, 28);
            label4.TabIndex = 0;
            label4.Text = "Beden kitle indeksiniz :";
            // 
            // lblBKI
            // 
            lblBKI.AutoSize = true;
            lblBKI.Location = new Point(295, 265);
            lblBKI.Name = "lblBKI";
            lblBKI.Size = new Size(0, 28);
            lblBKI.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label5.Location = new Point(54, 54);
            label5.Name = "label5";
            label5.Size = new Size(560, 23);
            label5.TabIndex = 6;
            label5.Text = "Bu bölümde girdiğiniz bilgilere göre Beden Kitle İndeksiniz hesaplanacaktır .";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(528, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // UyeOlmadanDevamEtForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nature__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 427);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lblBKI);
            Controls.Add(btnUyeOlIptal);
            Controls.Add(btnBKIHesapla);
            Controls.Add(label3);
            Controls.Add(txtBoyCm);
            Controls.Add(nudVucutAgirligi);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "UyeOlmadanDevamEtForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeOlmadanDevamEtForm";
            ((System.ComponentModel.ISupportInitialize)nudVucutAgirligi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudVucutAgirligi;
        private Label label2;
        private TextBox txtBoyCm;
        private Label label3;
        private Button btnBKIHesapla;
        private Button btnUyeOlIptal;
        private Label label4;
		private Label lblBKI;
        private Label label5;
        private PictureBox pictureBox1;
    }
}