using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odalar git=new Odalar();
            git.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaList git=new HastaList();
            git.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ref_Listesi git=new Ref_Listesi();
            git.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Çalısan git =new Çalısan();
            git.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ameliyathane git=new Ameliyathane();    
            git.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ÖlüListesi git=new ÖlüListesi();
            git.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Grafik git=new Grafik();
            git.ShowDialog();
        }
    }
}
