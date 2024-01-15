namespace Hastane_Otomasyon
{
    partial class AmeliyatBilgiGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmeliyatBilgiGüncelle));
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btngüncelle = new System.Windows.Forms.Button();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.odakatı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.odano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(88, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 67);
            this.button1.TabIndex = 61;
            this.button1.Text = "   İptal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            this.ımageList1.Images.SetKeyName(1, "Yenile İkonu2.png");
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ImageIndex = 1;
            this.btngüncelle.ImageList = this.ımageList1;
            this.btngüncelle.Location = new System.Drawing.Point(88, 211);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(161, 67);
            this.btngüncelle.TabIndex = 60;
            this.btngüncelle.Text = " Güncelle";
            this.btngüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // comboDurum
            // 
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Items.AddRange(new object[] {
            "Boş",
            "Dolu",
            "Rezerve",
            "Servis Dışı"});
            this.comboDurum.Location = new System.Drawing.Point(185, 171);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(152, 24);
            this.comboDurum.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(94, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Durumu:";
            // 
            // odakatı
            // 
            this.odakatı.Location = new System.Drawing.Point(185, 102);
            this.odakatı.Name = "odakatı";
            this.odakatı.Size = new System.Drawing.Size(152, 22);
            this.odakatı.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ameliyathane katı:";
            // 
            // odano
            // 
            this.odano.Location = new System.Drawing.Point(185, 33);
            this.odano.Name = "odano";
            this.odano.Size = new System.Drawing.Size(152, 22);
            this.odano.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ameliyathane:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // AmeliyatBilgiGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odakatı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odano);
            this.Controls.Add(this.label1);
            this.Name = "AmeliyatBilgiGüncelle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ameliyathane Bilgisini Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox odakatı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox odano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
    }
}