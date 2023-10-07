namespace DisciOtomasyonu
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            panel1 = new Panel();
            btnRecete = new Button();
            btnTedavi = new Button();
            button2 = new Button();
            btnHasta = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(btnRecete);
            panel1.Controls.Add(btnTedavi);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnHasta);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 109);
            panel1.TabIndex = 0;
            // 
            // btnRecete
            // 
            btnRecete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecete.Location = new Point(696, 45);
            btnRecete.Name = "btnRecete";
            btnRecete.Size = new Size(111, 34);
            btnRecete.TabIndex = 2;
            btnRecete.Text = "Reçeteler";
            btnRecete.UseVisualStyleBackColor = true;
            btnRecete.Click += btnRecete_Click;
            // 
            // btnTedavi
            // 
            btnTedavi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTedavi.Location = new Point(569, 45);
            btnTedavi.Name = "btnTedavi";
            btnTedavi.Size = new Size(111, 34);
            btnTedavi.TabIndex = 4;
            btnTedavi.Text = "Tedavi";
            btnTedavi.UseVisualStyleBackColor = true;
            btnTedavi.Click += btnTedavi_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(440, 45);
            button2.Name = "button2";
            button2.Size = new Size(111, 34);
            button2.TabIndex = 3;
            button2.Text = "Randevu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHasta
            // 
            btnHasta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHasta.Location = new Point(314, 45);
            btnHasta.Name = "btnHasta";
            btnHasta.Size = new Size(111, 34);
            btnHasta.TabIndex = 1;
            btnHasta.Text = "Hasta";
            btnHasta.UseVisualStyleBackColor = true;
            btnHasta.Click += btnHasta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(418, 129);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 3;
            label4.Text = "Samsun Dental Klinik";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(992, 414);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 581);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnRecete;
        private Button btnTedavi;
        private Button button2;
        private Button btnHasta;
        private Label label4;
        private PictureBox pictureBox2;
    }
}