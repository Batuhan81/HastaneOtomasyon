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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        int sonButonID;
        String secilenkat = 1.ToString();
        List<Button> addedButtons = new List<Button>();
        katbilgisi mtd = new katbilgisi();
        private void OdaEkle_Click(object sender, EventArgs e)
        {
            mtd.SeciliKat = comboKat.SelectedItem.ToString();
            OdaEkle odabilgileri = new OdaEkle(mtd);
            odabilgileri.ShowDialog();
            baglanti.Open();
            //Oda Tablosundaki en yüksek Idyi al
            SqlCommand maxodaIDKomut = new SqlCommand("SELECT ISNULL(MAX(OdaID), 0) FROM Oda", baglanti);
            sonButonID = (int)maxodaIDKomut.ExecuteScalar();
            baglanti.Close();
            int yeniodaId = sonButonID;

            Button btn=new Button();
            btn.Text=sonButonID.ToString();
            btn.Name=sonButonID.ToString();
            btn.Size = new Size(150, 150);
            RenkDegistir(btn);
            btn.Click += Yonlendir;
            btn.ContextMenuStrip = OdaButtonClick();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update Oda set Odakatı=@Odakatı where OdaID=@OdaID", baglanti);
            komut2.Parameters.AddWithValue("@Odakatı", secilenkat);
            komut2.Parameters.AddWithValue("@OdaID", yeniodaId);
            komut2.ExecuteNonQuery();

            addedButtons.Add(btn);
            PanelOdalar.Controls.Add(btn);
            sonButonID = yeniodaId;//burada enson eklediğimiz odayı son butonIdsine veriyoruz. }
            baglanti.Close();
        }
        public void Yonlendir(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Sınıf1 snf1=new Sınıf1 ();
            Sınıf2 snf2 = new Sınıf2();
            OdaBGetir getir=new OdaBGetir(snf1,snf2);
            baglanti.Open ();
            SqlCommand durumsorgusu = new SqlCommand("SELECT Odadurumu FROM Oda WHERE OdaID=@OdaID", baglanti);
            durumsorgusu.Parameters.AddWithValue("@OdaID",button.Name.ToString());
            object durumsorgusuObj=durumsorgusu.ExecuteScalar();
            if(durumsorgusuObj != null )
            {
                string odaDurumu = durumsorgusuObj.ToString();
                switch(durumsorgusuObj)
                {
                    case "Dolu":
                        OdabilgiKaydet(button, snf2);

                        SqlCommand hastaSorgusu = new SqlCommand("SELECT *FROM HastaBilgileri WHERE OdaID=@OdaID AND Durumu=@Durumu", baglanti);
                        hastaSorgusu.Parameters.AddWithValue("OdaID", button.Name.ToString());
                        hastaSorgusu.Parameters.AddWithValue("Durumu", "Kalıyor");
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
                            getir = new OdaBGetir(snf1, snf2);
                            getir.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Okuma İşlemi Yapılamıyor","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        ; break;
                    case "Boş":
                        
                        OdaTeslim teslim= new OdaTeslim(button.Name, snf2);
                        OdabilgiKaydet(button, snf2);
                        teslim = new OdaTeslim(button.Name, snf2);
                        teslim.ShowDialog();
                        break;
                    case "Servis Dışı":

                        OdaTeslim teslim2 = new OdaTeslim(button.Name, snf2);
                        OdabilgiKaydet(button, snf2);
                        teslim2 = new OdaTeslim(button.Name, snf2);
                        teslim2.ShowDialog();
                        break;
                    case "Rezerve":

                        OdaTeslim teslim3 = new OdaTeslim(button.Name, snf2);
                        OdabilgiKaydet(button, snf2);
                        SqlCommand hastaSorgusu2 = new SqlCommand("SELECT *FROM HastaBilgileri WHERE OdaID=@OdaID AND Durumu=@Durumu", baglanti);
                        hastaSorgusu2.Parameters.AddWithValue("OdaID", button.Name.ToString());
                        hastaSorgusu2.Parameters.AddWithValue("Durumu", "Gelecek");
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
                            getir = new OdaBGetir(snf1, snf2);
                            getir.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Okuma İşlemi Yapılamıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        teslim3 = new OdaTeslim(button.Name, snf2);

                        teslim3.ShowDialog();
                    break;
                }
            }
            else
            {
                OdaTeslim teslim3 = new OdaTeslim(button.Name, snf2);
                OdabilgiKaydet(button, snf2);
                teslim3 = new OdaTeslim(button.Name, snf2);
                teslim3.ShowDialog();
            }
            ContextMenuStrip contextMenu = button.ContextMenuStrip;
            baglanti.Close();
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
            SqlCommand silkomut = new SqlCommand("delete  From Oda Where OdaID=@OdaID ", baglanti);
            silkomut.Parameters.AddWithValue("@OdaID", secilenOda);
            silkomut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand silindi = new SqlCommand("update  Oda set Odadurumu='Silindi' where OdaID=@OdaID", baglanti);
            silindi.Parameters.AddWithValue("@OdaID", secilenOda);
            silindi.ExecuteNonQuery();
            baglanti.Close();

            PanelOdalar.Controls.Remove(secilenButon);
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            this.Close();
        }
        private void Guncelle_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button secilenButon = (Button)contextMenu.SourceControl;
            string odaAdi = secilenButon.Name;
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oda where odaID=@odaID", baglanti);
            komut.Parameters.AddWithValue("@odaID", odaAdi);
            komut.ExecuteNonQuery();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                string yataks = reader["Yataks"].ToString();
                string odakat = reader["Odakatı"].ToString();
                string durumu = reader["Odadurumu"].ToString();
                baglanti.Close();

                ObilgileriGüncelle güncelle = new ObilgileriGüncelle();
                güncelle.Verileriaktar(odaAdi, yataks, odakat, durumu);
                this.Close();
                güncelle.ShowDialog();
            }
        }
        public void OdabilgiKaydet(Button button, Sınıf2 snf2)
        {
            SqlCommand Odabilgisi = new SqlCommand("SELECT * FROM Oda WHERE OdaID=@OdaID", baglanti);
            Odabilgisi.Parameters.AddWithValue("@odaID", button.Name.ToString());
            SqlDataReader odaReader = Odabilgisi.ExecuteReader();
            if (odaReader.Read())
            {
                snf2.OdaID = odaReader["OdaID"].ToString();
                snf2.Odadurumu = odaReader["Odadurumu"].ToString();
                snf2.Odakatı = odaReader["Odakatı"].ToString();
                snf2.Yataks = odaReader["Yataks"].ToString();
            }
            odaReader.Close();
        }

        public void RenkDegistir(Button btn)//Odaların rengini değiştirme
        {
            baglanti.Open();
            SqlCommand durumsorgula = new SqlCommand("SELECT Odadurumu FROM Oda WHERE OdaID=@OdaID", baglanti);
            durumsorgula.Parameters.AddWithValue("@OdaID", btn.Name);
            object odadurumuObj= durumsorgula.ExecuteScalar();
            if( odadurumuObj != null )
            {
                string odaDurumu = odadurumuObj.ToString();
                switch ( odaDurumu )
                {
                    case "Boş": btn.BackColor = Color.Green;break;
                    case "Dolu": btn.BackColor = Color.Red; break;
                    case "Rezerve": btn.BackColor = Color.Yellow; break;
                    case "Servis Dışı": btn.BackColor = Color.Gray; break;
                        default: btn.BackColor = Color.Green;break;
                }
            }
            else
            {
                btn.BackColor = Color.Green;
            }
            baglanti.Close();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            ComboKatı_Doldur();
           if (comboKat.Items.Count != 0)
           {
                comboKat.SelectedIndex = 0;//Birinci katın seçili olarak gelmesini sağlıyorum
           }
        }
        public void ComboKatı_Doldur()
        {
            //combokat a Eklenen Katları yerleştiriyor
            comboKat.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select katID From OdaKat", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboKat.Items.Add(reader["KatID"].ToString());
            }
            reader.Close();
            baglanti.Close();
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //İdentity özelliğiyle Kat ekledik ve otomatikmen kimlik oluşturuyor
            SqlCommand komut = new SqlCommand("INSERT INTO OdaKat (Odasayisi) VALUES ('1'); SELECT SCOPE_IDENTITY();", baglanti);
            int yeniKatId = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            ComboKatı_Doldur();
            MessageBox.Show("Kat Ekleme İşlemi Başarılı");
        }
        int odaID = 0;
        private void comboKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKat.SelectedItem != null)
            {
                secilenkat = comboKat.SelectedItem.ToString();
                PanelOdalar.Controls.Clear();
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;"))
                {
                    baglanti.Open();
                    SqlCommand odakomut = new SqlCommand("select OdaID from Oda Where Odakatı=@Odakatı", baglanti);
                    odakomut.Parameters.AddWithValue("@Odakatı", secilenkat);
                    List<int> Odalistesi = new List<int>();
                    using (SqlDataReader Odaıdoku = odakomut.ExecuteReader())
                    {
                        while (Odaıdoku.Read())
                        {
                            odaID = Odaıdoku.GetInt32(0);
                            Odalistesi.Add(odaID);
                            // Odaıdoku nesnesini burada kullanabilirsiniz
                        }
                        Odaıdoku.Close();
                        foreach (int odaID in Odalistesi)
                        {
                            SqlCommand odakomut2 = new SqlCommand("select * from Oda where OdaID=@OdaID", baglanti);
                            odakomut2.Parameters.AddWithValue("@OdaID", odaID);
                            using (SqlDataReader odaReader = odakomut2.ExecuteReader())
                            {
                                while (odaReader.Read())
                                {
                                    Button btn = new Button();
                                    int btnAdi = odaReader.GetInt32(0);
                                    btn.Text = btnAdi.ToString();
                                    btn.Name = btnAdi.ToString();
                                    btn.Size = new Size(150, 150);
                                    RenkDegistir(btn);
                                    btn.Click += Yonlendir;
                                    PanelOdalar.Controls.Add(btn);
                                    btn.ContextMenuStrip = OdaButtonClick();//sağtıklanabilirlik özelliği
                                }
                                odaReader.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btnKatSil_Click(object sender, EventArgs e)
        {
            //Seçili katı siliyor
            if (comboKat.SelectedItem != null)
            {
                string secilenKat = comboKat.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Seçilen Katı Silmek İstediğinize Emin Misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Katı silme İşlemi
                    baglanti.Open();
                    SqlCommand katsilme = new SqlCommand("DELETE from OdaKat where KatID=@KatID", baglanti);
                    katsilme.Parameters.AddWithValue("KatID", secilenKat);
                    katsilme.ExecuteNonQuery();

                    baglanti.Close();

                    //ComboBox ı güncelleme İşlemi
                    comboKat.SelectedIndex = 0;
                    ComboKatı_Doldur();
                    MessageBox.Show("Kat ve Onunla İlişkili Odalar Silindi");
                }
                else
                {
                    MessageBox.Show("Lütfen Önce Silinecek Odayı Seçin");
                }
                comboKat.Text = "";
            }
        }
    }
}