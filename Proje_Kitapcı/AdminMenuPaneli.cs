using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Kitapcı
{
    public partial class AdminMenuPaneli : Form
    {
        public AdminMenuPaneli()
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

        private void btnAdminBilgi_Click(object sender, EventArgs e)
        {

            //Admin Bilgi Güncelleme Panelini Açma
            AdminBilgileriGuncellemePaneli wd = new AdminBilgileriGuncellemePaneli();
            wd.Show();
            this.Close();
        }

        private void btnPersonelBilgi_Click(object sender, EventArgs e)
        {
            //Personel Bilgi Güncelleme Panelini Açma
            PersonelBilgileriGüncellemePaneli wd = new PersonelBilgileriGüncellemePaneli();
            wd.Show();
            this.Close();
        }

        private void btnEnvanter_Click(object sender, EventArgs e)
        {
            //Admin Envanter Panelini Açma
            AdminEnvanterPaneli wd = new AdminEnvanterPaneli();
            wd.Show();
            this.Close();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            //İstatistik Paneli Açma
            IstatistikPaneli wd = new IstatistikPaneli();
            wd.Kullanici = "admin";
            wd.Show();
            this.Close();
        }

        private void btnSatıs_Click(object sender, EventArgs e)
        {
            //Satış Panelini Açma
            SatisPaneli wd = new SatisPaneli();
            wd.Kullanici = "admin";
            wd.Show();
            this.Close();
        }
    }
}
