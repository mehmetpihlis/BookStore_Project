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
    public partial class PersonelEnvanterPaneli : Form
    {
        public PersonelEnvanterPaneli()
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
            PersonelMenuPaneli wd = new PersonelMenuPaneli();
            wd.Show();
            this.Close();
        }

        Baglanti baglanti = new Baglanti();

        private void PersonelEnvanterPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBL_BOOKSTOCK", baglanti.bg);
            adapter.Fill(dt); 
            dataGridView1.DataSource = dt;
        }
    }
}
