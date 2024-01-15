namespace Hastane_Otomasyon
{
    partial class YatakbilgiGüncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.Güncelle = new System.Windows.Forms.Button();
            this.txtyatakID = new System.Windows.Forms.TextBox();
            this.txtodaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaID = new System.Windows.Forms.TextBox();
            this.txtDurumu = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.hstTc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " YatakID";
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(120, 337);
            this.Güncelle.Margin = new System.Windows.Forms.Padding(4);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(103, 29);
            this.Güncelle.TabIndex = 1;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // txtyatakID
            // 
            this.txtyatakID.Location = new System.Drawing.Point(170, 52);
            this.txtyatakID.Margin = new System.Windows.Forms.Padding(4);
            this.txtyatakID.Name = "txtyatakID";
            this.txtyatakID.Size = new System.Drawing.Size(136, 27);
            this.txtyatakID.TabIndex = 2;
            // 
            // txtodaID
            // 
            this.txtodaID.Location = new System.Drawing.Point(170, 104);
            this.txtodaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtodaID.Name = "txtodaID";
            this.txtodaID.Size = new System.Drawing.Size(136, 27);
            this.txtodaID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "OdaID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durumu";
            // 
            // txtkat
            // 
            this.txtkat.Location = new System.Drawing.Point(170, 223);
            this.txtkat.Margin = new System.Windows.Forms.Padding(4);
            this.txtkat.Name = "txtkat";
            this.txtkat.Size = new System.Drawing.Size(136, 27);
            this.txtkat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odakat";
            // 
            // hastaID
            // 
            this.hastaID.Location = new System.Drawing.Point(170, 320);
            this.hastaID.Margin = new System.Windows.Forms.Padding(4);
            this.hastaID.Name = "hastaID";
            this.hastaID.Size = new System.Drawing.Size(136, 27);
            this.hastaID.TabIndex = 11;
            this.hastaID.Visible = false;
            // 
            // txtDurumu
            // 
            this.txtDurumu.FormattingEnabled = true;
            this.txtDurumu.Items.AddRange(new object[] {
            "Boş",
            "Dolu",
            "Rezerve",
            "Servis Dışı"});
            this.txtDurumu.Location = new System.Drawing.Point(170, 163);
            this.txtDurumu.Name = "txtDurumu";
            this.txtDurumu.Size = new System.Drawing.Size(136, 28);
            this.txtDurumu.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta Tc";
            // 
            // hstTc
            // 
            this.hstTc.Location = new System.Drawing.Point(170, 285);
            this.hstTc.Margin = new System.Windows.Forms.Padding(4);
            this.hstTc.Name = "hstTc";
            this.hstTc.Size = new System.Drawing.Size(136, 27);
            this.hstTc.TabIndex = 10;
            // 
            // YatakbilgiGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 462);
            this.Controls.Add(this.txtDurumu);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.hastaID);
            this.Controls.Add(this.hstTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtkat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtodaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyatakID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YatakbilgiGüncelle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yatak Bilgisini Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.TextBox txtyatakID;
        private System.Windows.Forms.TextBox txtodaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hastaID;
        private System.Windows.Forms.ComboBox txtDurumu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hstTc;
    }
}