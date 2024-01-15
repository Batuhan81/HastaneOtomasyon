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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyon
{
    public partial class OdaEkle : Form
    {
        public katbilgisi mtd;
        public OdaEkle(katbilgisi a)
        {
            InitializeComponent();
            mtd = a;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        private void OdaEkle_Load(object sender, EventArgs e)
        {
            YeniODaID();
        }
        int sonButonID = 0;
        public bool EkleButonunaTiklandi { get; private set; } = false;//ekleye tıklandıysa odalar formunda ekleme işlemine devam edecek
        private void YeniODaID() //sondaki oda silinmediği sürece sorun yok o silinse dahi kendi kendine düzeliyor
        {
            baglanti.Open();
            SqlCommand maxButonIDKomut = new SqlCommand("SELECT ISNULL(MAX(odaID), 0) FROM Oda", baglanti);
            sonButonID = (int)maxButonIDKomut.ExecuteScalar();
            baglanti.Close();
            int yeniodaId = sonButonID + 1;
            odano.Text = yeniodaId.ToString();
            baglanti.Close();
        }
        int sonYatakID;
        int yeniYatakID;
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (yataks.Text != null)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Oda(Yataks,OdaDurumu)Values(@Yataks,@OdaDurumu)", baglanti);
                komut.Parameters.AddWithValue("@Yataks", yataks.Text);
                komut.Parameters.AddWithValue("@OdaDurumu","Boş");
                komut.ExecuteNonQuery();
                MessageBox.Show("Oda Ekleme İşlemi Başarılı");
                baglanti.Close();

                //baglanti.Open();
                //SqlCommand komut2 = new SqlCommand("insert into Yatak(OdaID,Durumu,Odakat)Values(@OdaID,@Durumu,@Odakat)", baglanti);
                //komut2.Parameters.AddWithValue("@OdaID", odano.Text);
                //komut2.Parameters.AddWithValue("@Durumu", "Boş");
                //komut2.Parameters.AddWithValue("@Odakat", mtd.SeciliKat);//Buraya kat bilgisini getirmeliyim ama nasıl
                //komut2.ExecuteNonQuery();
                //MessageBox.Show("Oda Ekleme İşlemi Başarılı");
                //baglanti.Close();

                baglanti.Open();//Son Yatağın İdsini oluşturma
                // Yatak Tablosundaki en yüksek ID'yi al
                SqlCommand maxyatakID = new SqlCommand("SELECT ISNULL(MAX(YatakID), 0) FROM Yatak", baglanti);
                sonYatakID = (int)maxyatakID.ExecuteScalar();
                baglanti.Close();
                for (int i = 0; i <Convert.ToInt32(yataks.Text); i++)
                {
                    if (sonYatakID != 1)
                    {
                        yeniYatakID = sonYatakID + 1;
                    }
                    else
                    {
                        yeniYatakID = 1;
                    }

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("insert into Yatak(OdaID,Durumu,Odakat)Values(@OdaID,@Durumu,@Odakat)", baglanti);
                    komut2.Parameters.AddWithValue("@OdaID", odano.Text);
                    //komut2.Parameters.AddWithValue("@HastaID",-1);//ilişki yüzünden boş geçme hatası veriyor bak
                    komut2.Parameters.AddWithValue("@Durumu", "Boş");
                    komut2.Parameters.AddWithValue("@Odakat", mtd.SeciliKat);//Buraya kat bilgisini getirmeliyim ama nasıl
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                }
                EkleButonunaTiklandi = true; // "Ekle" butonuna tıklandığını işaretle
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilgileri Eksiksiz Girdiğinizden Emin Olunuz");
            }
        }

        private void odano_TextChanged(object sender, EventArgs e)
        {
            YeniODaID();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
