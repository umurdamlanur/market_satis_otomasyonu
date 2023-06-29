using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace market_satis_otomasyonu
{
    public partial class satıs_sayfası : Form
    {
        public satıs_sayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=ürün_sistemi;Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            // Verileri çekmek için SqlCommand sınıfını kullanın.
            string query = "SELECT * FROM ürün";
            SqlCommand command = new SqlCommand(query, baglanti);

            // Verileri bir DataTable nesnesine yükleyin.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // DataGridView nesnesine DataTable nesnesini atayarak verileri yükleyin.
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtkod.Text = reader["urunkodu"].ToString();
                txtad.Text = reader["urunadi"].ToString();
                txturunfiyati.Text = reader["urunfiyati"].ToString();
            }

            reader.Close();


            baglanti.Close();
        }

        private void btnadetekle_Click(object sender, EventArgs e) //eksiltme işlemi yap değiştirme değil
        {
            /* string veri1 = txtkod.Text;
             string veri2 = txtad.Text;
             double value1, value2, result;



             if (double.TryParse(txtcarp.Text, out value1) && double.TryParse(txturunfiyati.Text, out value2))
             {
                 result = value1 * value2;
                 listBox1.Items.Add(String.Join("\t", veri1, veri2, $"{value1} x {value2} = {result}"));
             }*/
            string veri1 = txtkod.Text;
            string veri2 = txtad.Text;
            double value1, value2, result;
            double toplam = 0; // toplamı tutmak için bir değişken oluşturun

            if (double.TryParse(txtcarp.Text, out value1) && double.TryParse(txturunfiyati.Text, out value2))
            {
                result = value1 * value2;
                listBox1.Items.Add(String.Join("\t", veri1, veri2, $"{value1} x {value2} = {result}"));

                // Her yeni işlem eklendiğinde toplamı güncelleyin
                foreach (string item in listBox1.Items)
                {
                    string[] carpim = item.Split('=');
                    double deger2 = Convert.ToDouble(carpim[1].Replace(" ", ""));
                    toplam += deger2;
                }

                txttoplam.Text = toplam.ToString(); // Toplamı textbox'a yazdırın

                // Adet bilgisini veritabanından eksiltin
                int adet = Convert.ToInt32(txtcarp.Text);
                if (adet > 0)
                {
                    adet--;
                }
                // Veritabanına güncellenmiş adet bilgisini kaydedin
                string connectionString = "Data Source=DESKTOP-4VOD4RV\\SQLEXPRESS01;Initial Catalog=ürün_sistemi;Integrated Security=True";
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    SqlCommand kontrolKomutu = new SqlCommand("SELECT urunmiktari FROM ürün WHERE urunkodu=@p2", baglanti);
                    kontrolKomutu.Parameters.AddWithValue("@p2", txtkod.Text);
                    int mevcutAdet = Convert.ToInt32(kontrolKomutu.ExecuteScalar());

                    // Girilen miktarı mevcut adetten çıkarın
                    int girilenAdet = Convert.ToInt32(txtcarp.Text);
                    int yeniAdet = mevcutAdet - girilenAdet;
                    if (yeniAdet < 0)
                    {
                        // Eksi değer oluşmaması için minimum değer 0 olarak ayarlanır
                        yeniAdet = 0;
                    }

                    // Yeni adet bilgisini kontrol edin ve uygun mesajı gösterin
                    if (yeniAdet < mevcutAdet * 0.1)
                    {
                        MessageBox.Show("Stok miktarı %10 un altında! Dikkatli olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Yeni adet bilgisini veritabanına kaydetmek için güncelleme sorgusunu kullanın
                    SqlCommand komut2 = new SqlCommand("UPDATE ürün SET urunmiktari=@p1 WHERE urunkodu=@p2", baglanti);
                    komut2.Parameters.AddWithValue("@p1", yeniAdet);
                    komut2.Parameters.AddWithValue("@p2", txtkod.Text);
                    komut2.ExecuteNonQuery();

                    baglanti.Close();
                }
            }


        }

    

        private void btnpdf_Click(object sender, EventArgs e)
        {
            /*// Yeni bir Pdf dosyası oluşturun.
            PdfDocument pdf = new PdfDocument();

            // Sayfa boyutunu belirleyin.
            PdfPage page = pdf.AddPage();
            page.Size = PageSize.A4;
            // Sayfa içeriğini çizmek için bir PdfGraphics nesnesi oluşturun.
            PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page);

            // Yazı tipini ve boyutunu belirleyin.
            PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Arial", 10);
            // Listbox'taki her öğeyi Pdf dosyasına ekleyin.
            int y = 50;
            foreach (object item in listBox1.Items)
            {
                // Her öğe için bir satır çizin.
                gfx.DrawString(item.ToString(), font, PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(50, y, page.Width.Point, page.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                y += 20;
            }
            // Pdf dosyasını kaydedin.
            string filePath = "listbox_items.pdf";
            pdf.Save(filePath);

            // Pdf dosyasını açın.
            System.Diagnostics.Process.Start(filePath);
            */
            // Yeni bir Pdf dosyası oluşturun.
            PdfDocument pdf = new PdfDocument();

            // Sayfa boyutunu belirleyin.
            PdfPage page = pdf.AddPage();
            page.Size = PageSize.A4;

            // Sayfa içeriğini çizmek için bir PdfGraphics nesnesi oluşturun.
            PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page);

            // Yazı tipini ve boyutunu belirleyin.
            PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Arial", 10);

            // Listbox'taki her öğeyi Pdf dosyasına ekleyin.
            int y = 50;
            foreach (object item in listBox1.Items)
            {
                // Her öğe için bir satır çizin.
                gfx.DrawString(item.ToString(), font, PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(50, y, page.Width.Point, page.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                y += 20;
            }

            // txttoplam değerini PDF dosyasına ekleyin
            string toplam = txttoplam.Text;
            gfx.DrawString("Toplam: " + toplam.ToString() + " TL", font, PdfSharp.Drawing.XBrushes.Black,
        new PdfSharp.Drawing.XRect(50, y, page.Width.Point, page.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

            // Pdf dosyasını kaydedin.
            string filePath = "listbox_items.pdf";
            pdf.Save(filePath);

            // Pdf dosyasını açın.
            System.Diagnostics.Process.Start(filePath);

        }

        private void txtcarp_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* double toplam = 0.0;

            foreach (string item in listBox1.Items)
            {
                string[] parts = item.Split('\t');
                string[] carpim = parts[2].Split('x');
                double deger1 = Convert.ToDouble(carpim[0]);
                double deger2 = Convert.ToDouble(carpim[1].Replace(" ", "")); //Boşluk karakterini kaldırın
                double sonuc = deger1 * deger2;
                toplam += sonuc;
            }

            txttoplam.Text = toplam.ToString();
           */
        }
    }
}
