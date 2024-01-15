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
    public partial class Ref_Listesi : Form
    {
        public Ref_Listesi()
        {
            InitializeComponent();
        }

        private void Ref_Listesi_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        DataTable tablo = new DataTable();
        private void BilgiGetir()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select RefID,Ad,Soyad,Tel,Tc,HastaID,OdaID FROM RefekatBilgileri ORDER BY RefID DESC", baglanti);
            adapter.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from RefekatBilgileri Where Tc like '%" + txttcara.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }

        private void adara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from RefekatBilgileri where  Ad like '%" + adara.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }

        private void OdayaGöre_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select  RefID,Ad,Soyad,Tc,Tel,HastaID From RefekatBilgileri where OdaID like '%" + OdayaGöre.Text + "%'", baglanti);
            tablo.Clear();
            adtr.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }
    }
}
