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
    public partial class ÖlüListesi : Form
    {
        public ÖlüListesi()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        DataTable tablo = new DataTable();
        private void BilgiGetir()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select HastaID,Ad,Soyad,Cinsiyet,Tel,Adres,Dtarihi,Kan,Tc FROM HastaBilgileri Where Durumu='Ölü' ORDER BY HastaID DESC", baglanti);
            adapter.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }

        private void ÖlüListesi_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from HastaBilgileri where Durumu='Ölü' AND Tc like '%" + txttcara.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }

        private void adara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from HastaBilgileri where Durumu='Ölü'AND Ad like '%" + adara.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }
        DataTable dt = new DataTable();
        private void cinsiyetara_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter;
            switch (cinsiyetara.SelectedIndex)
            {
                case 0:
                    adapter = new SqlDataAdapter("Select *From HastaBilgileri where Durumu='Ölü'", baglanti);
                    break;
                case 1:
                    adapter = new SqlDataAdapter("Select *From HastaBilgileri where Durumu='Ölü'AND Cinsiyet='Kadın'", baglanti);
                    break;
                case 2:
                    adapter = new SqlDataAdapter("Select *From HastaBilgileri where Durumu='Ölü'AND Cinsiyet='Erkek'", baglanti);
                    break;
                default:
                    adapter = new SqlDataAdapter("Select *From HastaBilgileri where Durumu='Ölü'", baglanti);
                    break;
            }
            dt.Clear();
            adapter.Fill(dt);
            ekran.DataSource = dt;
            baglanti.Close();
        }
    }
}
