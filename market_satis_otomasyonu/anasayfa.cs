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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=ürün_sistemi;Integrated Security = True");
       

        private void anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ürün_sistemiDataSet.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter.Fill(this.ürün_sistemiDataSet.ürün);

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Veritabanında aynı kaydın olup olmadığını kontrol etmek için sorgu
            SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM ürün WHERE urunkodu=@p1 AND urunadi=@p2 AND urunfiyati=@p3 AND urunmiktari=@p4", baglanti);
            kontrolKomutu.Parameters.AddWithValue("@p1", txturunkodu.Text);
            kontrolKomutu.Parameters.AddWithValue("@p2", txturunadı.Text);
            kontrolKomutu.Parameters.AddWithValue("@p3", double.Parse(txturunfiyati.Text));
            kontrolKomutu.Parameters.AddWithValue("@p4", txturunmiktari.Text);
            int count = (int)kontrolKomutu.ExecuteScalar();

            if (count > 0)
            {
                // Değer mevcut
                MessageBox.Show("üzgünüm daha önce bu bilgilere sahip bir ürün eklediniz.lütfen yeniden deneyiniz!!");
            }
            else
            {
                // Değer mevcut değil, kaydı ekle
                SqlCommand komut = new SqlCommand("INSERT INTO ürün (urunkodu, urunadi, urunfiyati, urunmiktari) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txturunkodu.Text);
                komut.Parameters.AddWithValue("@p2", txturunadı.Text);
                komut.Parameters.AddWithValue("@p3", double.Parse(txturunfiyati.Text));
                komut.Parameters.AddWithValue("@p4", txturunmiktari.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("ürün başarıyla eklendi.");
            }


            baglanti.Close();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE ürün SET urunadi=@p2, urunfiyati=@p3, urunmiktari=@p4 WHERE urunkodu=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txturunkodu.Text);
                komut.Parameters.AddWithValue("@p2", txturunadı.Text);
                komut.Parameters.AddWithValue("@p3", double.Parse(txturunfiyati.Text));
                komut.Parameters.AddWithValue("@p4", txturunmiktari.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün bilgileri başarıyla güncellendi.");
            
                baglanti.Close();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from ürün where urunkodu=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txturunkodu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürün bilgileri silindi.");
            baglanti.Close();

        }

        private void btnsatıssayfasi_Click(object sender, EventArgs e)
        {
            satıs_sayfası s2 = new satıs_sayfası();
            s2.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunkodu.Text = dataGridView1.CurrentRow.Cells["urunkodu"].Value.ToString();
            txturunadı.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txturunfiyati.Text = dataGridView1.CurrentRow.Cells["urunfiyati"].Value.ToString();
            txturunmiktari.Text = dataGridView1.CurrentRow.Cells["urunmiktari"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();

            // Seçili hücrenin değerini alın.
            string selectedValue = dataGridView1.SelectedCells[0].Value.ToString();

            // Verileri çekmek için SqlCommand sınıfını kullanın.
            string query = "SELECT * FROM ürün WHERE urunadi = @selectedValue";
            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@selectedValue", selectedValue);

            // Verileri okumak için SqlDataReader sınıfını kullanın.
            SqlDataReader reader = command.ExecuteReader();

            // SqlDataReader'dan verileri okuyun ve TextBox'lara ekle.
            if (reader.Read())
            {
                txturunkodu.Text = reader["urunkodu"].ToString();
                txturunadı.Text = reader["urunadi"].ToString();
                txturunfiyati.Text = reader["urunfiyati"].ToString();
                txturunmiktari.Text = reader["urunmiktari"].ToString();
            }

            reader.Close();


            baglanti.Close();
        }

        //ürün arama kodu
        //textbox_TextChanged
        //DataTable tablo = new ();
        //SqlDataAdapter...
        //31-32.dk 
        //https://www.youtube.com/watch?v=vVU8r56NIcw&list=PL22TK-6CtDafQkb1bMdoRyL7yhnMZwxDy&index=3
    }
}
