using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Proje_Kitapcı
{
    public class Baglanti
    {
        //SQL Bağlantı Adresini Okuma -!adress.txt içine bağlantı adresi yazılması gerekli!
        static string adress = System.IO.File.ReadAllText(@"C:\Users\mehme\OneDrive\Masaüstü\Proje_Kitapcı\adress.txt");

        //Üstteki .txt soyasından okunan adres ile bağlantı kurma
        public SqlConnection bg = new SqlConnection(adress);
    }
}
