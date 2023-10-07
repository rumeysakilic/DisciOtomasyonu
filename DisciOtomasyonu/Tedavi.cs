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
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into Tedavi values ('" + TedaviAdiTb.Text + "','" + TutarTb.Text + "','" + AciklamaTb.Text + "')";
            Hastalar Hs = new Hastalar();

            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Tedavi başarıyla eklendi!");
                Uyeler();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedavi başarıyla eklenemedi!" + ex.Message, "Hata");
            }
        }
        int key = 0;

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Tedaviyi Seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Update Tedavi Set TAd ='" + TedaviAdiTb.Text + "', TUcret ='" + TutarTb.Text + "', TAciklama ='" + AciklamaTb.Text + "' where TId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi Başarıyla Güncellendi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek tedaviyi seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Delete from Tedavi where TId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi Başarıyla Silindi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void Uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "Select * from Tedavi";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void Temizle()
        {
            TedaviAdiTb.Text = "";
            TutarTb.Text = "";
            AciklamaTb.Text = "";
        }

        private void Tedavi_Load(object sender, EventArgs e)
        {
            Uyeler();
            Temizle();
        }

        private void TedaviDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TedaviAdiTb.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            TutarTb.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            AciklamaTb.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (TedaviAdiTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            void Filter()
            {
                Hastalar Hs = new Hastalar();
                string query = "Select * from Tedavi where TAd like '%" + AraTB.Text + "%'";
                DataSet ds = Hs.ShowHasta(query);
                TedaviDGV.DataSource = ds.Tables[0];
            }
        }
    }
}
