using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisciOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            Receteler rct = new Receteler();
            rct.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Show();
            this.Hide();
        }

        private void btnTedavi_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }
    }
}
