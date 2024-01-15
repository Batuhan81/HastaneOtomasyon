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
    public partial class YatakbilgiGüncelle : Form
    {
        public YatakbilgiGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        public void Verileriaktar(string OdaID, string hasta, string hastaıd,string odakat, string durumu, string yatakadı)
        {
            txtodaID.Text = OdaID;
            txtkat.Text = odakat;
            txtyatakID.Text = yatakadı;
            txtDurumu.Text = durumu;
            hstTc.Text= hasta;
            hastaID.Text = hastaıd;
            if (hasta!=null)
            {
                hstTc.Text = hasta;
            }
            else
            {
                hstTc.Text = "Odada Kalan Yok";
            }
        }
        List<string> yatakDolumu = new List<string>();
        bool odaDolu=false;
        string dolubos;
        private void Güncelle_Click(object sender, EventArgs e)
        {
            if (txtDurumu.Text == "Servis Dışı")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Yatak  Where YatakID=@YatakID", baglanti);
                komut.Parameters.AddWithValue("@YatakID", txtyatakID.Text);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    dolubos = reader["Durumu"].ToString();
                    yatakDolumu.Add(dolubos);
                }
                for (int i = 0; i < yatakDolumu.Count; i++)
                {
                    if (yatakDolumu[i] == "Dolu")
                    {
                        odaDolu = true;
                    }
                }
                baglanti.Close();
                reader.Close();
            }
            DialogResult result = MessageBox.Show("Günelleme İşlemini Yapmak İStediğinize Emin Misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (odaDolu == false)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update Yatak Set Durumu=@Durumu Where YatakID=@YatakID", baglanti);
                    komut.Parameters.AddWithValue("@Durumu", txtDurumu.Text);
                    komut.Parameters.AddWithValue("@YatakID", txtyatakID.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    timer1.Start();
                    MessageBox.Show("Güncelleme Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Servis Dışına Alınmak İstenen Yatakta Kalanlar Var!!!", "İşlem Gerçekleştirilemiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    odaDolu = false;
                }
            }
            else
            {
                timer1.Start();
                MessageBox.Show("İşlem İptal Edildi");
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            SendKeys.Send("{ESC}");//ESC tuşuna basılmış gibi çalışıyor
        }
    }
}
