﻿using System;
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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void pcbOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar notlar = new FrmOgrenciNotlar();
            notlar.ogrNo = txtNumara.Text;
            notlar.Show();
            this.Hide();
        }

        private void pcbOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmen ogretmen = new FrmOgretmen();
            ogretmen.Show();
            this.Hide();
        }
    }
}
