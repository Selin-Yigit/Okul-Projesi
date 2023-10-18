using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkulProjesi
{
    public partial class FrmSinavNotlari : Form
    {
        public FrmSinavNotlari()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void btnSNAra_Click(object sender, EventArgs e)
        {
            dgvSinavNotlari.DataSource = ds.NotListesi(int.Parse(txtOgrenciAra.Text));
        }
         SqlBaglantisi conn = new SqlBaglantisi();
        private void FrmSinavNotlari_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_dersler", conn.Baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmbDersler.DisplayMember = "DersAdi";
            cmbDersler.ValueMember = "DersId";
            cmbDersler.DataSource = dt;
            conn.Baglanti().Close();
        }

        private void dgvSinavNotlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NotId = int.Parse(dgvSinavNotlari.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOgrenciId.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDersler.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSinav1.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinav2.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSinav3.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtProje.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        byte sinav1, sinav2, sinav3, proje;
        decimal ortalama;
        string durum;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sinav1 = Convert.ToByte(txtSinav1.Text);
            sinav2 = Convert.ToByte(txtSinav2.Text);
            sinav3 = Convert.ToByte(txtSinav3.Text);
            proje = Convert.ToByte(txtProje.Text);

            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();

            if(ortalama<50)
            {
                durum = "False";
                txtDurum.Text=durum;
            }
            else
            {
                durum = "True";
                txtDurum.Text = durum;
            }
        }
        int NotId;
        private void tbSNGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDersler.SelectedValue.ToString()), int.Parse(txtOgrenciId.Text), sinav1, sinav2, sinav3, proje, ortalama, bool.Parse(durum), NotId);
            dgvSinavNotlari.DataSource = ds.NotListesi(int.Parse(txtOgrenciAra.Text));
        }
    }
}
