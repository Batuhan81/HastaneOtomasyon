﻿namespace Hastane_Otomasyon
{
    partial class YatakTeslim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YatakTeslim));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ekran = new System.Windows.Forms.DataGridView();
            this.HastaID = new System.Windows.Forms.TextBox();
            this.Cinsiyet = new System.Windows.Forms.ComboBox();
            this.Dtarihi = new System.Windows.Forms.DateTimePicker();
            this.refsayisi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Tc = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Kan = new System.Windows.Forms.ComboBox();
            this.Adres = new ÖzelMetin_Kutucuğu.UserControl1();
            this.Ad = new ÖzelMetin_Kutucuğu.UserControl1();
            this.Soyad = new ÖzelMetin_Kutucuğu.UserControl1();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.YatisT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.yatakno = new System.Windows.Forms.TextBox();
            this.Odakat = new System.Windows.Forms.TextBox();
            this.Odano = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnrezerve = new System.Windows.Forms.Button();
            this.btnYatakteslim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Sikayeti = new System.Windows.Forms.TextBox();
            this.reztarih = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ekran);
            this.groupBox1.Controls.Add(this.HastaID);
            this.groupBox1.Controls.Add(this.Cinsiyet);
            this.groupBox1.Controls.Add(this.Dtarihi);
            this.groupBox1.Controls.Add(this.refsayisi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Tc);
            this.groupBox1.Controls.Add(this.Tel);
            this.groupBox1.Controls.Add(this.Kan);
            this.groupBox1.Controls.Add(this.Adres);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.YatisT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(630, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // ekran
            // 
            this.ekran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ekran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ekran.Location = new System.Drawing.Point(305, 50);
            this.ekran.Name = "ekran";
            this.ekran.RowHeadersWidth = 51;
            this.ekran.RowTemplate.Height = 24;
            this.ekran.Size = new System.Drawing.Size(450, 238);
            this.ekran.TabIndex = 88;
            this.ekran.Visible = false;
            this.ekran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ekran_CellClick);
            // 
            // HastaID
            // 
            this.HastaID.Location = new System.Drawing.Point(239, -12);
            this.HastaID.Name = "HastaID";
            this.HastaID.Size = new System.Drawing.Size(168, 28);
            this.HastaID.TabIndex = 22;
            this.HastaID.Visible = false;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.FormattingEnabled = true;
            this.Cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.Cinsiyet.Location = new System.Drawing.Point(115, 190);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(168, 30);
            this.Cinsiyet.TabIndex = 21;
            // 
            // Dtarihi
            // 
            this.Dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtarihi.Location = new System.Drawing.Point(414, 101);
            this.Dtarihi.Name = "Dtarihi";
            this.Dtarihi.Size = new System.Drawing.Size(168, 28);
            this.Dtarihi.TabIndex = 19;
            // 
            // refsayisi
            // 
            this.refsayisi.Location = new System.Drawing.Point(414, 241);
            this.refsayisi.Name = "refsayisi";
            this.refsayisi.Size = new System.Drawing.Size(168, 28);
            this.refsayisi.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(306, 244);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = " Ref.Sayısı:";
            // 
            // Tc
            // 
            this.Tc.Location = new System.Drawing.Point(115, 50);
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(168, 28);
            this.Tc.TabIndex = 16;
            this.Tc.TextChanged += new System.EventHandler(this.Tc_TextChanged);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(115, 238);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(168, 28);
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
            this.Kan.Location = new System.Drawing.Point(414, 147);
            this.Kan.Name = "Kan";
            this.Kan.Size = new System.Drawing.Size(168, 30);
            this.Kan.TabIndex = 14;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(409, 55);
            this.Adres.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(170, 22);
            this.Adres.TabIndex = 13;
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(115, 94);
            this.Ad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(168, 30);
            this.Ad.TabIndex = 11;
            this.Ad.MouseEnter += new System.EventHandler(this.Ad_MouseEnter);
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(115, 142);
            this.Soyad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(168, 30);
            this.Soyad.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Yatış Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kan Grubu:";
            // 
            // YatisT
            // 
            this.YatisT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.YatisT.Location = new System.Drawing.Point(414, 195);
            this.YatisT.Name = "YatisT";
            this.YatisT.Size = new System.Drawing.Size(168, 28);
            this.YatisT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = " Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "D.Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = " TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = " Tel No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = " Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboDurum);
            this.groupBox2.Controls.Add(this.yatakno);
            this.groupBox2.Controls.Add(this.Odakat);
            this.groupBox2.Controls.Add(this.Odano);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(1297, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 327);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yatak Bilgileri";
            // 
            // comboDurum
            // 
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Location = new System.Drawing.Point(190, 208);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(168, 30);
            this.comboDurum.TabIndex = 17;
            // 
            // yatakno
            // 
            this.yatakno.Location = new System.Drawing.Point(190, 157);
            this.yatakno.Name = "yatakno";
            this.yatakno.Size = new System.Drawing.Size(168, 28);
            this.yatakno.TabIndex = 19;
            // 
            // Odakat
            // 
            this.Odakat.Location = new System.Drawing.Point(190, 106);
            this.Odakat.Name = "Odakat";
            this.Odakat.Size = new System.Drawing.Size(168, 28);
            this.Odakat.TabIndex = 18;
            // 
            // Odano
            // 
            this.Odano.Location = new System.Drawing.Point(190, 55);
            this.Odano.Name = "Odano";
            this.Odano.Size = new System.Drawing.Size(168, 28);
            this.Odano.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 213);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = " Yatak Durumu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = " Yatak No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = " Oda Kat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = " Oda No:";
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
            // btntemizle
            // 
            this.btntemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.ImageIndex = 3;
            this.btntemizle.ImageList = this.ımageList1;
            this.btntemizle.Location = new System.Drawing.Point(985, 413);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(181, 85);
            this.btntemizle.TabIndex = 80;
            this.btntemizle.Text = "     Temizle";
            this.btntemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnrezerve
            // 
            this.btnrezerve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrezerve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrezerve.ImageIndex = 1;
            this.btnrezerve.ImageList = this.ımageList1;
            this.btnrezerve.Location = new System.Drawing.Point(985, 505);
            this.btnrezerve.Name = "btnrezerve";
            this.btnrezerve.Size = new System.Drawing.Size(181, 85);
            this.btnrezerve.TabIndex = 79;
            this.btnrezerve.Text = "Yatağı Rezerve Et";
            this.btnrezerve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrezerve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrezerve.UseVisualStyleBackColor = true;
            this.btnrezerve.Click += new System.EventHandler(this.btnrezerve_Click);
            // 
            // btnYatakteslim
            // 
            this.btnYatakteslim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYatakteslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatakteslim.ImageIndex = 0;
            this.btnYatakteslim.ImageList = this.ımageList1;
            this.btnYatakteslim.Location = new System.Drawing.Point(797, 504);
            this.btnYatakteslim.Name = "btnYatakteslim";
            this.btnYatakteslim.Size = new System.Drawing.Size(181, 85);
            this.btnYatakteslim.TabIndex = 78;
            this.btnYatakteslim.Text = "        Yatağı Teslim Et";
            this.btnYatakteslim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYatakteslim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYatakteslim.UseVisualStyleBackColor = true;
            this.btnYatakteslim.Click += new System.EventHandler(this.btnYatakteslim_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(797, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 85);
            this.button2.TabIndex = 82;
            this.button2.Text = "Refakatçı Ekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(644, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(411, 22);
            this.label15.TabIndex = 83;
            this.label15.Text = "Refakatçı Eklenirken Hasta Sisteme Kayıt edilecek";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(859, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 22);
            this.label16.TabIndex = 84;
            this.label16.Text = "Şikayetleri";
            // 
            // Sikayeti
            // 
            this.Sikayeti.Location = new System.Drawing.Point(809, 134);
            this.Sikayeti.Name = "Sikayeti";
            this.Sikayeti.Size = new System.Drawing.Size(168, 28);
            this.Sikayeti.TabIndex = 19;
            // 
            // reztarih
            // 
            this.reztarih.Location = new System.Drawing.Point(767, 219);
            this.reztarih.Name = "reztarih";
            this.reztarih.Size = new System.Drawing.Size(237, 28);
            this.reztarih.TabIndex = 86;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(801, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 22);
            this.label18.TabIndex = 87;
            this.label18.Text = "Giriş Yapılacığı Tarih";
            // 
            // YatakTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 857);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.reztarih);
            this.Controls.Add(this.Sikayeti);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnrezerve);
            this.Controls.Add(this.btnYatakteslim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YatakTeslim";
            this.Text = "YatakTeslim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YatakTeslim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker YatisT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Kan;
        private ÖzelMetin_Kutucuğu.UserControl1 Adres;
        private ÖzelMetin_Kutucuğu.UserControl1 Ad;
        private ÖzelMetin_Kutucuğu.UserControl1 Soyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tc;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox yatakno;
        private System.Windows.Forms.TextBox Odakat;
        private System.Windows.Forms.TextBox Odano;
        private System.Windows.Forms.TextBox refsayisi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnrezerve;
        private System.Windows.Forms.Button btnYatakteslim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Sikayeti;
        private System.Windows.Forms.DateTimePicker Dtarihi;
        private System.Windows.Forms.DateTimePicker reztarih;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Cinsiyet;
        private System.Windows.Forms.DataGridView ekran;
        private System.Windows.Forms.TextBox HastaID;
    }
}