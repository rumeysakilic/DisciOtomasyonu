namespace DisciOtomasyonu
{
    partial class Hasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            HAdSoyadTb = new TextBox();
            label3 = new Label();
            HTelefonTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            HDogumTarihi = new DateTimePicker();
            label7 = new Label();
            HCinsiyetCb = new ComboBox();
            HAlerjiTb = new TextBox();
            label8 = new Label();
            HAdresTb = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            AraTB = new TextBox();
            HastaDGV = new DataGridView();
            btnTemizle = new Button();
            lblGeri = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HastaDGV).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1247, 84);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1206, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 36);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
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
            label1.Location = new Point(160, 24);
            label1.Name = "label1";
            label1.Size = new Size(443, 36);
            label1.TabIndex = 0;
            label1.Text = "DİŞ KLİNİĞİ OTOMASYONU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(224, 124);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 3;
            label4.Text = "Samsun Dental Klinik";
            // 
            // HAdSoyadTb
            // 
            HAdSoyadTb.BorderStyle = BorderStyle.FixedSingle;
            HAdSoyadTb.Location = new Point(224, 176);
            HAdSoyadTb.Name = "HAdSoyadTb";
            HAdSoyadTb.Size = new Size(250, 27);
            HAdSoyadTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 180);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 4;
            label3.Text = "Ad Soyad:";
            // 
            // HTelefonTb
            // 
            HTelefonTb.BorderStyle = BorderStyle.FixedSingle;
            HTelefonTb.Location = new Point(224, 229);
            HTelefonTb.Name = "HTelefonTb";
            HTelefonTb.Size = new Size(250, 27);
            HTelefonTb.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(105, 233);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 6;
            label5.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(49, 288);
            label6.Name = "label6";
            label6.Size = new Size(142, 23);
            label6.TabIndex = 8;
            label6.Text = "Doğum Tarihi:";
            // 
            // HDogumTarihi
            // 
            HDogumTarihi.Location = new Point(224, 288);
            HDogumTarihi.Name = "HDogumTarihi";
            HDogumTarihi.Size = new Size(250, 27);
            HDogumTarihi.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(97, 344);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 10;
            label7.Text = "Cinsiyet:";
            // 
            // HCinsiyetCb
            // 
            HCinsiyetCb.FormattingEnabled = true;
            HCinsiyetCb.Items.AddRange(new object[] { "Kadin", "Erkek" });
            HCinsiyetCb.Location = new Point(224, 344);
            HCinsiyetCb.Name = "HCinsiyetCb";
            HCinsiyetCb.Size = new Size(250, 28);
            HCinsiyetCb.TabIndex = 11;
            // 
            // HAlerjiTb
            // 
            HAlerjiTb.BorderStyle = BorderStyle.FixedSingle;
            HAlerjiTb.Location = new Point(224, 394);
            HAlerjiTb.Name = "HAlerjiTb";
            HAlerjiTb.Size = new Size(250, 27);
            HAlerjiTb.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(126, 398);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 12;
            label8.Text = "Alerji:";
            // 
            // HAdresTb
            // 
            HAdresTb.BorderStyle = BorderStyle.FixedSingle;
            HAdresTb.Location = new Point(224, 445);
            HAdresTb.Name = "HAdresTb";
            HAdresTb.Size = new Size(250, 27);
            HAdresTb.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(119, 449);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 14;
            label9.Text = "Adres:";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(49, 511);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(371, 511);
            button2.Name = "button2";
            button2.Size = new Size(103, 29);
            button2.TabIndex = 17;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(149, 511);
            button3.Name = "button3";
            button3.Size = new Size(103, 29);
            button3.TabIndex = 18;
            button3.Text = "Düzenle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AraTB
            // 
            AraTB.BorderStyle = BorderStyle.FixedSingle;
            AraTB.Location = new Point(599, 124);
            AraTB.Name = "AraTB";
            AraTB.Size = new Size(524, 27);
            AraTB.TabIndex = 20;
            AraTB.TextChanged += AraTB_TextChanged;
            // 
            // HastaDGV
            // 
            HastaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HastaDGV.Location = new Point(480, 176);
            HastaDGV.Name = "HastaDGV";
            HastaDGV.RowHeadersWidth = 51;
            HastaDGV.RowTemplate.Height = 29;
            HastaDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HastaDGV.Size = new Size(755, 356);
            HastaDGV.TabIndex = 22;
            HastaDGV.CellClick += HastaDGV_CellClick;
            HastaDGV.CellContentClick += HastaDGV_CellContentClick;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTemizle.Location = new Point(262, 511);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(103, 29);
            btnTemizle.TabIndex = 23;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblGeri
            // 
            lblGeri.AutoSize = true;
            lblGeri.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGeri.Location = new Point(0, 87);
            lblGeri.Name = "lblGeri";
            lblGeri.Size = new Size(62, 31);
            lblGeri.TabIndex = 24;
            lblGeri.Text = "<<<";
            lblGeri.Click += lblGeri_Click;
            // 
            // Hasta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 574);
            Controls.Add(lblGeri);
            Controls.Add(btnTemizle);
            Controls.Add(HastaDGV);
            Controls.Add(AraTB);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(HAdresTb);
            Controls.Add(label9);
            Controls.Add(HAlerjiTb);
            Controls.Add(label8);
            Controls.Add(HCinsiyetCb);
            Controls.Add(label7);
            Controls.Add(HDogumTarihi);
            Controls.Add(label6);
            Controls.Add(HTelefonTb);
            Controls.Add(label5);
            Controls.Add(HAdSoyadTb);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hasta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta";
            Load += Hasta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HastaDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private TextBox HAdSoyadTb;
        private Label label3;
        private TextBox HTelefonTb;
        private Label label5;
        private Label label6;
        private DateTimePicker HDogumTarihi;
        private Label label7;
        private ComboBox HCinsiyetCb;
        private TextBox HAlerjiTb;
        private Label label8;
        private TextBox HAdresTb;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox AraTB;
        private DataGridView HastaDGV;
        private Button btnTemizle;
        private Label lblGeri;
    }
}