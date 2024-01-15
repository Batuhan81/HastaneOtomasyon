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
using System.Windows.Forms.DataVisualization.Charting;

namespace Hastane_Otomasyon
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");

        string secilenkatoda = 1.ToString();
        string secilenkatyatak= 1.ToString();
        string secilenkatameliyat= 1.ToString();
        int toplamOdaSayisi = 1;
        int toplamYatakSayisi = 1;
        int toplamAmeliyatSayisi = 1;
        public void OdaBilgileri()
        {
            baglanti.Open();
            string[] durumlar = { "Dolu", "Boş", "Servis Dışı", "Rezerve" };
            Color[] renkler = { Color.Red, Color.Green, Color.Gray, Color.Yellow };
            // Seçilen kattaki toplam oda sayısını buldurma
            SqlCommand toplamOdaKomut = new SqlCommand("SELECT COUNT(*) FROM Oda WHERE Odakatı=@Odakatı", baglanti);
            toplamOdaKomut.Parameters.AddWithValue("@Odakatı", secilenkatoda);
            toplamOdaSayisi = (int)toplamOdaKomut.ExecuteScalar();

            for (int i = 0; i < durumlar.Length; i++)
            {
                string durum = durumlar[i];
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Oda WHERE Odakatı=@Odakatı AND OdaDurumu=@OdaDurumu", baglanti);
                komut.Parameters.AddWithValue("@Odakatı", secilenkatoda);
                komut.Parameters.AddWithValue("@OdaDurumu", durum);

                int odaSayisi = (int)komut.ExecuteScalar();

                if (odaSayisi > 0)
                {
                    odachart.Series[0].Points.AddXY(durum, odaSayisi);
                    odachart.Series[0].Points[i].Color = renkler[i]; // Her durum için farklı renk
                    double yuzdelikOran = (double)odaSayisi / toplamOdaSayisi * 100.0;
                    odachart.Series[0].Points[i].Label = $"{durumlar[i]}: {yuzdelikOran.ToString("0.00")}%";
                }
                else
                {
                    odachart.Series[0].Points.AddXY(durum, 0);//Eğer o Durumda bir oda yoksa etiketini siliyorumki kötü görüntü oluşmasın
                    odachart.Series[0].Points[i].IsEmpty = true;
                }
            }
            odachart.Titles.Clear();
            odachart.Titles.Add("Oda Durumları"); // Başlık
            odachart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Pasta grafiği türü
            baglanti.Close();
        }
        public void YatakBilgileri()
        {
            baglanti.Open();
            string[] durumlar = { "Dolu", "Boş", "Servis Dışı", "Rezerve" };
            Color[] renkler = { Color.Red, Color.Green, Color.Gray, Color.Yellow };
            // Seçilen kattaki toplam oda sayısını buldurma
            SqlCommand toplamYatakKomut = new SqlCommand("SELECT COUNT(*) FROM Yatak WHERE Odakat=@Odakat", baglanti);
            toplamYatakKomut.Parameters.AddWithValue("Odakat", secilenkatyatak);
            toplamYatakSayisi = (int)toplamYatakKomut.ExecuteScalar();

            for (int i = 0; i < durumlar.Length; i++)
            {
                string durum = durumlar[i];
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Yatak WHERE Odakat=@Odakat AND Durumu=@Durumu", baglanti);
                komut.Parameters.AddWithValue("@Odakat", secilenkatyatak);
                komut.Parameters.AddWithValue("@Durumu", durum);

                int yataksayisi = (int)komut.ExecuteScalar();

                if (yataksayisi > 0)
                {
                    yatakChart.Series[0].Points.AddXY(durum, yataksayisi);
                    yatakChart.Series[0].Points[i].Color = renkler[i]; // Her durum için farklı renk
                    double yuzdelikOran = (double)yataksayisi / toplamYatakSayisi * 100.0;
                    yatakChart.Series[0].Points[i].Label = $"{durumlar[i]}: {yuzdelikOran.ToString("0.00")}%";
                }
                else
                {
                    yatakChart.Series[0].Points.AddXY(durum, 0);//Eğer o Durumda bir oda yoksa etiketini siliyorumki kötü görüntü oluşmasın
                    yatakChart.Series[0].Points[i].IsEmpty = true;
                }
            }
            yatakChart.Titles.Clear();
            yatakChart.Titles.Add("Yatak Durumları"); // Başlık
            yatakChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Pasta grafiği türü
            baglanti.Close();
        }
        public void AmeliyatBilgileri()
        {
            baglanti.Open();
            string[] durumlar = { "Dolu", "Boş", "Servis Dışı", "Rezerve" };
            Color[] renkler = { Color.Red, Color.Green, Color.Gray, Color.Yellow };
            // Seçilen kattaki toplam oda sayısını buldurma
            SqlCommand toplamAmeliyatKomut = new SqlCommand("SELECT COUNT(*) FROM Ameliyathane WHERE Kat=@Kat", baglanti);
            toplamAmeliyatKomut.Parameters.AddWithValue("@Kat", secilenkatameliyat);
            toplamAmeliyatSayisi = (int)toplamAmeliyatKomut.ExecuteScalar();

            for (int i = 0; i < durumlar.Length; i++)
            {
                string durum = durumlar[i];
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Ameliyathane WHERE Kat=@Kat AND Durumu=@Durumu", baglanti);
                komut.Parameters.AddWithValue("@Kat", secilenkatameliyat);
                komut.Parameters.AddWithValue("@Durumu", durum);

                int ameliyatsayisi = (int)komut.ExecuteScalar();

                if (ameliyatsayisi > 0)
                {
                    ameliyatchart.Series[0].Points.AddXY(durum, ameliyatsayisi);
                    ameliyatchart.Series[0].Points[i].Color = renkler[i]; // Her durum için farklı renk
                    double yuzdelikOran = (double)ameliyatsayisi / toplamAmeliyatSayisi * 100.0;
                    ameliyatchart.Series[0].Points[i].Label = $"{durumlar[i]}: {yuzdelikOran.ToString("0.00")}%";
                }
                else
                {
                    ameliyatchart.Series[0].Points.AddXY(durum, 0);//Eğer o Durumda bir oda yoksa etiketini siliyorumki kötü görüntü oluşmasın
                    ameliyatchart.Series[0].Points[i].IsEmpty = true;
                }
            }
            ameliyatchart.Titles.Clear();
            ameliyatchart.Titles.Add("Ameliyathane Durumları"); // Başlık
            ameliyatchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Pasta grafiği türü
            baglanti.Close();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            Odakatdoldur();
            odachart.Series[0].Points.Clear();
            odachart.Titles.Clear();
            OdaBilgileri();
            OdaGenelDoluluk();
            YatakKat();
            yatakChart.Series[0].Points.Clear();
            yatakChart.Titles.Clear();
            YatakBilgileri();
            YatakGenelDoluluk();
            Ameliyatkatdoldur();
            ameliyatchart.Series[0].Points.Clear();
            ameliyatchart.Titles.Clear();
            AmeliyatBilgileri();
            ameliyatGenelDoluluk();
        }
        public void YatakKat() //combokat a Eklenen Katları yerleştiriyor
        {
            comboKat.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KatID From OdaKat", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboKat.Items.Add(reader["KatID"].ToString());
            }
            reader.Close();
            baglanti.Close();
        }
        public void Odakatdoldur() //combokat a Eklenen Katları yerleştiriyor
        {
            odakatgir.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KatID From OdaKat", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                odakatgir.Items.Add(reader["KatID"].ToString());
            }
            reader.Close();
            baglanti.Close();
        }
        public void Ameliyatkatdoldur() //combokat a Eklenen Katları yerleştiriyor
        {
            ameliyatkatgir.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KatID From AmeliyatKat", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ameliyatkatgir.Items.Add(reader["KatID"].ToString());
            }
            reader.Close();
            baglanti.Close();
        }

        private void comboKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            yatakChart.Series[0].Points.Clear();
            yatakChart.Titles.Clear();
            secilenkatyatak = comboKat.Text;
            YatakBilgileri();
        }

        private void odakatgir_SelectedIndexChanged(object sender, EventArgs e)
        {
            odachart.Series[0].Points.Clear();
            odachart.Titles.Clear();
            secilenkatoda = odakatgir.Text;
            OdaBilgileri();
        }

        private void ameliyatkatgir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ameliyatchart.Series[0].Points.Clear();
            ameliyatchart.Titles.Clear();
            secilenkatameliyat = ameliyatkatgir.Text;
            AmeliyatBilgileri();
        }

        private void geneldoluluk_Click(object sender, EventArgs e)
        {
            YatakGenelDoluluk();
        }
        void OdaGenelDoluluk()
        {
            odachart.Series[0].Points.Clear();
            odachart.Titles.Clear();
            baglanti.Open();
            string[] durumlar = { "Dolu", "Boş", "Servis Dışı", "Rezerve" };
            Color[] renkler = { Color.Red, Color.Green, Color.Gray, Color.Yellow };

            // Seçilen kattaki toplam oda sayısını bulun
            SqlCommand toplamOdaKomut = new SqlCommand("SELECT COUNT(*) FROM Oda ", baglanti);
            toplamOdaSayisi = (int)toplamOdaKomut.ExecuteScalar();

            for (int i = 0; i < durumlar.Length; i++)
            {
                string durum = durumlar[i];
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Oda WHERE OdaDurumu=@OdaDurumu", baglanti);
                komut.Parameters.AddWithValue("@OdaDurumu", durum);
                int odaSayisi = (int)komut.ExecuteScalar();

                if (odaSayisi > 0)
                {
                    odachart.Series[0].Points.AddXY(durum, odaSayisi);
                    odachart.Series[0].Points[i].Color = renkler[i]; // Her durum için farklı renk
                    double yuzdelikOran = (double)odaSayisi / toplamOdaSayisi * 100.0;
                    odachart.Series[0].Points[i].Label = $"{durumlar[i]}: {yuzdelikOran.ToString("0.00")}%";
                }
                else
                {
                    odachart.Series[0].Points.AddXY(durum, 0); // Eğer oda yoksa 0 olarak ekleyin
                    odachart.Series[0].Points[i].IsEmpty = true; // Boş etiketler
                }
            }
            odachart.Titles.Add("Oda Genel Durum"); // Başlık
            odachart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Pasta grafiği türü
            baglanti.Close();
        }
        void YatakGenelDoluluk()
        {
            yatakChart.Series[0].Points.Clear();
            yatakChart.Titles.Clear();
            baglanti.Open();
            string[] durumlar = { "Dolu", "Boş", "Servis Dışı", "Rezerve" };
            Color[] renkler = { Color.Red, Color.Green, Color.Gray, Color.Yellow };

            // Seçilen kattaki toplam oda sayısını bulun
            SqlCommand toplamOdaKomut = new SqlCommand("SELECT COUNT(*) FROM Yatak ", baglanti);
            toplamYatakSayisi = (int)toplamOdaKomut.ExecuteScalar();

            for (int i = 0; i < durumlar.Length; i++)
            {
                string durum = durumlar[i];
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Yatak WHERE Durumu=@Durumu", baglanti);
                komut.Parameters.AddWithValue("@Durumu", durum);
                int Yataksaiyisi = (int)komut.ExecuteScalar();

                if (Yataksaiyisi > 0)
                {
                    yatakChart.Series[0].Points.AddXY(durum, Yataksaiyisi);
                    yatakChart.Series[0].Points[i].Color = renkler[i]; // Her durum için farklı renk
                    double yuzdelikOran = (double)Yataksaiyisi / toplamYatakSayisi * 100.0;
                    yatakChart.Series[0].Points[i].Label = $"{durumlar[i]}: {yuzdelikOran.ToString("0.00")}%";
                }
                else
                {
                    yatakChart.Series[0].Points.AddXY(durum, 0); // Eğer oda yoksa 0 olarak ekleyin
                    yatakChart.Series[0].Points[i].IsEmpty = true; // Boş etiketler
                }
            }
            yatakChart.Titles.Add("Yatak Genel Durum"); // Başlık
            yatakChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Pasta grafiği türü
            baglanti.Close();
        }
        void ameliyatGenelDoluluk()
        {
            ameliyatchart.Series[0].Points.Clear();
            ameliyatchart.Titles.Clear();
            baglanti.Open();
            string[] durumlar = { "Dolu", "Boş", "Servis Dışı", "Rezerve" };
            Color[] renkler = { Color.Red, Color.Green, Color.Gray, Color.Yellow };

            // Seçilen kattaki toplam oda sayısını bulun
            SqlCommand toplamOdaKomut = new SqlCommand("SELECT COUNT(*) FROM Ameliyathane ", baglanti);
            toplamAmeliyatSayisi = (int)toplamOdaKomut.ExecuteScalar();

            for (int i = 0; i < durumlar.Length; i++)
            {
                string durum = durumlar[i];
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Ameliyathane WHERE Durumu=@Durumu", baglanti);
                komut.Parameters.AddWithValue("@Durumu", durum);
                int AmeliyathaneSayisi = (int)komut.ExecuteScalar();

                if (AmeliyathaneSayisi > 0)
                {
                    ameliyatchart.Series[0].Points.AddXY(durum, AmeliyathaneSayisi);
                    ameliyatchart.Series[0].Points[i].Color = renkler[i]; // Her durum için farklı renk
                    double yuzdelikOran = (double)AmeliyathaneSayisi / toplamAmeliyatSayisi * 100.0;
                    ameliyatchart.Series[0].Points[i].Label = $"{durumlar[i]}: {yuzdelikOran.ToString("0.00")}%";
                }
                else
                {
                    ameliyatchart.Series[0].Points.AddXY(durum, 0); // Eğer oda yoksa 0 olarak ekleyin
                    ameliyatchart.Series[0].Points[i].IsEmpty = true; // Boş etiketler
                }
            }
            ameliyatchart.Titles.Add("Ameliyathane Genel Durum"); // Başlık
            ameliyatchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Pasta grafiği türü
            baglanti.Close();
        }
        private void OdaDoluluk_Click(object sender, EventArgs e)
        {
            OdaGenelDoluluk();
        }

        private void Ameliyatoluluk_Click(object sender, EventArgs e)
        {
            ameliyatGenelDoluluk();
        }
    }
}
