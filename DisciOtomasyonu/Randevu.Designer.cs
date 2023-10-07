namespace DisciOtomasyonu
{
    partial class Randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            RandevuDGV = new DataGridView();
            AraTB = new TextBox();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            RTarih = new DateTimePicker();
            panel1 = new Panel();
            RAdSoyadCB = new ComboBox();
            RSaatCB = new ComboBox();
            RTedaviCB = new ComboBox();
            lblGeri = new Label();
            ((System.ComponentModel.ISupportInitialize)RandevuDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RandevuDGV
            // 
            RandevuDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RandevuDGV.Location = new Point(510, 201);
            RandevuDGV.Name = "RandevuDGV";
            RandevuDGV.RowHeadersWidth = 51;
            RandevuDGV.RowTemplate.Height = 29;
            RandevuDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RandevuDGV.Size = new Size(642, 356);
            RandevuDGV.TabIndex = 43;
            RandevuDGV.CellClick += RandevuDGV_CellClick;
            // 
            // AraTB
            // 
            AraTB.BorderStyle = BorderStyle.FixedSingle;
            AraTB.Location = new Point(619, 138);
            AraTB.Name = "AraTB";
            AraTB.Size = new Size(414, 27);
            AraTB.TabIndex = 41;
            AraTB.TextChanged += textBox5_TextChanged;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuzenle.Location = new Point(255, 452);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(103, 29);
            btnDuzenle.TabIndex = 39;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(364, 452);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(103, 29);
            btnSil.TabIndex = 38;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(155, 452);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 37;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(112, 246);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 35;
            label9.Text = "Tedavi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(124, 370);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 33;
            label8.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(121, 307);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 29;
            label6.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 197);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 25;
            label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(319, 97);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 24;
            label4.Text = "Samsun Dental Klinik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1140, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 36);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 24);
            label1.Name = "label1";
            label1.Size = new Size(443, 36);
            label1.TabIndex = 0;
            label1.Text = "DİŞ KLİNİĞİ OTOMASYONU";
            // 
            // RTarih
            // 
            RTarih.Location = new Point(217, 305);
            RTarih.Name = "RTarih";
            RTarih.Size = new Size(250, 27);
            RTarih.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 84);
            panel1.TabIndex = 23;
            // 
            // RAdSoyadCB
            // 
            RAdSoyadCB.FormattingEnabled = true;
            RAdSoyadCB.Items.AddRange(new object[] { "Kadın", "Erkek" });
            RAdSoyadCB.Location = new Point(217, 197);
            RAdSoyadCB.Name = "RAdSoyadCB";
            RAdSoyadCB.Size = new Size(250, 28);
            RAdSoyadCB.TabIndex = 44;
            // 
            // RSaatCB
            // 
            RSaatCB.FormattingEnabled = true;
            RSaatCB.Items.AddRange(new object[] { "9.00-9.15", "9.30-10.00", "10.15-10.30", "10.45-11.00", "11.15-11.30", "11.45-12.00", "13.00-13.15", "13.30-13.45", "14.00-14.15", "14.30-14.45", "15.00-15.15", "15.30-15.45", "16.00-16.15" });
            RSaatCB.Location = new Point(217, 370);
            RSaatCB.Name = "RSaatCB";
            RSaatCB.Size = new Size(250, 28);
            RSaatCB.TabIndex = 45;
            // 
            // RTedaviCB
            // 
            RTedaviCB.FormattingEnabled = true;
            RTedaviCB.Items.AddRange(new object[] { "Dolgu", "Çekim", "Kanal Tedavi", "Diş Taşı Temizleme" });
            RTedaviCB.Location = new Point(217, 246);
            RTedaviCB.Name = "RTedaviCB";
            RTedaviCB.Size = new Size(250, 28);
            RTedaviCB.TabIndex = 46;
            // 
            // lblGeri
            // 
            lblGeri.AutoSize = true;
            lblGeri.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGeri.Location = new Point(0, 87);
            lblGeri.Name = "lblGeri";
            lblGeri.Size = new Size(62, 31);
            lblGeri.TabIndex = 65;
            lblGeri.Text = "<<<";
            lblGeri.Click += lblGeri_Click;
            // 
            // Randevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 574);
            Controls.Add(lblGeri);
            Controls.Add(RTedaviCB);
            Controls.Add(RSaatCB);
            Controls.Add(RAdSoyadCB);
            Controls.Add(RandevuDGV);
            Controls.Add(AraTB);
            Controls.Add(btnDuzenle);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(RTarih);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Randevu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu";
            Load += Randevu_Load;
            ((System.ComponentModel.ISupportInitialize)RandevuDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RandevuDGV;
        private TextBox AraTB;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnKaydet;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private DateTimePicker RTarih;
        private Panel panel1;
        private ComboBox RAdSoyadCB;
        private ComboBox RSaatCB;
        private ComboBox RTedaviCB;
        private Label lblGeri;
    }
}