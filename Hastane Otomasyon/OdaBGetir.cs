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
    public partial class OdaBGetir : Form
    {
        private Sınıf1 snf1;
        private Sınıf2 snf2;
        public OdaBGetir(Sınıf1 s1, Sınıf2 s2)
        {
            InitializeComponent();
            snf1= s1;
            snf2 = s2;
        }
    }
}
