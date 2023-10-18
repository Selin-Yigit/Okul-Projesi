using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProjesi
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void btnKlupIslemleri_Click(object sender, EventArgs e)
        {
            FrmKulupFormu kulup = new FrmKulupFormu();
            kulup.Show();
            this.Hide();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            FrmDersler ders = new FrmDersler();
            ders.Show();
            this.Hide();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri ogr = new FrmOgrenciIslemleri();
            ogr.Show();
            this.Hide();
        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmSinavNotlari sinav = new FrmSinavNotlari();
            sinav.Show();
            this.Hide();
        }
    }
}
