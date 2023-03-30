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
    public partial class AdminEnvanterPaneli : Form
    {
        public AdminEnvanterPaneli()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti(); //Veri Tabanı baglanti nesnesi

        public void Listele() //Data gride veri çekme fonksiyonu
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBL_BOOKSTOCK",baglanti.bg);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
        private void AdminEnvanterPaneli_Load(object sender, EventArgs e)
        {
            //Envanteri Veri Tabanından Çekme
            Listele();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden emin misiniz? Tekrar giriş yapmak zorunda kalacaksınız.", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ComeBackBox_Click(object sender, EventArgs e)
        {
            //Admin Menü Paneline Geri Dönme
            AdminMenuPaneli wd = new AdminMenuPaneli();
            wd.Show();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //Buton ile listeleme -Değişiklikleri görüntüleme
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Envantere Kitap Ekleme
            SqlCommand komutEkle = new SqlCommand("insert into TBL_BOOKSTOCK (AD,SAYFA,YAYINEVI,FIYAT,YAZAR) values (@p1,@p2,@p3,@p4,@p5)",baglanti.bg);
            baglanti.bg.Open();
            komutEkle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
            komutEkle.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSayfa.Text));
            komutEkle.Parameters.AddWithValue("@p3", txtYayinevi.Text.ToUpper());
            komutEkle.Parameters.AddWithValue("@p4", Convert.ToInt32(txtFiyat.Text));
            komutEkle.Parameters.AddWithValue("@p5", txtYazar.Text.ToUpper());
            komutEkle.ExecuteNonQuery();
            baglanti.bg.Close();
            MessageBox.Show("Envantere yeni kitap eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Değişiklikleri anında yansıtmak için:
            Listele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Data grid üzerinde çift tıklanan satırdaki verileri aktarma
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtYayinevi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Envanterdeki kitapları silme -Data gride çift tıkladıktan sonra Ürün Bilgileri kısmına bakarak
            // ID eşleştirmesi ile silme
            SqlCommand komutSil = new SqlCommand("delete from TBL_BOOKSTOCK where ID=@t1",baglanti.bg);
            baglanti.bg.Open();
            komutSil.Parameters.AddWithValue("@t1",txtID.Text);
            komutSil.ExecuteNonQuery();
            baglanti.bg.Close();
            MessageBox.Show("Seçilen kitap envanterden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Değişiklikleri anında yansıtmak için:
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Seçilen kitap bilgilerini güncelleme -Data gride çift tıkladıktan sonra Ürün Bilgileri kısmına bakarak
            // ID eşleştirmesi ile güncelleme
            SqlCommand komutGuncelle = new SqlCommand("update TBL_BOOKSTOCK set AD=@p1, SAYFA=@p2, YAYINEVI=@p3, FIYAT=@p4, YAZAR=@p5 where ID=@p7",baglanti.bg);
            baglanti.bg.Open();
            komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
            komutGuncelle.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSayfa.Text));
            komutGuncelle.Parameters.AddWithValue("@p3", txtYayinevi.Text.ToUpper());
            komutGuncelle.Parameters.AddWithValue("@p4", Convert.ToInt32(txtFiyat.Text));
            komutGuncelle.Parameters.AddWithValue("@p5", txtYazar.Text.ToUpper());
            komutGuncelle.Parameters.AddWithValue("@p7", Convert.ToInt32(txtID.Text));
            komutGuncelle.ExecuteNonQuery();
            baglanti.bg.Close();
            MessageBox.Show("Seçilen kitabın bilgileri güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Değişiklikleri anında yansıtmak için:
            Listele();
        }
    }
}
