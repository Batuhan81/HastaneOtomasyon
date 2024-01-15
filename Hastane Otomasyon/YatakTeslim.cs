using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hastane_Otomasyon
{
    public partial class YatakTeslim : Form
    {

        private string yatak;
        Sınıf3 snf3;
        public YatakTeslim(string ytk ,Sınıf3 s3)
        {
            InitializeComponent();
            yatak = ytk;
            snf3 = s3;
        }

        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");

        private void YatakTeslim_Load(object sender, EventArgs e)
        {
            // DateTimePicker'ın Format ve CustomFormat özelliklerini ayarlayın
            YatisT.Format = DateTimePickerFormat.Custom;
            YatisT.CustomFormat = "dd/MM/yyyy HH:mm";
            Odano.Text = snf3.Odano;
            Odakat.Text=snf3.Odakat;
            yatakno.Text = snf3.YatakID;
            comboDurum.Text = snf3.Durumu;
            if(comboDurum.Text=="Servis Dışı")
            {
                btnrezerve.Visible = false;
                button2.Visible = false;
                btntemizle.Visible = false;
                btnYatakteslim.Visible = false;
            }
            else
            {
                btnrezerve.Visible = true;
                button2.Visible = true;
                btntemizle.Visible = true;
                btnYatakteslim.Visible = true;
            }
        }
    
        private void button2_Click(object sender, EventArgs e)//Refakatçı Ekle
        {
            btnYatakteslim_Click(sender ,e);
            if (Tc.Text != "")
            {
                 refakatcı a= new refakatcı();
                a.OdaID=Odano.Text;
                a.Hastatc =Tc.Text ;
                RefEkle git=new RefEkle(a);
                git.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hasta Tcsi Girdiğinizden Emin Olun");
            }
        }


        private void btntemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if(item is ComboBox)
                {
                    item.Text = "";
                }
                if(item is UserControl)
                {
                    item.Text = "";
                }
            }
        }
        bool durum = true;
        private void TcKOntrol()//Hasta Başka bir Odada Kalıyorsa engelle
        {
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("SELECT * FROM HastaBilgileri WHERE (Durumu='Kalıyor' OR Durumu='Rezerve' OR Durumu='Ölü') AND Tc=@Tc", baglanti);
            kontrol.Parameters.AddWithValue("@Tc", Tc.Text);
            SqlDataReader reader = kontrol.ExecuteReader();
            if (reader.Read())
            {
                durum = false;//engelledim
            }
            else//Bunların yeri Yanlışmış şuan doğru
            {
                durum = true;
            }
            baglanti.Close();
        }
        bool boskontrol=true;
        private void bosKontrol()
        {
            if (Ad.Text == "" || Soyad.Text == ""||Cinsiyet.Text==""||Tel.Text==""||Adres.Text==""||Dtarihi.Text==""||Kan.Text=="")
            {
                boskontrol = false;
            }
            else
            {
                boskontrol = true;
            }
        }
        
        private void btnYatakteslim_Click(object sender, EventArgs e)
        {
            TcKOntrol();
            if(durum==true)//Hasta başka odada Kalmıyor kayıt eklenebilir.
            { 
                bosKontrol();
                if(boskontrol==false)
                {
                    MessageBox.Show("Müşteri ile İlgili Tüm Alanları Doldurduğunuzdan Emin Olun!", "Uyarı!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO HastaBilgileri( Ad,Soyad,Tc,Cinsiyet,Dtarihi,Kan,Refs,Tel,Adres,Sikayeti,Durumu,Girist,OdaID,YatakID) Values(@Ad,@Soyad,@Tc,@Cinsiyet,@Dtarihi,@Kan,@Refs,@Tel,@Adres,@Sikayeti,@Durumu,@Girist,@OdaID,@YatakID)", baglanti);
                    komut.Parameters.AddWithValue("@Ad",Ad.Text); 
                    komut.Parameters.AddWithValue("@Soyad",Soyad.Text); 
                    komut.Parameters.AddWithValue("@Tc",Tc.Text); 
                    komut.Parameters.AddWithValue("@Cinsiyet",Cinsiyet.Text); 
                    komut.Parameters.AddWithValue("@Dtarihi",Convert.ToDateTime(Dtarihi.Text)); 
                    komut.Parameters.AddWithValue("@Kan", Kan.Text); 
                    komut.Parameters.AddWithValue("@Refs", refsayisi.Text); 
                    komut.Parameters.AddWithValue("@Tel", Tel.Text); 
                    komut.Parameters.AddWithValue("@Adres",Adres.Text); 
                    komut.Parameters.AddWithValue("@Sikayeti",Sikayeti.Text); 
                    komut.Parameters.AddWithValue("@Durumu","Kalıyor"); 
                    komut.Parameters.AddWithValue("@Girist",DateTime.Today); 
                    komut.Parameters.AddWithValue("@OdaID", Odano.Text);
                    komut.Parameters.AddWithValue("@YatakID",yatakno.Text);
                    MessageBox.Show("Kişi Odayı Teslim Aldı");
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //Yatağın durumu doluya çevirmem gerekli
                    baglanti.Open();
                    SqlCommand YatakDoldur = new SqlCommand("UPDATE Yatak Set Durumu=@Durumu,Hastatc=@Hastatc WHERE YatakID=@YatakID", baglanti);
                    YatakDoldur.Parameters.AddWithValue("@Durumu", "Dolu");
                    YatakDoldur.Parameters.AddWithValue("@Hastatc",Tc.Text);
                    YatakDoldur.Parameters.AddWithValue("@YatakID", yatakno.Text);
                    YatakDoldur.ExecuteNonQuery();
                    baglanti.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hasta'nın Başka Bir odada kalmadığına Emin Olunuz. ","Uyarı ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnrezerve_Click(object sender, EventArgs e)
        {
            TcKOntrol();
            if (durum == true)//Hasta başka odada Kalmıyor kayıt eklenebilir.
            {
                bosKontrol();
                if (boskontrol == false)
                {
                    MessageBox.Show("Müşteri ile İlgili Tüm Alanları Doldurduğunuzdan Emin Olun!", "Uyarı!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO HastaBilgileri( Ad,Soyad,Tc,Cinsiyet,Dtarihi,Kan,Refs,Tel,Adres,Sikayeti,Durumu,Girist,OdaID,YatakID) Values(@Ad,@Soyad,@Tc,@Cinsiyet,@Dtarihi,@Kan,@Refs,@Tel,@Adres,@Sikayeti,@Durumu,@Girist,@OdaID,@YatakID)", baglanti);
                    komut.Parameters.AddWithValue("@Ad", Ad.Text);
                    komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
                    komut.Parameters.AddWithValue("@Tc", Tc.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet.Text);
                    komut.Parameters.AddWithValue("@Dtarihi", Convert.ToDateTime(Dtarihi.Text));
                    komut.Parameters.AddWithValue("@Kan", Kan.Text);
                    komut.Parameters.AddWithValue("@Refs", refsayisi.Text);
                    komut.Parameters.AddWithValue("@Tel", Tel.Text);
                    komut.Parameters.AddWithValue("@Adres", Adres.Text);
                    komut.Parameters.AddWithValue("@Sikayeti", Sikayeti.Text);
                    komut.Parameters.AddWithValue("@Durumu", "Gelecek");//Sorun burada
                    komut.Parameters.AddWithValue("@Girist", Convert.ToDateTime(reztarih.Text));
                    komut.Parameters.AddWithValue("@OdaID", Odano.Text);
                    komut.Parameters.AddWithValue("@YatakID", yatakno.Text);
                    MessageBox.Show("Kişi Odayı Teslim Aldı");
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //Yatağın durumu doluya çevirmem gerekli
                    baglanti.Open();
                    SqlCommand YatakDoldur = new SqlCommand("UPDATE Yatak Set Durumu=@Durumu WHERE YatakID=@YatakID", baglanti);
                    YatakDoldur.Parameters.AddWithValue("@Durumu", "Rezerve");
                    YatakDoldur.Parameters.AddWithValue("@YatakID", yatakno.Text);
                    YatakDoldur.ExecuteNonQuery();
                    baglanti.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hasta Başka Bir Odada Hali Hazırda Kalıyor! ", "Uyarı ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        DataTable tablo = new DataTable();

        private void Tc_TextChanged(object sender, EventArgs e)
        {
            TCGetirme();
            ekran.Visible = true;
        }
      
        private void TCGetirme()
        {
            tablo.Clear();
            baglanti.Open();
           SqlDataAdapter adapter=new SqlDataAdapter("Select HastaID,Ad,Soyad,Cinsiyet,Tel,Adres,Dtarihi,Kan,Tc FROM HastaBilgileri Where Tc like '%"+Tc.Text+ "%' AND Durumu NOT IN('Kalıyor','Gelecek','Ölü')",baglanti);
            adapter.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }
        private void ekran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ad.Text = ekran.CurrentRow.Cells["Ad"].Value.ToString();
            Soyad.Text = ekran.CurrentRow.Cells["Soyad"].Value.ToString();
            Cinsiyet.Text = ekran.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            Tel.Text = ekran.CurrentRow.Cells["Tel"].Value.ToString();
            Adres.Text = ekran.CurrentRow.Cells["Adres"].Value.ToString();
            Dtarihi.Text = ekran.CurrentRow.Cells["Dtarihi"].Value.ToString();
            Kan.Text = ekran.CurrentRow.Cells["Kan"].Value.ToString();
            Tc.Text = ekran.CurrentRow.Cells["Tc"].Value.ToString();
            HastaID.Text = ekran.CurrentRow.Cells["HastaID"].Value.ToString();
            ekran.Visible = false;
        }

        private void Ad_MouseEnter(object sender, EventArgs e)
        {
            ekran.Visible=false;
        }
    }
}
