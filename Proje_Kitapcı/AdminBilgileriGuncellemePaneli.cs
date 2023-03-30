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
    public partial class AdminBilgileriGuncellemePaneli : Form
    {
        public AdminBilgileriGuncellemePaneli()
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

        Baglanti baglanti = new Baglanti(); //Veri Tabanı Bağlantı Nesnesi
        private void AdminBilgileriGuncellemePaneli_Load(object sender, EventArgs e)
        {
            //Hali Hazırdaki Admin Bilgilerini Forma Yükleme
            SqlCommand yukleKomut = new SqlCommand("select USERNAME, PAROLA from TBL_ADMIN",baglanti.bg);
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
            //Admin Bilgileri Güncelleme (username & password)
            SqlCommand komutGuncelle = new SqlCommand("update TBL_ADMIN set USERNAME=@p1, PAROLA=@p2",baglanti.bg);
            baglanti.bg.Open();
            komutGuncelle.Parameters.AddWithValue("@p1",txtUsername.Text);
            komutGuncelle.Parameters.AddWithValue("@p2",txtPassword.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.bg.Close();
            MessageBox.Show("Admin bilgileri güncellendi!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        
    }
}
