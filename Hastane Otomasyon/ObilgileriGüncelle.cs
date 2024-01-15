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
    public partial class ObilgileriGüncelle : Form
    {
        public ObilgileriGüncelle()
        {
            InitializeComponent();
        }
        bool durum = true;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");

        public void Verileriaktar(string odaAdi, string yataks, string odakat, string durumu)
        {
            odano.Text = odaAdi;
            odakatı.Text = odakat;
            yataksa.Text = yataks;
            comboDurum.Text = durumu;

            if (comboDurum.Text == "Dolu")
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
        List<string> yatakDolumu = new List<string>();
        string dolubos;
        bool odaDolu=false;
        private void btngüncelle_Click(object sender, EventArgs e)//içindeki yataklarıda otomatik olarak servis dışına almalı fakat içleri boşsa
        {
            DialogResult result = MessageBox.Show("Günelleme İşlemini Yapmak İStediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(comboDurum.Text=="Servis Dışı")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Yatak  Where OdaID=@OdaID", baglanti);
                komut.Parameters.AddWithValue("@OdaID", odano.Text);
                SqlDataReader reader= komut.ExecuteReader();
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
            if (result == DialogResult.Yes)
            {
                if(odaDolu==false) 
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update Oda Set OdaDurumu=@OdaDurumu Where OdaID=@OdaID", baglanti);
                    komut.Parameters.AddWithValue("@OdaDurumu", comboDurum.Text);
                    komut.Parameters.AddWithValue("@OdaID", odano.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    timer1.Start();
                    MessageBox.Show("Güncelleme Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Servi Dışına Alınmak İstenen Odada Kalanlar Var!!!","İşlem Gerçekleştirilemiyor",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    odaDolu=false;
                }
            }
            else
            {
                timer1.Start();
                MessageBox.Show("İşlem İptal Edildi");
            }
            this.Close();
            Odalar git =new Odalar();
            git.ShowDialog();
        }
        //Güncelleye ve iptale tıklandığında ne yapılcak onlar yazılacak
    }
}
