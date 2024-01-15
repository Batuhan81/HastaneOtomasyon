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
    public partial class AmeliyatBilgiGüncelle : Form
    {
        public AmeliyatBilgiGüncelle()
        {
            InitializeComponent();
        }
        bool durum=true;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        public void Verileriaktar(string odaAdi, string Ameliyatkat, string durumu)
        {
            odano.Text = odaAdi;
            odakatı.Text = Ameliyatkat;
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
        List<string> AmeliyathaneDolMu = new List<string>();
        string dolubos;
        bool AmeliyathaneDolu = false;

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Günelleme İşlemini Yapmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comboDurum.Text == "Servis Dışı")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *From Ameliyathane  Where AmeliyatID=@AmeliyatID", baglanti);
                komut.Parameters.AddWithValue("@AmeliyatID", odano.Text);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    dolubos = reader["Durumu"].ToString();
                    AmeliyathaneDolMu.Add(dolubos);
                }
                for (int i = 0; i < AmeliyathaneDolMu.Count; i++)
                {
                    if (AmeliyathaneDolMu[i] == "Dolu")
                    {
                        AmeliyathaneDolu = true;
                    }
                }
                baglanti.Close();
                reader.Close();
            }
            if (result == DialogResult.Yes)
            {
                if (AmeliyathaneDolu == false)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update Ameliyathane Set Durumu=@Durumu Where AmeliyatID=@AmeliyatID", baglanti);
                    komut.Parameters.AddWithValue("@Durumu", comboDurum.Text);
                    komut.Parameters.AddWithValue("@AmeliyatID", odano.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    timer1.Start();
                    MessageBox.Show("Güncelleme Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Servis Dışına Alınmak İstenen Ameliyathanede Ameliyat Devam Ediyor Var!!!", "İşlem Gerçekleştirilemiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AmeliyathaneDolu = false;
                }
            }
            else
            {
                timer1.Start();
                MessageBox.Show("İşlem İptal Edildi");
            }
            this.Close();
            Ameliyathane git = new Ameliyathane();
            git.ShowDialog();
        }
    }
}
