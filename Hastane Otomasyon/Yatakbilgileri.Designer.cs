namespace Hastane_Otomasyon
{
    partial class Yatakbilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yatakbilgileri));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Dtarihi = new System.Windows.Forms.DateTimePicker();
            this.refsayisi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Tc = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Kan = new System.Windows.Forms.ComboBox();
            this.Adres = new ÖzelMetin_Kutucuğu.UserControl1();
            this.Cinsiyet = new ÖzelMetin_Kutucuğu.UserControl1();
            this.Soyad = new ÖzelMetin_Kutucuğu.UserControl1();
            this.label9 = new System.Windows.Forms.Label();
            this.Ad = new ÖzelMetin_Kutucuğu.UserControl1();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.YatisT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.yatakno = new System.Windows.Forms.TextBox();
            this.Odakat = new System.Windows.Forms.TextBox();
            this.Odano = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hastadurumu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.Sikayeti = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Oda Teslim.png");
            this.ımageList1.Images.SetKeyName(1, "Rezervasyonlar.png");
            this.ımageList1.Images.SetKeyName(2, "Müşteri Ekle4.png");
            this.ımageList1.Images.SetKeyName(3, "temizle.png");
            this.ımageList1.Images.SetKeyName(4, "ref ekle.png");
            // 
            // Dtarihi
            // 
            this.Dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtarihi.Location = new System.Drawing.Point(414, 100);
            this.Dtarihi.Name = "Dtarihi";
            this.Dtarihi.Size = new System.Drawing.Size(168, 22);
            this.Dtarihi.TabIndex = 19;
            // 
            // refsayisi
            // 
            this.refsayisi.Location = new System.Drawing.Point(414, 237);
            this.refsayisi.Name = "refsayisi";
            this.refsayisi.Size = new System.Drawing.Size(168, 22);
            this.refsayisi.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(315, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = " Ref.Sayısı:";
            // 
            // Tc
            // 
            this.Tc.Location = new System.Drawing.Point(414, 55);
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(168, 22);
            this.Tc.TabIndex = 16;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(115, 202);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(168, 22);
            this.Tel.TabIndex = 15;
            // 
            // Kan
            // 
            this.Kan.FormattingEnabled = true;
            this.Kan.Items.AddRange(new object[] {
            "A-",
            "A+",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.Kan.Location = new System.Drawing.Point(414, 145);
            this.Kan.Name = "Kan";
            this.Kan.Size = new System.Drawing.Size(168, 24);
            this.Kan.TabIndex = 14;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(115, 241);
            this.Adres.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(170, 22);
            this.Adres.TabIndex = 13;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Location = new System.Drawing.Point(115, 144);
            this.Cinsiyet.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(170, 41);
            this.Cinsiyet.TabIndex = 12;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(115, 97);
            this.Soyad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(168, 30);
            this.Soyad.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(312, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Yatış Tarihi:";
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(115, 50);
            this.Ad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(168, 30);
            this.Ad.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(98, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = " Oda Kat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(317, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kan Grubu:";
            // 
            // YatisT
            // 
            this.YatisT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.YatisT.Location = new System.Drawing.Point(414, 192);
            this.YatisT.Name = "YatisT";
            this.YatisT.Size = new System.Drawing.Size(168, 22);
            this.YatisT.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(335, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "D.Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(358, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = " TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = " Adres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(99, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = " Oda No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = " Tel No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = " Cinsiyet:";
            // 
            // comboDurum
            // 
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Location = new System.Drawing.Point(190, 208);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(168, 24);
            this.comboDurum.TabIndex = 17;
            // 
            // yatakno
            // 
            this.yatakno.Location = new System.Drawing.Point(190, 157);
            this.yatakno.Name = "yatakno";
            this.yatakno.Size = new System.Drawing.Size(168, 22);
            this.yatakno.TabIndex = 19;
            // 
            // Odakat
            // 
            this.Odakat.Location = new System.Drawing.Point(190, 106);
            this.Odakat.Name = "Odakat";
            this.Odakat.Size = new System.Drawing.Size(168, 22);
            this.Odakat.TabIndex = 18;
            // 
            // Odano
            // 
            this.Odano.Location = new System.Drawing.Point(190, 55);
            this.Odano.Name = "Odano";
            this.Odano.Size = new System.Drawing.Size(168, 22);
            this.Odano.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(62, 216);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = " Yatak Durumu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDurum);
            this.groupBox2.Controls.Add(this.yatakno);
            this.groupBox2.Controls.Add(this.Odakat);
            this.groupBox2.Controls.Add(this.Odano);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1575, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 327);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yatak Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(90, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = " Yatak No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hastadurumu);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Dtarihi);
            this.groupBox1.Controls.Add(this.refsayisi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Tc);
            this.groupBox1.Controls.Add(this.Tel);
            this.groupBox1.Controls.Add(this.Kan);
            this.groupBox1.Controls.Add(this.Adres);
            this.groupBox1.Controls.Add(this.Cinsiyet);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.YatisT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(698, 327);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // Hastadurumu
            // 
            this.Hastadurumu.Location = new System.Drawing.Point(414, 282);
            this.Hastadurumu.Name = "Hastadurumu";
            this.Hastadurumu.Size = new System.Drawing.Size(168, 22);
            this.Hastadurumu.TabIndex = 21;
            this.Hastadurumu.Text = " ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(333, 278);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Durumu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(798, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 81);
            this.button1.TabIndex = 96;
            this.button1.Text = "Taburcu Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1014, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 81);
            this.button2.TabIndex = 97;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1218, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 81);
            this.button3.TabIndex = 98;
            this.button3.Text = "Refakatçı Bilgileri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(1014, 496);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 81);
            this.button6.TabIndex = 101;
            this.button6.Text = "Ameliyat Listesine Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Sikayeti
            // 
            this.Sikayeti.Location = new System.Drawing.Point(1025, 161);
            this.Sikayeti.Name = "Sikayeti";
            this.Sikayeti.Size = new System.Drawing.Size(168, 22);
            this.Sikayeti.TabIndex = 88;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1075, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 94;
            this.label16.Text = "Şikayetleri";
            // 
            // Yatakbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Sikayeti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Yatakbilgileri";
            this.ShowIcon = false;
            this.Text = "Yatakbilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yatakbilgileri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DateTimePicker Dtarihi;
        private System.Windows.Forms.TextBox refsayisi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Tc;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.ComboBox Kan;
        private ÖzelMetin_Kutucuğu.UserControl1 Adres;
        private ÖzelMetin_Kutucuğu.UserControl1 Cinsiyet;
        private ÖzelMetin_Kutucuğu.UserControl1 Soyad;
        private System.Windows.Forms.Label label9;
        private ÖzelMetin_Kutucuğu.UserControl1 Ad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker YatisT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.TextBox yatakno;
        private System.Windows.Forms.TextBox Odakat;
        private System.Windows.Forms.TextBox Odano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Hastadurumu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Sikayeti;
        private System.Windows.Forms.Label label16;
    }
}