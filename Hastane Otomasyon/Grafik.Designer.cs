namespace Hastane_Otomasyon
{
    partial class Grafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboKat = new System.Windows.Forms.ComboBox();
            this.geneldoluluk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yatakChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.odachart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.odakatgir = new System.Windows.Forms.ComboBox();
            this.OdaDoluluk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ameliyatchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ameliyatkatgir = new System.Windows.Forms.ComboBox();
            this.Ameliyatoluluk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yatakChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odachart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ameliyatchart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboKat
            // 
            this.comboKat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboKat.FormattingEnabled = true;
            this.comboKat.Location = new System.Drawing.Point(145, 481);
            this.comboKat.Name = "comboKat";
            this.comboKat.Size = new System.Drawing.Size(137, 24);
            this.comboKat.TabIndex = 19;
            this.comboKat.SelectedIndexChanged += new System.EventHandler(this.comboKat_SelectedIndexChanged);
            // 
            // geneldoluluk
            // 
            this.geneldoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geneldoluluk.Location = new System.Drawing.Point(337, 407);
            this.geneldoluluk.Name = "geneldoluluk";
            this.geneldoluluk.Size = new System.Drawing.Size(108, 72);
            this.geneldoluluk.TabIndex = 18;
            this.geneldoluluk.Text = "Genel Doluluk";
            this.geneldoluluk.UseVisualStyleBackColor = true;
            this.geneldoluluk.Click += new System.EventHandler(this.geneldoluluk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bilgisini İstediğiniz Kat";
            // 
            // yatakChart
            // 
            chartArea4.Name = "ChartArea1";
            this.yatakChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.yatakChart.Legends.Add(legend4);
            this.yatakChart.Location = new System.Drawing.Point(66, 62);
            this.yatakChart.Name = "yatakChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.yatakChart.Series.Add(series4);
            this.yatakChart.Size = new System.Drawing.Size(404, 306);
            this.yatakChart.TabIndex = 20;
            this.yatakChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(268, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Yatak";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1575, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 72);
            this.button2.TabIndex = 28;
            this.button2.Text = "Genel Doluluk";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(703, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Oda";
            // 
            // odachart
            // 
            chartArea5.Name = "ChartArea1";
            this.odachart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.odachart.Legends.Add(legend5);
            this.odachart.Location = new System.Drawing.Point(547, 62);
            this.odachart.Name = "odachart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.odachart.Series.Add(series5);
            this.odachart.Size = new System.Drawing.Size(404, 306);
            this.odachart.TabIndex = 32;
            this.odachart.Text = "chart2";
            // 
            // odakatgir
            // 
            this.odakatgir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odakatgir.FormattingEnabled = true;
            this.odakatgir.Location = new System.Drawing.Point(627, 481);
            this.odakatgir.Name = "odakatgir";
            this.odakatgir.Size = new System.Drawing.Size(137, 24);
            this.odakatgir.TabIndex = 31;
            this.odakatgir.SelectedIndexChanged += new System.EventHandler(this.odakatgir_SelectedIndexChanged);
            // 
            // OdaDoluluk
            // 
            this.OdaDoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaDoluluk.Location = new System.Drawing.Point(819, 407);
            this.OdaDoluluk.Name = "OdaDoluluk";
            this.OdaDoluluk.Size = new System.Drawing.Size(108, 72);
            this.OdaDoluluk.TabIndex = 30;
            this.OdaDoluluk.Text = "Genel Doluluk";
            this.OdaDoluluk.UseVisualStyleBackColor = true;
            this.OdaDoluluk.Click += new System.EventHandler(this.OdaDoluluk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(590, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bilgisini İstediğiniz Kat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1155, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ameliyathane";
            // 
            // ameliyatchart
            // 
            chartArea6.Name = "ChartArea1";
            this.ameliyatchart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ameliyatchart.Legends.Add(legend6);
            this.ameliyatchart.Location = new System.Drawing.Point(1022, 62);
            this.ameliyatchart.Name = "ameliyatchart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ameliyatchart.Series.Add(series6);
            this.ameliyatchart.Size = new System.Drawing.Size(404, 306);
            this.ameliyatchart.TabIndex = 37;
            this.ameliyatchart.Text = "chart3";
            // 
            // ameliyatkatgir
            // 
            this.ameliyatkatgir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ameliyatkatgir.FormattingEnabled = true;
            this.ameliyatkatgir.Location = new System.Drawing.Point(1106, 481);
            this.ameliyatkatgir.Name = "ameliyatkatgir";
            this.ameliyatkatgir.Size = new System.Drawing.Size(137, 24);
            this.ameliyatkatgir.TabIndex = 36;
            this.ameliyatkatgir.SelectedIndexChanged += new System.EventHandler(this.ameliyatkatgir_SelectedIndexChanged);
            // 
            // Ameliyatoluluk
            // 
            this.Ameliyatoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ameliyatoluluk.Location = new System.Drawing.Point(1298, 407);
            this.Ameliyatoluluk.Name = "Ameliyatoluluk";
            this.Ameliyatoluluk.Size = new System.Drawing.Size(108, 72);
            this.Ameliyatoluluk.TabIndex = 35;
            this.Ameliyatoluluk.Text = "Genel Doluluk";
            this.Ameliyatoluluk.UseVisualStyleBackColor = true;
            this.Ameliyatoluluk.Click += new System.EventHandler(this.Ameliyatoluluk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1058, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Bilgisini İstediğiniz Kat";
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ameliyatchart);
            this.Controls.Add(this.ameliyatkatgir);
            this.Controls.Add(this.Ameliyatoluluk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odachart);
            this.Controls.Add(this.odakatgir);
            this.Controls.Add(this.OdaDoluluk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yatakChart);
            this.Controls.Add(this.comboKat);
            this.Controls.Add(this.geneldoluluk);
            this.Controls.Add(this.label1);
            this.Name = "Grafik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Doluluk Grafiği";
            this.Load += new System.EventHandler(this.Grafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yatakChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odachart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ameliyatchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKat;
        private System.Windows.Forms.Button geneldoluluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart yatakChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart odachart;
        private System.Windows.Forms.ComboBox odakatgir;
        private System.Windows.Forms.Button OdaDoluluk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ameliyatchart;
        private System.Windows.Forms.ComboBox ameliyatkatgir;
        private System.Windows.Forms.Button Ameliyatoluluk;
        private System.Windows.Forms.Label label6;
    }
}