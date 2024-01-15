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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyon
{
    public partial class AmeliyathaneBilgi : Form
    {

        private Sınıf3 snf3;
        private Sınıf1 snf1;
        private CalısanB clsn;
        public AmeliyathaneBilgi(Sınıf1 s1, Sınıf3 s3, CalısanB s4)
        {
            InitializeComponent();
            snf1 = s1;
            snf3 = s3;
            clsn = s4;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        void HastaList()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select HastaID,Ad,Soyad,Tc,OdaID,Cinsiyet,Tel,Adres,YatakID From HastaBilgileri Where Durumu='Beklemede'", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            Göster(adapter);
            baglanti.Close();
        }

        private void Göster(SqlDataAdapter adapter)
        {
            tablo.Clear();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void AmeliyathaneBilgi_Load(object sender, EventArgs e)
        {
            Ad.Text = snf1.Ad;
            Soyad.Text = snf1.Soyad;
            Adres.Text = snf1.Adres;
            Tc.Text = snf1.Tc;
            Kan.Text = snf1.Kan;
            Cinsiyet.Text = snf1.Cinsiyet;
            Tel.Text = snf1.Tel;
            Dtarihi.Text = snf1.Dtarihi;
            refsayisi.Text = snf1.Refs;
            Hastadurumu.Text = snf1.Durumu;
            YatakID.Text = snf1.YatakID;
            hiddenameliyatID.Text = snf1.AmeliyatID;

            dAdı.Text = clsn.Ad;
            dSoyad.Text = clsn.Soyad;
            dTc.Text = clsn.Tc;
            dAdres.Text = clsn.Adres;
            DCinsiyet.Text = clsn.Cinsiyet;
            DTel.Text = clsn.Tel;
            comboDepartman.Text = clsn.Departman;
            HastaList();
            Idbulma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hastayı Ölü Listesine eklemek istediğinize Emin Misiniz?","Onay Bekleniyor",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;"))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update HastaBilgileri set Durumu='Ölü', Cıkıst=@Cıkıst  where Tc=@Tc", baglanti);
                    komut.Parameters.AddWithValue("@Cıkıst", DateTime.Now);
                    komut.Parameters.AddWithValue("@Tc", Tc.Text);
                    komut.ExecuteNonQuery();

                    SqlCommand komut2 = new SqlCommand("Update Yatak set Hastatc=' ',Durumu='Boş' Where YatakID=@YatakID", baglanti);
                    komut2.Parameters.AddWithValue("@YatakID", YatakID.Text);
                    komut2.ExecuteNonQuery();

                    BosaCıkart(baglanti);

                    SqlCommand komut5 = new SqlCommand("Delete *From RefakatBilgileri Where HastaID=@HastaID", baglanti);
                    komut5.Parameters.AddWithValue("@HastaID", hiddenhastaID);
                    komut5.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }

        private void BosaCıkart(SqlConnection baglanti)
        {
            

            SqlCommand komut3 = new SqlCommand("Update Ameliyathane set HastaID=@HastaID,Durumu=@Durumu Where AmeliyatID=@AmeliyatID", baglanti);
            komut3.Parameters.AddWithValue("@AmeliyatID", hiddenameliyatID.Text);
            komut3.Parameters.AddWithValue("@Durumu", "Boş");
            komut3.Parameters.AddWithValue("@HastaID", 0);
            komut3.ExecuteNonQuery();

            SqlCommand komut4 = new SqlCommand("Update CalısanBilgileri set Durumu='Boşta' Where Tc=@Tc", baglanti);
            komut4.Parameters.AddWithValue("@Tc", dTc.Text);
            komut4.ExecuteNonQuery();
        }

        void Idbulma()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select HastaID FRom HastaBilgileri Where Tc=@Tc", baglanti);
            komut.Parameters.AddWithValue("@Tc",Tc.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if(reader.Read())
            {
                hiddenhastaID.Text = reader["HastaID"].ToString();
            }
            baglanti.Close() ;
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ameliyat Bitti Hasta Odaya geri Alınsın Mı?","Onay Bekleniyor",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut =new SqlCommand("Update  HastaBilgileri set Durumu='Kalıyor'   Where HastaID=@HastaID", baglanti);
                komut.Parameters.AddWithValue("@HastaID", hiddenhastaID.Text);
                komut.ExecuteNonQuery();

                BosaCıkart(baglanti);
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
            this.Close();
            Odalar git=new Odalar();  
            git.ShowDialog();
        }
    }
}
