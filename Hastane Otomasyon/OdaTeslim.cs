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
    public partial class OdaTeslim : Form
    {
        private string gelenOda;
        public Sınıf2 snf2;
        int sonYatakID;
        String secilenkat = 1.ToString();
        public OdaTeslim(string oda, Sınıf2 s2)
        {
            InitializeComponent();
            gelenOda = oda;
            snf2 = s2;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        List<Button> addedButtons = new List<Button>();
        int yeniYatakID;
        private void OdaTeslim_Load(object sender, EventArgs e)
        {
            List<int> yatakBilgileri = new List<int>();
            if (snf2 != null)
            {
                odano.Text = snf2.OdaID;
                yataks.Text = snf2.Yataks;
                odakat.Text = snf2.Odakatı;
                combodurum.Text = snf2.Odadurumu;
                
            }
            int a = Convert.ToInt32(yataks.Text);
            int odaID =Convert.ToInt32(odano.Text);
            baglanti.Open();//Tıkladığım Odaya göre içinde oluşacak olan yatakların IDsini getirdim
            SqlCommand YatakB = new SqlCommand("Select YatakID From Yatak WHERE OdaID=@OdaID", baglanti);
            YatakB.Parameters.AddWithValue("@OdaID", odaID);
            SqlDataReader reader = YatakB.ExecuteReader();
            while (reader.Read())
            {
                int yataklar =Convert.ToInt32( reader["YatakID"]);

                yatakBilgileri.Add(yataklar);
            }
            int deneme=yatakBilgileri.Count;
            baglanti.Close();
            reader.Close();

            for (int i = 0; i < deneme; i++)
            {
                Button btn = new Button();
                yeniYatakID = yatakBilgileri[i];
                btn.Text = yeniYatakID.ToString();
                btn.Name = yeniYatakID.ToString();

                btn.Size = new Size(100, 100);
                RenkDegistir(btn);
                btn.Click += Yonlendir;
                btn.ContextMenuStrip = OdaButtonClick();
                
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update  Yatak  set Odakat=@Odakat,OdaID=@OdaID WHERE YatakID=@YatakID", baglanti);
                komut2.Parameters.AddWithValue("@OdaID",odano.Text);
                komut2.Parameters.AddWithValue("@YatakID", yeniYatakID);
                komut2.Parameters.AddWithValue("@Odakat", odakat.Text);
              
                komut2.ExecuteNonQuery();
                baglanti.Close();
                addedButtons.Add(btn);
                PanelYataklar.Controls.Add(btn);
            }
        }
        private ContextMenuStrip OdaButtonClick()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem güncelle = new ToolStripMenuItem("Güncelle");
            güncelle.Click += Guncelle_Click; // güncelle_Click metoduna tıklama olayını atayın
            menu.Items.Add(güncelle);

            ToolStripMenuItem sil = new ToolStripMenuItem("Sil");
            sil.Click += sil_Click;
            menu.Items.Add(sil);
            return menu;
        }
        private void sil_Click(object sender, EventArgs e)//Sağtık ile seçilen odayı silme
        {
            //Butona Sağ tıklayarak açılan menüden butonu silme
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button secilenButon = (Button)contextMenu.SourceControl;
            string secilenOda = secilenButon.Name;

            baglanti.Open();
            SqlCommand silkomut = new SqlCommand("delete  From Yatak Where YatakID=@YatakID ", baglanti);
            silkomut.Parameters.AddWithValue("@YatakID", secilenOda);
            silkomut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand silindi = new SqlCommand("update  Yatak set Durumu='Silindi' where odaID=@odaID", baglanti);
            silindi.Parameters.AddWithValue("@odaID", secilenOda);
            silindi.ExecuteNonQuery();
            baglanti.Close();

            PanelYataklar.Controls.Remove(secilenButon);
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
        }
        private void Guncelle_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button secilenButon = (Button)contextMenu.SourceControl;
            string yatakAdı = secilenButon.Name;
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Yatak where YatakID=@YatakID", baglanti);
            komut.Parameters.AddWithValue("@YatakID", yatakAdı);
            komut.ExecuteNonQuery();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                string OdaID = reader["OdaID"].ToString();
                string odakat = reader["Odakat"].ToString();
                string durumu = reader["Durumu"].ToString();
                string hasta = reader["Hastatc"].ToString();
                string hastaıd = reader["HastaID"].ToString();
                baglanti.Close();

                YatakbilgiGüncelle güncelle = new YatakbilgiGüncelle();
                güncelle.Verileriaktar(OdaID, hasta,hastaıd, odakat, durumu,yatakAdı);
                this.Close();
                güncelle.ShowDialog();
            }
        }
        public void RenkDegistir(Button btn)
        {
            baglanti.Open();
            SqlCommand durumsorgula = new SqlCommand("SELECT Durumu FROM Yatak WHERE YatakID=@YatakID", baglanti);
            durumsorgula.Parameters.AddWithValue("@YatakID", btn.Name);
            object yatakdurumu = durumsorgula.ExecuteScalar();
            if (yatakdurumu != null)
            {
                string odaDurumu = yatakdurumu.ToString();
                switch (odaDurumu)
                {
                    case "Boş": btn.BackColor = Color.Green; break;
                    case "Dolu": btn.BackColor = Color.Red; break;
                    case "Rezerve": btn.BackColor = Color.Yellow; break;
                    case "Servis Dışı": btn.BackColor = Color.Gray; break;
                    default: btn.BackColor = Color.Green; break;
                }
            }
            else
            {
                btn.BackColor = Color.Green;
            }
            baglanti.Close();
        }
        string tıklananbuton;
        public void YatakBilgiKaydet(Button button, Sınıf3 snf3)
        {
            SqlCommand Odabilgisi = new SqlCommand("SELECT * FROM Yatak Where YatakID=@YatakID ", baglanti);
            Odabilgisi.Parameters.AddWithValue("@YatakID",button.Name);
            SqlDataReader odaReader = Odabilgisi.ExecuteReader();
            if (odaReader.Read())
            {
                snf3.YatakID = odaReader["YatakID"].ToString();
                snf3.Odano = odaReader["OdaID"].ToString();
                snf3.HastaID = odaReader["HastaID"].ToString();
                snf3.Durumu = odaReader["Durumu"].ToString();
                snf3.Odakat = odaReader["Odakat"].ToString();
            }
            snf3.Odakat = odakat.Text;
            odaReader.Close();
        }
       
        public void Yonlendir(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Sınıf1 snf1 = new Sınıf1();
            Sınıf3 snf3 = new Sınıf3();
            Yatakbilgileri getir = new Yatakbilgileri(snf1,snf3);
            baglanti.Open();
            SqlCommand durumsorgusu = new SqlCommand("SELECT Durumu FROM Yatak WHERE YatakID=@YatakID", baglanti);
            durumsorgusu.Parameters.AddWithValue("@YatakID", button.Name.ToString());
            tıklananbuton = button.Name.ToString();
            object durumsorgusuObj = durumsorgusu.ExecuteScalar();
            if (durumsorgusuObj != null)
            {
                string odaDurumu = durumsorgusuObj.ToString();
                switch (durumsorgusuObj)
                {
                    case "Dolu":
                        YatakBilgiKaydet(button, snf3);

                        SqlCommand hastaSorgusu = new SqlCommand("SELECT * FROM HastaBilgileri WHERE YatakID=@YatakID AND Durumu IN ('Kalıyor', 'Beklemede','Ameliyatta')", baglanti);
                        hastaSorgusu.Parameters.AddWithValue("@YatakID", button.Name.ToString());
                        SqlDataReader Reader = hastaSorgusu.ExecuteReader();
                        if (Reader.Read())
                        {
                            snf1.Ad = Reader["Ad"].ToString();
                            snf1.Soyad = Reader["Soyad"].ToString();
                            snf1.Tc = Reader["Tc"].ToString();
                            snf1.Cinsiyet = Reader["Cinsiyet"].ToString();
                            snf1.Dtarihi = Reader["Dtarihi"].ToString();
                            snf1.Kan = Reader["Kan"].ToString();
                            snf1.Refs = Reader["Refs"].ToString();
                            snf1.Tel = Reader["Tel"].ToString();
                            snf1.Adres = Reader["Adres"].ToString();
                            snf1.Sikayeti = Reader["Sikayeti"].ToString();
                            snf1.CalısanID = Reader["CalısanID"].ToString();
                            snf1.Durumu = Reader["Durumu"].ToString();
                            snf1.Girist = Reader["Girist"].ToString();
                            snf1.Cıkıst = Reader["Cıkıst"].ToString();
                            snf1.OdaID = Reader["OdaID"].ToString();
                            getir = new Yatakbilgileri(snf1, snf3);
                            this.Close();
                            getir.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Okuma İşlemi Yapılamıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ; break;
                    case "Boş":

                        YatakTeslim teslim = new YatakTeslim(button.Name, snf3);
                        YatakBilgiKaydet(button, snf3);
                        teslim = new YatakTeslim(button.Name, snf3);
                        this.Close();
                        teslim.ShowDialog();
                        break;
                    case "Servis Dışı":

                        YatakTeslim teslim2 = new YatakTeslim(button.Name, snf3);
                        YatakBilgiKaydet(button, snf3);
                        teslim2 = new YatakTeslim(button.Name, snf3);
                        this.Close();
                        teslim2.ShowDialog();
                        break;
                    case "Rezerve":

                        YatakTeslim teslim3 = new YatakTeslim(button.Name, snf3);
                        YatakBilgiKaydet(button, snf3);
                        SqlCommand hastaSorgusu2 = new SqlCommand("SELECT * FROM HastaBilgileri WHERE YatakID=@YatakID AND Durumu=@Durumu", baglanti);
                        hastaSorgusu2.Parameters.AddWithValue("@YatakID", button.Name.ToString());
                        hastaSorgusu2.Parameters.AddWithValue("@Durumu", "Gelecek");
                        SqlDataReader Reader2 = hastaSorgusu2.ExecuteReader();
                        if (Reader2.Read())
                        {
                            snf1.Ad = Reader2["Ad"].ToString();
                            snf1.Soyad = Reader2["Soyad"].ToString();
                            snf1.Tc = Reader2["Tc"].ToString();
                            snf1.Cinsiyet = Reader2["Cinsiyet"].ToString();
                            snf1.Dtarihi = Reader2["Dtarihi"].ToString();
                            snf1.Kan = Reader2["Kan"].ToString();
                            snf1.Refs = Reader2["Refs"].ToString();
                            snf1.Tel = Reader2["Tel"].ToString();
                            snf1.Adres = Reader2["Adres"].ToString();
                            snf1.Sikayeti = Reader2["Sikayeti"].ToString();
                            snf1.CalısanID = Reader2["CalısanID"].ToString();
                            snf1.Durumu = Reader2["Durumu"].ToString();
                            snf1.Girist = Reader2["Girist"].ToString();
                            snf1.Cıkıst = Reader2["Cıkıst"].ToString();
                            snf1.OdaID = Reader2["OdaID"].ToString();
                            getir = new Yatakbilgileri(snf1, snf3);
                            getir.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Okuma İşlemi Yapılamıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        teslim3 = new YatakTeslim(button.Name, snf3);
                        this.Close();
                        teslim3.ShowDialog();
                    break;
                }
            }
            else
            {
                //YatakTeslim teslim3 = new YatakTeslim(button.Name, snf3);
                //YatakBilgiKaydet(button, snf3);
                //teslim3 = new YatakTeslim(button.Name, snf3);
                //teslim3.ShowDialog();
                YatakTeslim teslim = new YatakTeslim(button.Name, snf3);
                
                SqlCommand bosOda = new SqlCommand("Insert Into Yatak (Odano,HastaID,Durumu) Values(@Odano,@HastaID,@Durumu)", baglanti);
                bosOda.Parameters.AddWithValue("@Odano", odano.Text);
                bosOda.Parameters.AddWithValue("@HastaId", "Hasta Bulunmuyor");//Burası patlarr test et
                bosOda.Parameters.AddWithValue("@Durumu", "Boş");
                bosOda.Parameters.AddWithValue("@Odakat", odakat.Text);
                YatakBilgiKaydet(button, snf3);
                teslim = new YatakTeslim(button.Name, snf3);
                this.Close();
                teslim.ShowDialog();
            }
            ContextMenuStrip contextMenu = button.ContextMenuStrip;
            baglanti.Close();
        }
    }
}
