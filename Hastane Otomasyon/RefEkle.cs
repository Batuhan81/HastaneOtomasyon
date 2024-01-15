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

namespace Hastane_Otomasyon
{
    public partial class RefEkle : Form
    {
        private refakatcı a;
        public RefEkle(refakatcı refakat)
        {
            InitializeComponent();
            a= refakat;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        string tc;
        private void RefEkle_Load(object sender, EventArgs e)
        {
            txtOda.Text = a.OdaID;
            tc = a.Hastatc;
            IdBulma();
            txthastatc.Text = tc;
            EkranaYazdır();
        }
     
        public void IdBulma()
        {
            baglanti.Open();
            SqlCommand IdBul = new SqlCommand("Select HastaID FROM HastaBilgileri Where Tc=@Tc", baglanti);
            IdBul.Parameters.AddWithValue("@Tc", tc);
            SqlDataReader reader = IdBul.ExecuteReader();
            if (reader.Read())
            {
                txthastaID.Text = reader.GetInt32(0).ToString();
            }
            baglanti.Close();
            reader.Close();
        }
      

        private void button1_Click(object sender, EventArgs e)//Ekle Kaydet butonu
        {
            if(refID.Text == "")
            {
                //Yeni kayıt Eklendiği Kısım
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO RefekatBilgileri (Ad,Soyad,Tc,HastaID,Tel,OdaID)Values(@Ad,@Soyad,@Tc,@HastaID,@Tel,@OdaID)", baglanti);
                komut.Parameters.AddWithValue("@Ad", txtad.Text);
                komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@Tc", txttc.Text);
                komut.Parameters.AddWithValue("@HastaID", txthastaID.Text);
                komut.Parameters.AddWithValue("@Tel", txttel.Text);
                komut.Parameters.AddWithValue("@OdaID", txtOda.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Refakatçı Kayıt İşlemi başarılı.");
                EkranaYazdır();
            }
            else
            {
                baglanti.Open();
                SqlCommand güncelle = new SqlCommand("Update RefekatBilgileri set Ad=@Ad,Soyad=@Soyad,Tc=@Tc,Tel=@Tel",baglanti);
                güncelle.Parameters.AddWithValue("@Ad", txtad.Text);
                güncelle.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                güncelle.Parameters.AddWithValue("@Tc", txttc.Text);
                güncelle.Parameters.AddWithValue("@Tel", txttel.Text);
                baglanti.Close();
            }
            Temizle();
        }

        private void EkranaYazdır()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from RefekatBilgileri Where OdaID=@OdaID And HastaID=@HastaID ", baglanti);
            komut2.Parameters.AddWithValue("@OdaID",txtOda.Text);
            komut2.Parameters.AddWithValue("@HastaID", txthastaID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ekran.DataSource = dt;
            baglanti.Close();
        }

        private void ekran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = ekran.CurrentRow.Cells["Ad"].Value.ToString();
            txtsoyad.Text = ekran.CurrentRow.Cells["Soyad"].Value.ToString();
            txttc.Text = ekran.CurrentRow.Cells["Tc"].Value.ToString();
            txttel.Text = ekran.CurrentRow.Cells["Tel"].Value.ToString();
            refID.Text = ekran.CurrentRow.Cells["RefID"].Value.ToString();
        }

        DataSet daset = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı Silmek İstediğininze Emin Misininz", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from RefekatBilgileri where Tc='" + txttc.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                EkranaYazdır();
                MessageBox.Show("Kayıt Silindi");
                Temizle();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }
        void Temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttc.Text = "";
            txttel.Text = "";
        }
    }
}
