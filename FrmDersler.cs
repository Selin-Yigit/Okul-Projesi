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
    public partial class FrmDersler : Form
    {
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        public FrmDersler()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dgvDers.DataSource = ds.DersListesi();
        }
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAd.Text);
            MessageBox.Show("Ekleme işlemi tamamlandı.");
            Listele();
        }

        private void btnDSil_Click(object sender, EventArgs e)
        {
            byte id = byte.Parse(txtDersId.Text);
            ds.DersSil(id);
            Listele();
        }

        private void btnDGuncelle_Click(object sender, EventArgs e)
        {
            byte id = byte.Parse(txtDersId.Text);
            ds.DersGuncelle(txtDersAd.Text, id);
            Listele();
        }

        private void dgvDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dgvDers.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dgvDers.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
