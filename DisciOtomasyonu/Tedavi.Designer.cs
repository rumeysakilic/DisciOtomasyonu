namespace DisciOtomasyonu
{
    partial class Tedavi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedavi));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TedaviDGV = new DataGridView();
            AraTB = new TextBox();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            TedaviAdiTb = new TextBox();
            TutarTb = new TextBox();
            AciklamaTb = new TextBox();
            lblGeri = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TedaviDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(975, 0);
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
            // TedaviDGV
            // 
            TedaviDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TedaviDGV.Location = new Point(510, 210);
            TedaviDGV.Name = "TedaviDGV";
            TedaviDGV.RowHeadersWidth = 51;
            TedaviDGV.RowTemplate.Height = 29;
            TedaviDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TedaviDGV.Size = new Size(477, 356);
            TedaviDGV.TabIndex = 60;
            TedaviDGV.CellClick += TedaviDGV_CellClick;
            // 
            // AraTB
            // 
            AraTB.BorderStyle = BorderStyle.FixedSingle;
            AraTB.Location = new Point(600, 151);
            AraTB.Name = "AraTB";
            AraTB.Size = new Size(250, 27);
            AraTB.TabIndex = 58;
            AraTB.TextChanged += textBox5_TextChanged;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuzenle.Location = new Point(197, 364);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(103, 29);
            btnDuzenle.TabIndex = 56;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(306, 364);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(103, 29);
            btnSil.TabIndex = 55;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(97, 364);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 54;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(80, 279);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 52;
            label8.Text = "Açıklama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(130, 216);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 50;
            label6.Text = "Tutar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 155);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 49;
            label3.Text = "Tedavi Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(354, 100);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 48;
            label4.Text = "Samsun Dental Klinik";
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
            panel1.Size = new Size(1016, 84);
            panel1.TabIndex = 47;
            // 
            // TedaviAdiTb
            // 
            TedaviAdiTb.Location = new Point(197, 151);
            TedaviAdiTb.Name = "TedaviAdiTb";
            TedaviAdiTb.Size = new Size(231, 27);
            TedaviAdiTb.TabIndex = 61;
            // 
            // TutarTb
            // 
            TutarTb.Location = new Point(197, 212);
            TutarTb.Name = "TutarTb";
            TutarTb.Size = new Size(231, 27);
            TutarTb.TabIndex = 62;
            // 
            // AciklamaTb
            // 
            AciklamaTb.Location = new Point(197, 279);
            AciklamaTb.Name = "AciklamaTb";
            AciklamaTb.Size = new Size(231, 27);
            AciklamaTb.TabIndex = 63;
            // 
            // lblGeri
            // 
            lblGeri.AutoSize = true;
            lblGeri.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGeri.Location = new Point(0, 87);
            lblGeri.Name = "lblGeri";
            lblGeri.Size = new Size(62, 31);
            lblGeri.TabIndex = 64;
            lblGeri.Text = "<<<";
            lblGeri.Click += lblGeri_Click;
            // 
            // Tedavi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 574);
            Controls.Add(lblGeri);
            Controls.Add(AciklamaTb);
            Controls.Add(TutarTb);
            Controls.Add(TedaviAdiTb);
            Controls.Add(TedaviDGV);
            Controls.Add(AraTB);
            Controls.Add(btnDuzenle);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tedavi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tedavi";
            Load += Tedavi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TedaviDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView TedaviDGV;
        private TextBox AraTB;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnKaydet;
        private Label label8;
        private Label label6;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox TedaviAdiTb;
        private TextBox TutarTb;
        private TextBox AciklamaTb;
        private Label lblGeri;
    }
}