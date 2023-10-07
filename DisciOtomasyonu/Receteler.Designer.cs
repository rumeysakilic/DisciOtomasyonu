namespace DisciOtomasyonu
{
    partial class Receteler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receteler));
            RTutarTB = new TextBox();
            RTedaviAdiTB = new TextBox();
            ReceteDGV = new DataGridView();
            AraTB = new TextBox();
            btnSil = new Button();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            RMiktarTB = new TextBox();
            label5 = new Label();
            btnYazdir = new Button();
            button6 = new Button();
            RAdSoyadCB = new ComboBox();
            lblGeri = new Label();
            RIlaclarTB = new TextBox();
            label7 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)ReceteDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RTutarTB
            // 
            RTutarTB.Location = new Point(206, 302);
            RTutarTB.Name = "RTutarTB";
            RTutarTB.Size = new Size(250, 27);
            RTutarTB.TabIndex = 78;
            RTutarTB.TextChanged += RTutarTB_TextChanged;
            // 
            // RTedaviAdiTB
            // 
            RTedaviAdiTB.Location = new Point(206, 190);
            RTedaviAdiTB.Name = "RTedaviAdiTB";
            RTedaviAdiTB.Size = new Size(250, 27);
            RTedaviAdiTB.TabIndex = 77;
            RTedaviAdiTB.TextChanged += RTedaviAdiTB_TextChanged;
            // 
            // ReceteDGV
            // 
            ReceteDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceteDGV.Location = new Point(510, 190);
            ReceteDGV.Name = "ReceteDGV";
            ReceteDGV.RowHeadersWidth = 51;
            ReceteDGV.RowTemplate.Height = 29;
            ReceteDGV.Size = new Size(516, 356);
            ReceteDGV.TabIndex = 75;
            ReceteDGV.CellClick += ReceteDGV_CellClick;
            // 
            // AraTB
            // 
            AraTB.BorderStyle = BorderStyle.FixedSingle;
            AraTB.Location = new Point(602, 134);
            AraTB.Name = "AraTB";
            AraTB.Size = new Size(281, 27);
            AraTB.TabIndex = 73;
            AraTB.TextChanged += textBox5_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(346, 439);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 29);
            btnSil.TabIndex = 70;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(109, 301);
            label8.Name = "label8";
            label8.Size = new Size(61, 23);
            label8.TabIndex = 68;
            label8.Text = "Tutar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(52, 190);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 67;
            label6.Text = "Tedavi Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 134);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 66;
            label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(359, 96);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 65;
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
            panel1.Size = new Size(1038, 84);
            panel1.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(997, 0);
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
            // RMiktarTB
            // 
            RMiktarTB.Location = new Point(206, 361);
            RMiktarTB.Name = "RMiktarTB";
            RMiktarTB.Size = new Size(250, 27);
            RMiktarTB.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(109, 360);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 79;
            label5.Text = "Miktar:";
            // 
            // btnYazdir
            // 
            btnYazdir.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYazdir.Location = new Point(739, 565);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(94, 29);
            btnYazdir.TabIndex = 81;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(231, 439);
            button6.Name = "button6";
            button6.Size = new Size(109, 29);
            button6.TabIndex = 82;
            button6.Text = "Kaydet";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // RAdSoyadCB
            // 
            RAdSoyadCB.FormattingEnabled = true;
            RAdSoyadCB.Items.AddRange(new object[] { "Kadin", "Erkek" });
            RAdSoyadCB.Location = new Point(206, 134);
            RAdSoyadCB.Name = "RAdSoyadCB";
            RAdSoyadCB.Size = new Size(250, 28);
            RAdSoyadCB.TabIndex = 83;
            RAdSoyadCB.SelectionChangeCommitted += RAdSoyadCB_SelectionChangeCommitted;
            // 
            // lblGeri
            // 
            lblGeri.AutoSize = true;
            lblGeri.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGeri.Location = new Point(0, 88);
            lblGeri.Name = "lblGeri";
            lblGeri.Size = new Size(62, 31);
            lblGeri.TabIndex = 84;
            lblGeri.Text = "<<<";
            lblGeri.Click += lblGeri_Click;
            // 
            // RIlaclarTB
            // 
            RIlaclarTB.Location = new Point(206, 248);
            RIlaclarTB.Name = "RIlaclarTB";
            RIlaclarTB.Size = new Size(250, 27);
            RIlaclarTB.TabIndex = 86;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(109, 247);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 85;
            label7.Text = "İlaçlar:";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Receteler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 606);
            Controls.Add(RIlaclarTB);
            Controls.Add(label7);
            Controls.Add(lblGeri);
            Controls.Add(RAdSoyadCB);
            Controls.Add(button6);
            Controls.Add(RMiktarTB);
            Controls.Add(label5);
            Controls.Add(RTutarTB);
            Controls.Add(RTedaviAdiTB);
            Controls.Add(ReceteDGV);
            Controls.Add(AraTB);
            Controls.Add(btnSil);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnYazdir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receteler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receteler";
            Load += Receteler_Load;
            ((System.ComponentModel.ISupportInitialize)ReceteDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RTutarTB;
        private TextBox RTedaviAdiTB;
        private DataGridView ReceteDGV;
        private TextBox AraTB;
        private Button btnSil;
        private Label label8;
        private Label label6;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox RMiktarTB;
        private Label label5;
        private Button btnYazdir;
        private Button button6;
        private ComboBox RAdSoyadCB;
        private Label lblGeri;
        private TextBox RIlaclarTB;
        private Label label7;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}