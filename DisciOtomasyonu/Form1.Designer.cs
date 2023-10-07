namespace DisciOtomasyonu
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 84);
            panel1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 181);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(169, 234);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(242, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(242, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(301, 297);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(238, 107);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 2;
            label4.Text = "Samsun Dental Klinik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 396);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
    }
}