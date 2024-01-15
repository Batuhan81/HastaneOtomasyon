namespace Hastane_Otomasyon
{
    partial class Odalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odalar));
            this.PanelOdalar = new System.Windows.Forms.FlowLayoutPanel();
            this.comboKat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKatSil = new System.Windows.Forms.Button();
            this.btnKatEkle = new System.Windows.Forms.Button();
            this.OdaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelOdalar
            // 
            this.PanelOdalar.Location = new System.Drawing.Point(-3, 0);
            this.PanelOdalar.Name = "PanelOdalar";
            this.PanelOdalar.Size = new System.Drawing.Size(1402, 894);
            this.PanelOdalar.TabIndex = 0;
            // 
            // comboKat
            // 
            this.comboKat.FormattingEnabled = true;
            this.comboKat.Location = new System.Drawing.Point(1660, 293);
            this.comboKat.Name = "comboKat";
            this.comboKat.Size = new System.Drawing.Size(138, 24);
            this.comboKat.TabIndex = 2;
            this.comboKat.SelectedIndexChanged += new System.EventHandler(this.comboKat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1434, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listelenecek Kat =>";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ekle2.png");
            this.ımageList1.Images.SetKeyName(1, "Sil butonu.png");
            // 
            // btnKatSil
            // 
            this.btnKatSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKatSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatSil.ImageIndex = 1;
            this.btnKatSil.ImageList = this.ımageList1;
            this.btnKatSil.Location = new System.Drawing.Point(1630, 120);
            this.btnKatSil.Name = "btnKatSil";
            this.btnKatSil.Size = new System.Drawing.Size(197, 82);
            this.btnKatSil.TabIndex = 26;
            this.btnKatSil.Text = " Kat Sil";
            this.btnKatSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKatSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKatSil.UseVisualStyleBackColor = true;
            this.btnKatSil.Click += new System.EventHandler(this.btnKatSil_Click);
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKatEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKatEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatEkle.ImageIndex = 0;
            this.btnKatEkle.ImageList = this.ımageList1;
            this.btnKatEkle.Location = new System.Drawing.Point(1417, 120);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(197, 82);
            this.btnKatEkle.TabIndex = 25;
            this.btnKatEkle.Text = " Kat Ekle";
            this.btnKatEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKatEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKatEkle.UseVisualStyleBackColor = false;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // OdaEkle
            // 
            this.OdaEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OdaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaEkle.ImageIndex = 0;
            this.OdaEkle.ImageList = this.ımageList1;
            this.OdaEkle.Location = new System.Drawing.Point(1520, 32);
            this.OdaEkle.Name = "OdaEkle";
            this.OdaEkle.Size = new System.Drawing.Size(197, 82);
            this.OdaEkle.TabIndex = 24;
            this.OdaEkle.Text = " Oda Ekle";
            this.OdaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OdaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OdaEkle.UseVisualStyleBackColor = true;
            this.OdaEkle.Click += new System.EventHandler(this.OdaEkle_Click);
            // 
            // Odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 892);
            this.Controls.Add(this.btnKatSil);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.OdaEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboKat);
            this.Controls.Add(this.PanelOdalar);
            this.Name = "Odalar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Odaları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Odalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelOdalar;
        private System.Windows.Forms.ComboBox comboKat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnKatSil;
        private System.Windows.Forms.Button btnKatEkle;
        private System.Windows.Forms.Button OdaEkle;
    }
}