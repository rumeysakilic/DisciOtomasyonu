namespace Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }
        int hak = 3;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo� ge�ilemez", "Uyar�", MessageBoxButtons.OK);
            }
            else
            {
                if (textBox1.Text == "Rumeysa" && textBox2.Text == "1234" || textBox1.Text == "Cansu" && textBox2.Text == "4567")
                {
                    MessageBox.Show("Giri� ba�ar�l�!!");
                }
                else
                {
                    hak--;
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�. Kalan hakk�n�z: " + hak, "Uyar�2", MessageBoxButtons.OK);
                    
                    if (hak == 0)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}