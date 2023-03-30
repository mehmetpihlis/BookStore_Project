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
    public partial class PersonelGirisPaneli : Form
    {
        public PersonelGirisPaneli()
        {
            InitializeComponent();
        }

        private void ComeBackBox_Click(object sender, EventArgs e)
        {
            //Ana Giriş Paneline Geri Dönme
            AnaGirisPaneli wd = new AnaGirisPaneli();
            wd.Show();
            this.Close();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Baglanti baglanti = new Baglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Personel Giriş İşlemi
            SqlCommand komutPerGiris = new SqlCommand("select USERNAME, PAROLA from TBL_PERSONEL where USERNAME=@p1 and PAROLA=@p2", baglanti.bg);
            baglanti.bg.Open();
            komutPerGiris.Parameters.AddWithValue("@p1",txtUsername.Text);
            komutPerGiris.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = komutPerGiris.ExecuteReader();
            if (dr.Read())
            {
                PersonelMenuPaneli wd = new PersonelMenuPaneli();
                wd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Parola yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.bg.Close();
        }
    }
}
