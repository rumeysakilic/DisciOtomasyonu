using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisciOtomasyonu
{
    public partial class Receteler : Form
    {
        public Receteler()
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
            SqlCommand komut = new SqlCommand("Select * from Randevu where Hasta = '" + RAdSoyadCB.SelectedValue.ToString() + "'", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                RTedaviAdiTB.Text = dr["Tedavi"].ToString();
            }
            baglanti.Close();
        }
        private void FillPrice()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tedavi where TAd = '" + RTedaviAdiTB.Text + "'", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                RTutarTB.Text = dr["TUcret"].ToString();
            }
            baglanti.Close();
        }
        private void Receteler_Load(object sender, EventArgs e)
        {
            FillHasta();
            Uyeler();
            Temizle();
        }

        private void RAdSoyadCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillTedavi();
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

        private void RTutarTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTedaviAdiTB_TextChanged(object sender, EventArgs e)
        {
            FillPrice();
        }
        void Uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "Select * from Recete";
            DataSet ds = Hs.ShowHasta(query);
            ReceteDGV.DataSource = ds.Tables[0];
        }
        void Temizle()
        {
            RAdSoyadCB.SelectedItem = "";
            RTedaviAdiTB.Text = "";
            RIlaclarTB.Text = "";
            RTutarTB.Text = "";
            RMiktarTB.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string query = "insert into Recete values ('" + RAdSoyadCB.SelectedValue.ToString() + "','" + RTedaviAdiTB.Text + "','" + RTutarTB.Text + "','" + RIlaclarTB.Text + "','" + RMiktarTB.Text + "' )";
            Hastalar Hs = new Hastalar();

            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Reçete başarıyla eklendi!");
                Uyeler();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reçete başarıyla eklenemedi!" + ex.Message, "Hata");
            }
        }
        int key = 0;
        private void ReceteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RAdSoyadCB.Text = ReceteDGV.SelectedRows[0].Cells[1].Value.ToString();
            RTedaviAdiTB.Text = ReceteDGV.SelectedRows[0].Cells[2].Value.ToString();
            RTutarTB.Text = ReceteDGV.SelectedRows[0].Cells[3].Value.ToString();
            RIlaclarTB.Text = ReceteDGV.SelectedRows[0].Cells[4].Value.ToString();
            RMiktarTB.Text = ReceteDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (RTedaviAdiTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceteDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek reçeteyi seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Delete from Recete where RecId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Reçete Başarıyla Silindi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            void Filter()
            {
                Hastalar Hs = new Hastalar();
                string query = "Select * from Recete where HasAd like '%" + AraTB.Text + "%'";
                DataSet ds = Hs.ShowHasta(query);
                ReceteDGV.DataSource = ds.Tables[0];
            }
        }
        Bitmap bitmap;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int height = ReceteDGV.Height;
            ReceteDGV.Height = ReceteDGV.RowCount * ReceteDGV.RowTemplate.Height * 2;
            bitmap = new Bitmap(ReceteDGV.Width, ReceteDGV.Height);
            ReceteDGV.DrawToBitmap(bitmap, new Rectangle(0, 10, ReceteDGV.Width, ReceteDGV.Height));
            ReceteDGV.Height = height;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
