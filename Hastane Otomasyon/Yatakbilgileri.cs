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

namespace Hastane_Otomasyon
{
    public partial class Yatakbilgileri : Form
    {
        private Sınıf3 snf3;
        private Sınıf1 snf1;
        public Yatakbilgileri(Sınıf1 s1, Sınıf3 s3)
        {
            InitializeComponent();
            snf1 = s1;
            snf3 = s3;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        private void Yatakbilgileri_Load(object sender, EventArgs e)
        {
            Ad.Text = snf1.Ad;
            Soyad.Text = snf1.Soyad;
            Adres.Text = snf1.Adres;
            Tc.Text = snf1.Tc;
            Kan.Text= snf1.Kan;
            Cinsiyet.Text = snf1.Cinsiyet;
            Tel.Text = snf1.Tel;
            Dtarihi.Text = snf1.Dtarihi;
            refsayisi.Text = snf1.Refs;
            Sikayeti.Text = snf1.Sikayeti;
            Hastadurumu.Text = snf1.Durumu;
            
            Odano.Text = snf3.Odano;
            Odakat.Text = snf3.Odakat;
            yatakno.Text = snf3.YatakID;
            comboDurum.Text = snf3.Durumu;
            timer1.Stop();
            RefsBul();
        }
        bool durum = false;
        void Bostamı()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Durumu  FROM HastaBilgileri Where Tc=@Tc", baglanti);
            komut.Parameters.AddWithValue("Tc", Tc.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                if (reader["Durumu"].ToString() == "Ameliyatta")
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
            }
            baglanti.Close();
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bostamı();
            if (durum !=true)
            {
                DialogResult result = MessageBox.Show("Hastayı Taburcu Etmek İstediğinize Emin Misiniz ?", "Onay Bekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Hastanın bilgilerini güncelleyip çıkışını yapıyorum
                    baglanti.Open();
                    SqlCommand taburcu = new SqlCommand("Update HastaBilgileri set Durumu=@Durumu,OdaID=@OdaID,Cıkıst=@cıkıst WHERE Tc=@Tc", baglanti);
                    taburcu.Parameters.AddWithValue("Durumu", "Taburcu");
                    taburcu.Parameters.AddWithValue("OdaID", -1);//kalmış olduğu odayı işlevsiz kılmayı amaçlıyorum
                    taburcu.Parameters.AddWithValue("Cıkıst", DateTime.Now);//İşlemin yapılma tarihini çıkışt olarak atıyorum
                    taburcu.Parameters.AddWithValue("@Tc", Tc.Text);
                    taburcu.ExecuteNonQuery();
                    baglanti.Close();
                    //Çıkan hastanın bulunduğu yatağı boşa çıkartıyorum.

                    baglanti.Open();
                    SqlCommand bosalt = new SqlCommand("Update Yatak Set Durumu=@Durumu WHERE YatakID=@YatakID", baglanti);
                    //bosalt.Parameters.AddWithValue("@Hastatc", Tc.Text);//ben tcye göre işlem yaptım hep IDsini çekmedim tcye göre işlem yapacağım;
                    bosalt.Parameters.AddWithValue("@Durumu", "Boş");
                    bosalt.Parameters.AddWithValue("@YatakID", yatakno.Text);//aslında ID
                    bosalt.ExecuteNonQuery();
                    timer1.Start();
                    MessageBox.Show("Hasta Taburcu Edildi");
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut5 = new SqlCommand("Delete From RefakatBilgileri Where HastaID=@HastaID", baglanti);
                    komut5.Parameters.AddWithValue("@HastaID", HastaID);
                    komut5.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    timer1.Start();
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
            else
            {
                MessageBox.Show("Hasta Ameliyatta", "Silme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        int HastaID;
        public void IdBulma()
        {
            baglanti.Open();
            SqlCommand IdBul = new SqlCommand("Select HastaID FROM HastaBilgileri Where Tc=@Tc", baglanti);
            IdBul.Parameters.AddWithValue("@Tc",Tc.Text);
            SqlDataReader reader= IdBul.ExecuteReader();
            if (reader.Read())
            {
                HastaID = reader.GetInt32(0);
            }
            baglanti.Close() ;
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Güncelle Butonu
        {
            IdBulma();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update HastaBilgileri set Ad=@Ad,Soyad=@Soyad,Tc=@Tc,OdaID=@OdaID,Durumu=@Durumu,Cinsiyet=@Cinsiyet,Dtarihi=@Dtarihi,Kan=@Kan,Refs=@Refs,Tel=@Tel,Adres=@Adres,Sikayeti=@Sikayeti Where HastaID=@HastaID ", baglanti);
            komut.Parameters.AddWithValue("@Ad",Ad.Text);
            komut.Parameters.AddWithValue("@Soyad",Soyad.Text);
            komut.Parameters.AddWithValue("@Tc",Tc.Text);
            komut.Parameters.AddWithValue("@OdaID",Odano.Text);
            komut.Parameters.AddWithValue("@Durumu",Hastadurumu.Text);
            komut.Parameters.AddWithValue("@Cinsiyet",Cinsiyet.Text);
            komut.Parameters.AddWithValue("@Dtarihi",Convert.ToDateTime( Dtarihi.Text));
            komut.Parameters.AddWithValue("@Kan",Kan.Text);
            komut.Parameters.AddWithValue("@Refs",refsayisi.Text);
            komut.Parameters.AddWithValue("@Tel",Tel.Text);
            komut.Parameters.AddWithValue("@Adres",Adres.Text);
            komut.Parameters.AddWithValue("@Sikayeti",Sikayeti.Text);
            komut.Parameters.AddWithValue("@HastaID",HastaID);
            komut.ExecuteNonQuery();
            MessageBox.Show("Hasta Bilgileri Güncellendi");
            timer1.Start();
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            SendKeys.Send("{ESC}");//ESC tuşuna basılmış gibi çalışıyor
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Tc.Text != "")
            {
                refakatcı a = new refakatcı();
                a.OdaID = Odano.Text;
                a.Hastatc = Tc.Text;
                RefEkle git = new RefEkle(a);
                git.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hasta Tcsi Girdiğinizden Emin Olun");
            }
        }
        int max;
        void maxId()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MAX(HastaID) FROM HastaBilgileri", baglanti);
            max = (int)komut.ExecuteScalar();
            baglanti.Close();
        }
        void RefsBul()
        {
            maxId();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM RefekatBilgileri WHERE HastaID = @HastaID", baglanti);
            komut.Parameters.AddWithValue("@HastaID", max );

            int refakatciSayisi = (int)komut.ExecuteScalar();
            refsayisi.Text = refakatciSayisi.ToString();
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(Hastadurumu.Text == "Beklemede"|| Hastadurumu.Text == "Ameliyatta")
            {
                MessageBox.Show("Hasta Zaten Sırada","İşlem Gerçekleştirilemez",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Hastayı Ameliyat Listesine Eklemek İstediğinize Emin Misiniz ?", "Onay Bekleniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update HastaBilgileri SET Durumu='Beklemede' where Tc=@Tc", baglanti);
                    komut.Parameters.AddWithValue("@Tc", Tc.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Hastadurumu.Text = "Beklemede";
                }
            }
        }
    }
}
