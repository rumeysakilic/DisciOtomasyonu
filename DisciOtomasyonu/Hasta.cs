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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Hasta values ('" + HAdSoyadTb.Text + "','" + HTelefonTb.Text + "','" + HDogumTarihi.Text + "','" + HCinsiyetCb.SelectedItem.ToString() + "','" + HAlerjiTb.Text + "','" + HAdresTb.Text + "')";
            Hastalar Hs = new Hastalar();

            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta başarıyla eklendi!");
                Uyeler();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta başarıyla eklenemedi!" + ex.Message, "Hata");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void Uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "Select * from Hasta";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void Filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "Select * from Hasta where AdSoyad like '%" + AraTB.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void Temizle()
        {
            HAdSoyadTb.Text = "";
            HTelefonTb.Text = "";
            HDogumTarihi.Text = "";
            HCinsiyetCb.Text = "";
            HAlerjiTb.Text = "";
            HAdresTb.Text = "";
        }
        private void Hasta_Load(object sender, EventArgs e)
        {
            Uyeler();
        }

        int key = 0;
        private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HTelefonTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            HDogumTarihi.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            HCinsiyetCb.SelectedItem = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            HAlerjiTb.Text = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            HAdresTb.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (HAdSoyadTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek hastayı seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Delete from Hasta where HId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Silindi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Hastayı Seçiniz!");
            }
            else
            {
                try
                {
                    string query = "Update Hasta Set AdSoyad ='" + HAdSoyadTb.Text + "', Telefon ='" + HTelefonTb.Text + "', DoğumTarihi ='" + HDogumTarihi.Text + "', Cinsiyet ='" + HCinsiyetCb.SelectedItem.ToString() + "'," +
                        " Alerji ='" + HAlerjiTb.Text + "', Adres ='" + HAdresTb.Text + "' where HId = " + key + " ";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi!");
                    Uyeler();
                    Temizle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ans = new AnaSayfa();
            ans.Show();
            this.Hide();
        }

        private void AraTB_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
