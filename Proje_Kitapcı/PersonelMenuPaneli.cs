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
    public partial class PersonelMenuPaneli : Form
    {
        public PersonelMenuPaneli()
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

        private void btnSatis_Click(object sender, EventArgs e)
        {
            //Satış Panelini Açma
            SatisPaneli wd = new SatisPaneli();
            wd.Kullanici = "personel";
            wd.Show();
            this.Close();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            //İstatistik Paneli Açma
            IstatistikPaneli wd = new IstatistikPaneli();
            wd.Kullanici = "personel";
            wd.Show();
            this.Close();
        }

        private void btnEnvanter_Click(object sender, EventArgs e)
        {
            //Personel Envanter Panelini Açma
            PersonelEnvanterPaneli wd = new PersonelEnvanterPaneli();
            wd.Show();
            this.Close();
        }
    }
}
