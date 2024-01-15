namespace Hastane_Otomasyon
{
    partial class ÖlüListesi
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
            this.ekran = new System.Windows.Forms.DataGridView();
            this.cinsiyetara = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adara = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ekran
            // 
            this.ekran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ekran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ekran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ekran.Location = new System.Drawing.Point(-7, 70);
            this.ekran.Name = "ekran";
            this.ekran.RowHeadersWidth = 51;
            this.ekran.RowTemplate.Height = 24;
            this.ekran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ekran.Size = new System.Drawing.Size(1684, 697);
            this.ekran.TabIndex = 1;
            // 
            // cinsiyetara
            // 
            this.cinsiyetara.FormattingEnabled = true;
            this.cinsiyetara.Items.AddRange(new object[] {
            "Tümü",
            "Kadın",
            "Erkek"});
            this.cinsiyetara.Location = new System.Drawing.Point(886, 25);
            this.cinsiyetara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cinsiyetara.Name = "cinsiyetara";
            this.cinsiyetara.Size = new System.Drawing.Size(137, 30);
            this.cinsiyetara.TabIndex = 80;
            this.cinsiyetara.SelectedIndexChanged += new System.EventHandler(this.cinsiyetara_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(780, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 79;
            this.label12.Text = " Cinsiyet";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adara
            // 
            this.adara.Location = new System.Drawing.Point(503, 24);
            this.adara.Name = "adara";
            this.adara.Size = new System.Drawing.Size(137, 28);
            this.adara.TabIndex = 78;
            this.adara.TextChanged += new System.EventHandler(this.adara_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(410, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 20);
            this.label21.TabIndex = 77;
            this.label21.Text = "İsme ";
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(134, 25);
            this.txttcara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(137, 28);
            this.txttcara.TabIndex = 76;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(55, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = " Tc ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cinsiyetara);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.adara);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txttcara);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(593, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 61);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme Seçenekleri";
            // 
            // ÖlüListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 779);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ekran);
            this.Name = "ÖlüListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morg Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ÖlüListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ekran;
        private System.Windows.Forms.ComboBox cinsiyetara;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox adara;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}