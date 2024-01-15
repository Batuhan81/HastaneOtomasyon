namespace Hastane_Otomasyon
{
    partial class Ameliyathane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ameliyathane));
            this.label1 = new System.Windows.Forms.Label();
            this.comboKat = new System.Windows.Forms.ComboBox();
            this.PanelOdalar = new System.Windows.Forms.FlowLayoutPanel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKatSil = new System.Windows.Forms.Button();
            this.btnKatEkle = new System.Windows.Forms.Button();
            this.Ameliyathaneekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1493, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Listelenecek Kat =>";
            // 
            // comboKat
            // 
            this.comboKat.FormattingEnabled = true;
            this.comboKat.Location = new System.Drawing.Point(1719, 335);
            this.comboKat.Name = "comboKat";
            this.comboKat.Size = new System.Drawing.Size(138, 24);
            this.comboKat.TabIndex = 28;
            this.comboKat.SelectedIndexChanged += new System.EventHandler(this.comboKat_SelectedIndexChanged);
            // 
            // PanelOdalar
            // 
            this.PanelOdalar.Location = new System.Drawing.Point(12, 21);
            this.PanelOdalar.Name = "PanelOdalar";
            this.PanelOdalar.Size = new System.Drawing.Size(1402, 894);
            this.PanelOdalar.TabIndex = 27;
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
            this.btnKatSil.Location = new System.Drawing.Point(1683, 130);
            this.btnKatSil.Name = "btnKatSil";
            this.btnKatSil.Size = new System.Drawing.Size(236, 91);
            this.btnKatSil.TabIndex = 32;
            this.btnKatSil.Text = " Kat Sil";
            this.btnKatSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKatSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKatSil.UseVisualStyleBackColor = true;
            this.btnKatSil.Click += new System.EventHandler(this.btnKatSil_Click_1);
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKatEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKatEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatEkle.ImageIndex = 0;
            this.btnKatEkle.ImageList = this.ımageList1;
            this.btnKatEkle.Location = new System.Drawing.Point(1430, 130);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(236, 91);
            this.btnKatEkle.TabIndex = 31;
            this.btnKatEkle.Text = " Kat Ekle";
            this.btnKatEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKatEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKatEkle.UseVisualStyleBackColor = false;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // Ameliyathaneekle
            // 
            this.Ameliyathaneekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ameliyathaneekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ameliyathaneekle.ImageIndex = 0;
            this.Ameliyathaneekle.ImageList = this.ımageList1;
            this.Ameliyathaneekle.Location = new System.Drawing.Point(1565, 12);
            this.Ameliyathaneekle.Name = "Ameliyathaneekle";
            this.Ameliyathaneekle.Size = new System.Drawing.Size(236, 91);
            this.Ameliyathaneekle.TabIndex = 30;
            this.Ameliyathaneekle.Text = "Ameliyathane\r\n       Ekle";
            this.Ameliyathaneekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ameliyathaneekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ameliyathaneekle.UseVisualStyleBackColor = true;
            this.Ameliyathaneekle.Click += new System.EventHandler(this.Ameliyathaneekle_Click);
            // 
            // Ameliyathane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 771);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboKat);
            this.Controls.Add(this.PanelOdalar);
            this.Controls.Add(this.btnKatSil);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.Ameliyathaneekle);
            this.Name = "Ameliyathane";
            this.ShowIcon = false;
            this.Text = "Ameliyathane";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ameliyathane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKat;
        private System.Windows.Forms.FlowLayoutPanel PanelOdalar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnKatSil;
        private System.Windows.Forms.Button btnKatEkle;
        private System.Windows.Forms.Button Ameliyathaneekle;
    }
}