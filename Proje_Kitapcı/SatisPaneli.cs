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

namespace Proje_Kitapcı
{
    public partial class SatisPaneli : Form
    {
        public SatisPaneli()
        {
            InitializeComponent();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden emin misiniz? Tekrar giriş yapmak zorunda kalacaksınız.", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public string Kullanici;
        private void ComeBackBox_Click(object sender, EventArgs e)
        {
            //Come Back -Ortak panel oldugu için kullanıcının admin mi yoksa personel mi olduguna karar verme ve buna
            //göre o kullanıcı tipinin menüsüne dönme
            if (Kullanici == "admin")
            {
                AdminMenuPaneli wd = new AdminMenuPaneli();
                wd.Show();
                this.Close();
            }
            if (Kullanici == "personel")
            {
                PersonelMenuPaneli wd2 = new PersonelMenuPaneli();
                wd2.Show();
                this.Close();
            }
        }

        Baglanti baglanti = new Baglanti(); //Veri Tabanı Bağlantısı

        private void SatisPaneli_Load(object sender, EventArgs e)
        {
            //Data Grid'e Veri Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBL_BOOKSTOCK", baglanti.bg);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //Kasadaki toplam parayı gösterme
            SqlCommand komutKasa = new SqlCommand("select TOPLAM from TBL_KASA", baglanti.bg);
            baglanti.bg.Open();
            SqlDataReader dr = komutKasa.ExecuteReader();
            while(dr.Read())
            {
                lblKasaToplam.Text = dr[0] + "TL";
            }
            baglanti.bg.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBL_BOOKSTOCK where AD='"+txtAd.Text.ToUpper()+"'", baglanti.bg);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public int toplam = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            listBoxKasa.Items.Add(dataGridView1.Rows[secilen].Cells[1].Value + " " 
                                + dataGridView1.Rows[secilen].Cells[2].Value + "sy. "
                                + dataGridView1.Rows[secilen].Cells[3].Value + " "
                                + dataGridView1.Rows[secilen].Cells[4].Value + "TL "
                                + dataGridView1.Rows[secilen].Cells[5].Value);

            toplam += Convert.ToInt32(dataGridView1.Rows[secilen].Cells[4].Value);
            lblToplam.Text = toplam + "TL";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //Satış için hazırlanan ürünlerin bulunduğu listBox'ı temizleme
            listBoxKasa.Items.Clear();
            //Ürünler silindiği için Toplam fiyatı sıfırlama
            toplam = 0;
            lblToplam.Text = "0TL";
        }

        //Satış işlemini gerçekleştirme
        private void btnSat_Click(object sender, EventArgs e)
        {
            //Satış için hazırlanan ürünler satıldığı için listBox'ı temizleme
            listBoxKasa.Items.Clear();

            //Kasaya para ekleme
            SqlCommand komutKasaHesap = new SqlCommand("update TBL_KASA set TOPLAM+=@p1", baglanti.bg);
            baglanti.bg.Open();
            komutKasaHesap.Parameters.AddWithValue("@p1", toplam);
            komutKasaHesap.ExecuteNonQuery();
            baglanti.bg.Close();
            MessageBox.Show("Satış işlemi gerçekleştirildi", "BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Kasa Label'ına değişikliği gösterme
            SqlCommand komutKasaGoster = new SqlCommand("select TOPLAM from TBL_KASA", baglanti.bg);
            baglanti.bg.Open();
            SqlDataReader dr = komutKasaGoster.ExecuteReader();
            while (dr.Read())
            {
                lblKasaToplam.Text = dr[0] + "TL";
            }
            baglanti.bg.Close();

            //Toplamı sıfırlama
            toplam = 0;
            lblToplam.Text = toplam + "TL";
        }
    }
}
