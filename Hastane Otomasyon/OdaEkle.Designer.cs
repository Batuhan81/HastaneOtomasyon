namespace Hastane_Otomasyon
{
    partial class OdaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odano = new System.Windows.Forms.TextBox();
            this.yataks = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.iptal = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yatak Sayısı:";
            // 
            // odano
            // 
            this.odano.Location = new System.Drawing.Point(139, 14);
            this.odano.Name = "odano";
            this.odano.Size = new System.Drawing.Size(119, 28);
            this.odano.TabIndex = 4;
            this.odano.TextChanged += new System.EventHandler(this.odano_TextChanged);
            // 
            // yataks
            // 
            this.yataks.Location = new System.Drawing.Point(141, 64);
            this.yataks.Name = "yataks";
            this.yataks.Size = new System.Drawing.Size(119, 28);
            this.yataks.TabIndex = 6;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            this.ımageList1.Images.SetKeyName(1, "Yenile İkonu2.png");
            this.ımageList1.Images.SetKeyName(2, "Ekle2.png");
            // 
            // iptal
            // 
            this.iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.ImageIndex = 0;
            this.iptal.ImageList = this.ımageList1;
            this.iptal.Location = new System.Drawing.Point(70, 239);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(153, 48);
            this.iptal.TabIndex = 32;
            this.iptal.Text = "İptal";
            this.iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // btnekle
            // 
            this.btnekle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ImageIndex = 2;
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(70, 185);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(153, 48);
            this.btnekle.TabIndex = 31;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // OdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 331);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.yataks);
            this.Controls.Add(this.odano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OdaEkle";
            this.Text = "Durumu";
            this.Load += new System.EventHandler(this.OdaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox odano;
        private System.Windows.Forms.TextBox yataks;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button btnekle;
    }
}