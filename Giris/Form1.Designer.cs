namespace Giris
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            btnGiris = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(200, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 20);
            textBox1.TabIndex = 3;
            textBox1.Text = "Kullanıcı Adı";
            textBox1.Click += textBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(270, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 33);
            panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(270, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 20);
            textBox2.TabIndex = 5;
            textBox2.Text = "Şifre";
            textBox2.Click += textBox2_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(270, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 20);
            panel2.TabIndex = 5;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.DeepSkyBlue;
            btnGiris.Location = new Point(200, 212);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(226, 29);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(200, 261);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(200, 296);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(182, 31);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            // 
            // button1
            // 
            button1.Location = new Point(506, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 32);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(548, 358);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(btnGiris);
            Controls.Add(textBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Panel panel2;
        private Button btnGiris;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}