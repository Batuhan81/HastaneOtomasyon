namespace Hastane_Otomasyon
{
    partial class Ref_Listesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OdayaGöre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adara = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.ekran.Location = new System.Drawing.Point(12, 75);
            this.ekran.Name = "ekran";
            this.ekran.RowHeadersWidth = 51;
            this.ekran.RowTemplate.Height = 24;
            this.ekran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ekran.Size = new System.Drawing.Size(1784, 757);
            this.ekran.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OdayaGöre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adara);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txttcara);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(321, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1408, 48);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreler";
            // 
            // OdayaGöre
            // 
            this.OdayaGöre.Location = new System.Drawing.Point(1036, 15);
            this.OdayaGöre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OdayaGöre.Name = "OdayaGöre";
            this.OdayaGöre.Size = new System.Drawing.Size(137, 28);
            this.OdayaGöre.TabIndex = 90;
            this.OdayaGöre.TextChanged += new System.EventHandler(this.OdayaGöre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(891, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Kaldığı Oda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adara
            // 
            this.adara.Location = new System.Drawing.Point(623, 11);
            this.adara.Name = "adara";
            this.adara.Size = new System.Drawing.Size(137, 28);
            this.adara.TabIndex = 84;
            this.adara.TextChanged += new System.EventHandler(this.adara_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(530, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 20);
            this.label21.TabIndex = 83;
            this.label21.Text = "İsme ";
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(296, 11);
            this.txttcara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(137, 28);
            this.txttcara.TabIndex = 82;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(217, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 81;
            this.label9.Text = " Tc ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ref_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 844);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ekran);
            this.Name = "Ref_Listesi";
            this.ShowIcon = false;
            this.Text = "Refakatçı Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ref_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ekran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox adara;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OdayaGöre;
        private System.Windows.Forms.Label label1;
    }
}