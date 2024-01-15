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
    public partial class Ameliyathane : Form
    {
        public Ameliyathane()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        int sonButonID;
        String secilenkat = 1.ToString();
        List<Button> addedButtons = new List<Button>();
        katbilgisi mtd = new katbilgisi();

        private void Ameliyathaneekle_Click(object sender, EventArgs e)
        {
            mtd.SeciliKat = comboKat.SelectedItem.ToString();
            baglanti.Open();//İdentity sayesinde otomatik oluşacak
            SqlCommand ekle = new SqlCommand("insert into Ameliyathane(Durumu,Kat)Values(@Durumu,@Kat)", baglanti);
            ekle.Parameters.AddWithValue("@Durumu", "Boş");
            ekle.Parameters.AddWithValue("@Kat", mtd.SeciliKat);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();

            //Oda Tablosundaki en yüksek Idyi al
            SqlCommand maxAmeliyatID = new SqlCommand("SELECT ISNULL(MAX(AmeliyatID), 0) FROM Ameliyathane", baglanti);
            sonButonID = (int)maxAmeliyatID.ExecuteScalar();
            baglanti.Close();
            int yeniodaId = sonButonID;

            Button btn = new Button();
            btn.Text = sonButonID.ToString();
            btn.Name = sonButonID.ToString();
            btn.Size = new Size(150, 150);
            RenkDegistir(btn);
            btn.Click += Yonlendir;
            btn.ContextMenuStrip = OdaButtonClick();

            //Gereklimi bilmiyorum
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update Ameliyathane set Kat=@Kat where AmeliyatID=@AmeliyatID", baglanti);
            komut2.Parameters.AddWithValue("@Kat", secilenkat);
            komut2.Parameters.AddWithValue("@AmeliyatID", yeniodaId);
            komut2.ExecuteNonQuery();

            addedButtons.Add(btn);
            PanelOdalar.Controls.Add(btn);
            sonButonID = yeniodaId;//burada enson eklediğimiz odayı son butonIdsine veriyoruz. }
            baglanti.Close();
        }
        public void RenkDegistir(Button btn)//Odaların rengini değiştirme
        {
            baglanti.Open();
            SqlCommand durumsorgula = new SqlCommand("SELECT Durumu FROM Ameliyathane WHERE AmeliyatID=@AmeliyatID", baglanti);
            durumsorgula.Parameters.AddWithValue("@AmeliyatID", btn.Name);
            object odadurumuObj = durumsorgula.ExecuteScalar();
            if (odadurumuObj != null)
            {
                string odaDurumu = odadurumuObj.ToString();
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
        public void Yonlendir(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Sınıf1 snf1 = new Sınıf1();
            Sınıf3 snf3 = new Sınıf3();
            CalısanB clsn=new CalısanB();
            AmeliyathaneBilgi getir = new AmeliyathaneBilgi(snf1, snf3, clsn);
            baglanti.Open();
            SqlCommand durumsorgusu = new SqlCommand("SELECT Durumu FROM Ameliyathane WHERE AmeliyatID=@AmeliyatID", baglanti);
            durumsorgusu.Parameters.AddWithValue("@AmeliyatID", button.Name.ToString());

            object durumsorgusuObj = durumsorgusu.ExecuteScalar();
            if (durumsorgusuObj != null)
            {
                string odaDurumu = durumsorgusuObj.ToString();
                switch (durumsorgusuObj)
                {
                    case "Dolu":
                        YatakBilgiKaydet(button, snf3);

                        SqlCommand hastaSorgusu = new SqlCommand("SELECT * FROM HastaBilgileri WHERE Ameliyathane=@Ameliyathane AND Durumu=@Durumu", baglanti);
                        hastaSorgusu.Parameters.AddWithValue("@Ameliyathane", button.Name.ToString());
                        hastaSorgusu.Parameters.AddWithValue("Durumu", "Ameliyatta");
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
                            snf1.YatakID = Reader["YatakID"].ToString() ;
                            snf1.AmeliyatID = button.Name.ToString();
                            getir = new AmeliyathaneBilgi(snf1, snf3,clsn);//Ameliyat
                        }
                        else
                        {
                            MessageBox.Show(" Hasta Bilgileri Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Reader.Close();
                        SqlCommand doktorSorgusu = new SqlCommand("SELECT * FROM CalısanBilgileri WHERE Ameliyathane=@Ameliyathane AND Durumu=@Durumu", baglanti);
                        doktorSorgusu.Parameters.AddWithValue("@Ameliyathane", button.Name.ToString());
                        doktorSorgusu.Parameters.AddWithValue("Durumu", "Ameliyatta");
                        SqlDataReader Reader2 = doktorSorgusu.ExecuteReader();
                        if (Reader2.Read())
                        {
                            clsn.Ad = Reader2["Ad"].ToString();
                            clsn.Soyad = Reader2["Soyad"].ToString();
                            clsn.Tc = Reader2["Tc"].ToString();
                            clsn.Cinsiyet = Reader2["Cinsiyet"].ToString();
                            clsn.Tel = Reader2["Tel"].ToString();
                            clsn.CalısanID = Reader2["CalısanID"].ToString();
                            clsn.Durumu = Reader2["Durumu"].ToString();
                            clsn.Departman = Reader2["Departman"].ToString();
                            getir = new AmeliyathaneBilgi(snf1, snf3,clsn);//Ameliyat
                        }
                        Reader2.Close();
                        this.Close();
                        getir.ShowDialog();
                        Ameliyathane git3 = new Ameliyathane();
                        git3.ShowDialog();
                        ; break;
                    case "Boş":

                        AmeliyatTeslim teslim = new AmeliyatTeslim(button.Name, snf3);
                        YatakBilgiKaydet(button, snf3);
                        teslim = new AmeliyatTeslim(button.Name, snf3);
                        this.Close();
                        teslim.ShowDialog();
                        Ameliyathane git = new Ameliyathane();
                        git.ShowDialog();
                        break;
                    case "Servis Dışı":

                        AmeliyatTeslim teslim2 = new AmeliyatTeslim(button.Name, snf3);
                        YatakBilgiKaydet(button, snf3);
                        teslim = new AmeliyatTeslim(button.Name, snf3);
                        this.Close();
                        teslim.ShowDialog();
                        Ameliyathane git2 = new Ameliyathane();
                        git2.ShowDialog();
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
                //bosOda.Parameters.AddWithValue("@Odano", odano.Text);
                bosOda.Parameters.AddWithValue("@HastaId", "Hasta Bulunmuyor");//Burası patlarr test et
                bosOda.Parameters.AddWithValue("@Durumu", "Boş");
                //bosOda.Parameters.AddWithValue("@Odakat", odakat.Text);
                YatakBilgiKaydet(button, snf3);
                teslim = new YatakTeslim(button.Name, snf3);
                this.Close();
                teslim.ShowDialog();
            }
            ContextMenuStrip contextMenu = button.ContextMenuStrip;
            baglanti.Close();
        }
        public void YatakBilgiKaydet(Button button, Sınıf3 snf3)
        {
            SqlCommand Odabilgisi = new SqlCommand("SELECT * FROM Yatak Where YatakID=@YatakID ", baglanti);
            Odabilgisi.Parameters.AddWithValue("@YatakID", button.Name);
            SqlDataReader odaReader = Odabilgisi.ExecuteReader();
            if (odaReader.Read())
            {
                snf3.YatakID = odaReader["YatakID"].ToString();
                snf3.Odano = odaReader["OdaID"].ToString();
                snf3.HastaID = odaReader["HastaID"].ToString();
                snf3.Durumu = odaReader["Durumu"].ToString();
                snf3.Odakat = odaReader["Odakat"].ToString();
            }
            odaReader.Close();
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
        private void sil_Click(object sender, EventArgs e)//Buraya Bakılacak
        {
            //Butona Sağ tıklayarak açılan menüden butonu silme
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button secilenButon = (Button)contextMenu.SourceControl;
            string secilenOda = secilenButon.Name;

            baglanti.Open();
            SqlCommand silkomut = new SqlCommand("delete  From Ameliyathane Where AmeliyatID=@AmeliyatID ", baglanti);
            silkomut.Parameters.AddWithValue("@AmeliyatID", secilenOda);
            silkomut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand silindi = new SqlCommand("update  Ameliyathane set Durumu='Silindi' where AmeliyatID=@AmeliyatID", baglanti);
            silindi.Parameters.AddWithValue("@AmeliyatID", secilenOda);
            silindi.ExecuteNonQuery();
            baglanti.Close();

            PanelOdalar.Controls.Remove(secilenButon);
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            this.Close();
        }
        private void Guncelle_Click(object sender, EventArgs e)//Buraya Bakılacak
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button secilenButon = (Button)contextMenu.SourceControl;
            string Ameliyatadı = secilenButon.Name;
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ameliyathane where AmeliyatID=@AmeliyatID", baglanti);
            komut.Parameters.AddWithValue("@AmeliyatID", Ameliyatadı);
            komut.ExecuteNonQuery();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                
                string Ameliyatkat = reader["Kat"].ToString();
                string durumu = reader["Durumu"].ToString();
                baglanti.Close();

                AmeliyatBilgiGüncelle güncelle = new AmeliyatBilgiGüncelle();
                güncelle.Verileriaktar(Ameliyatadı, Ameliyatkat, durumu);
                this.Close();
                güncelle.ShowDialog();
            }
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //İdentity özelliğiyle Kat ekledik ve otomatikmen kimlik oluşturuyor
            SqlCommand komut = new SqlCommand("INSERT INTO AmeliyatKat (YeniKat) VALUES ('1'); SELECT SCOPE_IDENTITY();", baglanti);
            int yeniKatId = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            ComboKatı_Doldur();
            MessageBox.Show("Kat Ekleme İşlemi Başarılı");
        }
        public void ComboKatı_Doldur()
        {
            //combokat a Eklenen Katları yerleştiriyor
            comboKat.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KatID From AmeliyatKat", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboKat.Items.Add(reader["KatID"].ToString());
            }
            reader.Close();
            baglanti.Close();
            comboKat.SelectedIndex = 0;
        }

        private void btnKatSil_Click_1(object sender, EventArgs e)
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
                    SqlCommand katsilme = new SqlCommand("DELETE from AmeliyatKat where KatID=@KatID", baglanti);
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

        private void Ameliyathane_Load(object sender, EventArgs e)
        {
            ComboKatı_Doldur();
        }
        int ameliyatID = 0;
        private void comboKat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboKat.SelectedItem != null)
            {
                secilenkat = comboKat.SelectedItem.ToString();
                PanelOdalar.Controls.Clear();
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;"))
                {
                    baglanti.Open();
                    SqlCommand odakomut = new SqlCommand("select AmeliyatID from Ameliyathane Where Kat=@Kat", baglanti);
                    odakomut.Parameters.AddWithValue("@Kat", secilenkat);
                    List<int> Odalistesi = new List<int>();
                    using (SqlDataReader Odaıdoku = odakomut.ExecuteReader())
                    {
                        while (Odaıdoku.Read())
                        {
                            ameliyatID = Odaıdoku.GetInt32(0);
                            Odalistesi.Add(ameliyatID);
                            // Odaıdoku nesnesini burada kullanabilirsiniz
                        }
                        Odaıdoku.Close();
                        foreach (int ameliyatID in Odalistesi)
                        {
                            SqlCommand odakomut2 = new SqlCommand("select * from Ameliyathane where AmeliyatID=@AmeliyatID", baglanti);
                            odakomut2.Parameters.AddWithValue("@AmeliyatID", ameliyatID);
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
    }
}
