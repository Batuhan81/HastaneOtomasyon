using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class AmeliyatTeslim : Form
    {
        private string ameliyat;
        Sınıf3 snf3;
        public AmeliyatTeslim(string no, Sınıf3 s3)
        {
            InitializeComponent();
            ameliyat = no;
            snf3 = s3;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        private void AmeliyatTeslim_Load(object sender, EventArgs e)
        {
            HastaList();
            BosDoktor();
        }
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
        void BosDoktor()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select CalısanID,Ad,Soyad,Tc,Departman,Cinsiyet,Tel,Durumu From CalısanBilgileri Where Departman='Doktor' AND Durumu='Boşta'", baglanti);
            SqlDataAdapter adapter= new SqlDataAdapter(komut);
            tablo2.Clear();
            adapter.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
        }
        string Tc;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Tc !=null && DoktorTc != null)
            {
                DialogResult result = MessageBox.Show("Seçilen Doktor ve Hasta Ameliyata Alınacak Emin Misiniz", "Onay Bekleniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Hasta Durumu Ameliyatta olarak Güncelle
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update HastaBilgileri SET Ameliyathane=@Ameliyathane,Durumu='Ameliyatta' where Tc=@Tc", baglanti);
                    komut.Parameters.AddWithValue("@Tc", Tc);
                    komut.Parameters.AddWithValue("@Ameliyathane", ameliyat);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("Update CalısanBilgileri SET Durumu='Ameliyatta',Ameliyathane=@Ameliyathane where Tc=@Tc2", baglanti);
                    komut2.Parameters.AddWithValue("@Tc2", DoktorTc);
                    komut2.Parameters.AddWithValue("@Ameliyathane", ameliyat);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    HastaList();
                    BosDoktor();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("Update Ameliyathane SET Durumu='Dolu',CalısanID=@CalısanID,HastaID=@HastaID where AmeliyatID=@AmeliyatID", baglanti);
                    komut3.Parameters.AddWithValue("@AmeliyatID",ameliyat);
                    komut3.Parameters.AddWithValue("@CalısanID", DoktorID.Text);
                    komut3.Parameters.AddWithValue("@HastaID", hastaID.Text);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    DoktorID.Text = "";
                    hastaID.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Doktor Ve Hasta Seçtiğinizden Emin Olunuz","İşlem Gerçekleştirilemiyor",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ad,Soyad,Tc,OdaID,Cinsiyet,Tel,Adres,YatakID
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
           
            string hastaAdi = selectedRow.Cells["Ad"].Value.ToString();
            string Soyad = selectedRow.Cells["Soyad"].Value.ToString();
            Tc = selectedRow.Cells["Tc"].Value.ToString();
            string OdaID = selectedRow.Cells["OdaID"].Value.ToString();
            string Cinsiyet = selectedRow.Cells["Cinsiyet"].Value.ToString();
            string Tel = selectedRow.Cells["Tel"].Value.ToString();
            string Adres = selectedRow.Cells["Adres"].Value.ToString();
            string YatakID = selectedRow.Cells["YatakID"].Value.ToString();
            hastaID.Text = selectedRow.Cells["HastaID"].Value.ToString();
        }
        string DoktorTc;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ad,Soyad,Tc,Departman,Cinsiyet,Tel,Durumu
            DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
            string adi = selectedRow.Cells["Ad"].Value.ToString();
            string Soyad = selectedRow.Cells["Soyad"].Value.ToString();
             DoktorTc = selectedRow.Cells["Tc"].Value.ToString();
            string Cinsiyet = selectedRow.Cells["Cinsiyet"].Value.ToString();
            string Tel = selectedRow.Cells["Tel"].Value.ToString();
            string departman = selectedRow.Cells["Departman"].Value.ToString();
            string Durumu = selectedRow.Cells["Durumu"].Value.ToString();
            DoktorID.Text = selectedRow.Cells["CalısanID"].Value.ToString();
        }
    }
}
