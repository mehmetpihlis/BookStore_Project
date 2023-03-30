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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proje_Kitapcı
{
    public partial class PersonelBilgileriGüncellemePaneli : Form
    {
        public PersonelBilgileriGüncellemePaneli()
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

        private void ComeBackBox_Click(object sender, EventArgs e)
        {
            //Admin Menü Paneline Geri Dönme
            AdminMenuPaneli wd = new AdminMenuPaneli();
            wd.Show();
            this.Close();
        }

        Baglanti baglanti = new Baglanti(); //Veri Tabanı bağlantı nesnesi
        private void PersonelBilgileriGüncellemePaneli_Load(object sender, EventArgs e)
        {
            //Hali Hazırdaki Personel Bilgilerini Forma Yükleme
            SqlCommand yukleKomut = new SqlCommand("select USERNAME, PAROLA from TBL_PERSONEL", baglanti.bg);
            baglanti.bg.Open();
            SqlDataReader dr = yukleKomut.ExecuteReader();
            while (dr.Read())
            {
                txtUsername.Text = dr[0].ToString();
                txtPassword.Text = dr[1].ToString();
            }
            baglanti.bg.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Personel Bilgileri Güncelleme(username & password)
            SqlCommand komutGuncelle = new SqlCommand("update TBL_PERSONEL set USERNAME=@p1, PAROLA=@p2", baglanti.bg);
            baglanti.bg.Open();
            komutGuncelle.Parameters.AddWithValue("@p1", txtUsername.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtPassword.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.bg.Close();
            MessageBox.Show("Personel bilgileri güncellendi!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
