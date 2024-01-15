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
    public partial class Çalısan : Form
    {
        public Çalısan()
        {
            InitializeComponent();
        }

        void temizle()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                hiidenCalısanID.Text = "";
            }
        }

        private void Çalısan_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        DataTable tablo = new DataTable();
        private void BilgiGetir()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Ad,Soyad,Departman,Tc,Adres,Cinsiyet,Maas,CalısanID,Tel,Durumu FROM CalısanBilgileri ORDER BY CalısanID DESC", baglanti);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text=dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtsoyad.Text=dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            txtdepartman.Text=dataGridView1.CurrentRow.Cells["Departman"].Value.ToString();
            txttc.Text=dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            txtadres.Text=dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtcinsiyet.Text=dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            txtmaas.Text=dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
            hiidenCalısanID.Text=dataGridView1.CurrentRow.Cells["CalısanID"].Value.ToString();
            txttel.Text= dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
            combodurum.Text= dataGridView1.CurrentRow.Cells["Durumu"].Value.ToString();
        }

        private void Kaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            if (hiidenCalısanID.Text == "")
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO CalısanBilgileri (Ad,Soyad,Departman,Tc,Adres,Cinsiyet,Maas,Tel,Durumu)Values(@Ad,@Soyad,@Departman,@Tc,@Adres,@Cinsiyet,@Maas,@Tel,@Durumu)", baglanti);
                ekle.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                ekle.Parameters.AddWithValue("@Departman", txtdepartman.Text);
                ekle.Parameters.AddWithValue("@Tc", txttc.Text);
                ekle.Parameters.AddWithValue("@Adres", txtadres.Text);
                ekle.Parameters.AddWithValue("@Ad", txtad.Text);
                ekle.Parameters.AddWithValue("@Cinsiyet", txtcinsiyet.Text);
                ekle.Parameters.AddWithValue("@Maas", txtmaas.Text);
                ekle.Parameters.AddWithValue("@Tel", txttel.Text);
                ekle.Parameters.AddWithValue("@Durumu","Boşta");
                ekle.ExecuteNonQuery();
            }
            else
            {
                SqlCommand güncelle = new SqlCommand("Update CalısanBilgileri Set Ad=@Ad,Soyad=@Soyad,Departman=@Departman,Tc=@Tc,Adres=@Adres,Cinsiyet=@Cinsiyet,Maas=@Maas,Tel=@Tel,Durumu=@Durumu Where CalısanID=@CalısanID", baglanti);
                güncelle.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                güncelle.Parameters.AddWithValue("@Departman", txtdepartman.Text);
                güncelle.Parameters.AddWithValue("@Tc", txttc.Text);
                güncelle.Parameters.AddWithValue("@Adres", txtadres.Text);
                güncelle.Parameters.AddWithValue("@Ad", txtad.Text);
                güncelle.Parameters.AddWithValue("@Tel", txttel.Text);
                güncelle.Parameters.AddWithValue("@Cinsiyet", txtcinsiyet.Text);
                güncelle.Parameters.AddWithValue("@Maas", Convert.ToDecimal(txtmaas.Text));
                güncelle.Parameters.AddWithValue("@CalısanID", hiidenCalısanID.Text);
                güncelle.Parameters.AddWithValue("@Durumu", combodurum.Text);
                güncelle.ExecuteNonQuery();
            }
            baglanti.Close();
            BilgiGetir();
            temizle();
        }
        bool durum = false;
        void Bostamı()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Durumu  FROM CalısanBilgileri Where CalısanID=@CalısanID", baglanti);
            komut.Parameters.AddWithValue("CalısanID", hiidenCalısanID.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                if(reader["Durumu"].ToString()=="Ameliyatta")
                {
                   durum=true;
                }
                else
                {
                    durum=false;
                }
            }
            baglanti.Close();
            reader.Close();
        }

        private void sil_Click_1(object sender, EventArgs e)
        {
            Bostamı();
            if(durum != true)
            {
                DialogResult result = MessageBox.Show("Kaydı Silmek İstediğininze Emin Misiniz", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from CalısanBilgileri where CalısanID='" + hiidenCalısanID.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    BilgiGetir();
                    MessageBox.Show("Kayıt Silindi");
                    temizle();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
            else
            {
                MessageBox.Show("Doktor Ameliyatta","Silme İşlemi Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
        DataTable dt = new DataTable();
        private void departara_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter;
            switch (departara.SelectedIndex)
            {
                case 0:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Departman='Doktor'",baglanti);
                    break;
                case 1:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Departman='Hemşire'", baglanti);
                    break;
                case 2:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Departman='Güvenlik'", baglanti);
                    break;
                case 3:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Departman='Temizlikçi'", baglanti);
                    break;
                case 4:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Departman='Profesör'", baglanti);
                    break;
                default:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri", baglanti);
                    break;
            }
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from CalısanBilgileri where Tc like '%" + txttcara.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void adara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from CalısanBilgileri where Ad like '%" + adara.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void cinsiyetara_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter;
            switch (cinsiyetara.SelectedIndex)
            {
                case 0:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri", baglanti);
                    break;
                case 1:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Cinsiyet='Kadın'", baglanti);
                    break;
                case 2:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Cinsiyet='Erkek'", baglanti);
                    break;
                default:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri", baglanti);
                    break;
            }
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Durumara_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter;
            switch (Durumara.SelectedIndex)
            {
                case 0:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri", baglanti);
                    break;
                case 1:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Durumu='Ameliyatta'", baglanti);
                    break;
                case 2:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Durumu='Boşta'", baglanti);
                    break;
                case 3:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Durumu='İzinde'", baglanti);
                    break;
                case 4:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri Where Durumu='Dolu'", baglanti);
                    break;
                default:
                    adapter = new SqlDataAdapter("Select *From CalısanBilgileri", baglanti);
                    break;
            }
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
