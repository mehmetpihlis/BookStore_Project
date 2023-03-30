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
    public partial class AdminGirisPaneli : Form
    {
        public AdminGirisPaneli()
        {
            InitializeComponent();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComeBackBox_Click(object sender, EventArgs e)
        {
            //Ana Giriş Paneline Geri Dönme
            AnaGirisPaneli wd = new AnaGirisPaneli();
            wd.Show();
            this.Close();
        }

        //Sınıf Üzerinden Veri Tabanı Bağlantısı
        Baglanti baglanti = new Baglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            //Admin Girişi Yapma 
            baglanti.bg.Open();
            SqlCommand komutAdmin = new SqlCommand("select USERNAME, PAROLA from TBL_ADMIN where USERNAME=@p1 and PAROLA=@p2",baglanti.bg);
            komutAdmin.Parameters.AddWithValue("@p1",txtUsername.Text);
            komutAdmin.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader dr = komutAdmin.ExecuteReader();
            if (dr.Read())
            {
                AdminMenuPaneli wd = new AdminMenuPaneli();
                wd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Parola yanlış","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            baglanti.bg.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
