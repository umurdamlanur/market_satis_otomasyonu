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

namespace market_satis_otomasyonu
{
    public partial class admin_giris : Form
    {
        public admin_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=guvenlik;Integrated Security = True");
        SqlCommand komut;
        SqlDataReader dr;

        private void btngiris_Click(object sender, EventArgs e)
        {
            string ad = txtkullaniciadi.Text;
            string sifre = txtsifre.Text;
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from tbl_parola where ad='" + ad + "' and sıfree='" + sifre + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anasayfa f2 = new anasayfa();
                f2.Show();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            baglanti.Close();
        }

        private void btngirisatla_Click(object sender, EventArgs e)
        {
            anasayfa a2 = new anasayfa();
            a2.Show();
        }
    }
}
