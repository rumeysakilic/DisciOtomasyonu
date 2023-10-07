using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DisciOtomasyonu
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();
        private void FillHasta()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select AdSoyad from Hasta", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AdSoyad", typeof(string));
            dt.Load(rdr);
            RAdSoyadCB.ValueMember = "AdSoyad";
            RAdSoyadCB.DataSource = dt;
            baglanti.Close();
        }

        private void FillTedavi()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TAd from Tedavi", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TAd", typeof(string));
            dt.Load(rdr);
            RTedaviCB.ValueMember = "TAd";
            RTedaviCB.DataSource = dt;
            baglanti.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "Select * from Randevu";
            DataSet ds = Hs.ShowHasta(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }

        void Temizle()
        {
            RAdSoyadCB.Text = "";
            RTedaviCB.Text = "";
            RTarih.Text = "";
            RSaatCB.Text = "";
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            FillHasta();
            FillTedavi();
            Uyeler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into Randevu values ('" + RAdSoyadCB.SelectedValue.ToString() + "','" + RTedaviCB.SelectedValue.ToString() + "','" + RTarih.Text + "','" + RSaatCB.Text + "')";
            Hastalar Hs = new Hastalar();

            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Randevu başarıyla eklendi!");
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
                MessageBox.Show("Güncellenecek Randevuyu Seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Update Randevu Set Hasta ='" + RAdSoyadCB.SelectedValue.ToString() + "', Tedavi ='" + RTedaviCB.SelectedValue.ToString() + "', RTarih ='" + RTarih.Text + "', RSaat= '" + RSaatCB.Text + "' where RId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Randevu Başarıyla Güncellendi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RandevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RAdSoyadCB.SelectedValue = RandevuDGV.SelectedRows[0].Cells[1].Value.ToString();
            RTedaviCB.SelectedValue = RandevuDGV.SelectedRows[0].Cells[2].Value.ToString();
            RTarih.Text = RandevuDGV.SelectedRows[0].Cells[3].Value.ToString();
            RSaatCB.Text = RandevuDGV.SelectedRows[0].Cells[4].Value.ToString();


            if (RAdSoyadCB.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(RandevuDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek randevuyu seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Delete from Randevu where RId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Randevu Başarıyla Silindi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                string query = "Select * from Randevu where AdSoyad like '%" + AraTB.Text + "%'";
                DataSet ds = Hs.ShowHasta(query);
                RandevuDGV.DataSource = ds.Tables[0];
            }
        }
    }
}

