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
    public partial class IstatistikPaneli : Form
    {
        public IstatistikPaneli()
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

        public string Kullanici; //Kullaniciya göre ortak form geçişi için
        private void ComeBackBox_Click(object sender, EventArgs e)
        {
            //Come Back -Ortak panel oldugu için kullanıcının admin mi yoksa personel mi olduguna karar verme ve buna
            //göre o kullanıcı tipinin menüsüne dönme
            if(Kullanici == "admin")
            {
                AdminMenuPaneli wd = new AdminMenuPaneli();
                wd.Show();
                this.Close();
            }
            if(Kullanici == "personel")
            {
                PersonelMenuPaneli wd2 = new PersonelMenuPaneli();
                wd2.Show();
                this.Close();
            }
        }

        Baglanti baglanti = new Baglanti();

        private void IstatistikPaneli_Load(object sender, EventArgs e)
        {
            //Toplam Kitap Sayısı
            SqlCommand komutKitapSay = new SqlCommand("select count(*) from TBL_BOOKSTOCK",baglanti.bg);
            baglanti.bg.Open();
            SqlDataReader dr1 = komutKitapSay.ExecuteReader();
            while (dr1.Read())
            {
                lblKitapSayisi.Text = dr1[0].ToString();
            }
            baglanti.bg.Close();

            //Envanterdeki Kitapların Toplam Fiyatı
            SqlCommand komutToplamFiyat = new SqlCommand("select sum(FIYAT) from TBL_BOOKSTOCK", baglanti.bg);
            baglanti.bg.Open();
            SqlDataReader dr2 = komutToplamFiyat.ExecuteReader();
            while(dr2.Read())
            {
                lblEnvanterFiyat.Text = dr2[0] + "TL";
            }
            baglanti.bg.Close();

            //En Pahalı Kitap
            SqlCommand komutEnPahali = new SqlCommand("select AD, max(FIYAT) from TBL_BOOKSTOCK group by AD order by max(FIYAT) asc", baglanti.bg);
            baglanti.bg.Open();
            SqlDataReader dr3 = komutEnPahali.ExecuteReader();
            while (dr3.Read())
            {
                lblEnPahali.Text = dr3[0].ToString();
            }
            baglanti.bg.Close();
        }
    }
}
