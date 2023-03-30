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
    public partial class AnaGirisPaneli : Form
    {
        public AnaGirisPaneli()
        {
            InitializeComponent();
        }

        private void AdminpictureBox_Click(object sender, EventArgs e)
        {
            //Admin Giriş Paneli Açma
            AdminGirisPaneli wd = new AdminGirisPaneli();
            wd.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PersonelpictureBox_Click(object sender, EventArgs e)
        {
            //Personel Giriş Panelini Açma
            PersonelGirisPaneli wd = new PersonelGirisPaneli();
            wd.Show();
            this.Hide();
        }
    }
}
