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
    public partial class FrmOgrenciIslemleri : Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlBaglantisi conn = new SqlBaglantisi();
        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Kulupler",conn.Baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbOgrenciKulup.DisplayMember = "KulupAdi";
            cmbOgrenciKulup.ValueMember = "KulupId";
            cmbOgrenciKulup.DataSource = dt;
            conn.Baglanti().Close();
        }

        public void Listele()
        {
            dgvOgrenciIslemleri.DataSource = ds.OgrenciListesi();
        }
        private void btnOListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnOEkle_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            if (rdbKadın.Checked == true)
            {
                cinsiyet = rdbKadın.Text;
            }
            else
            {
                cinsiyet = rdbErkek.Text;
            }
            ds.OgrenciEkle(txtOgrenciAd.Text, txtOgrenciSoyad.Text, byte.Parse(cmbOgrenciKulup.SelectedValue.ToString()), cinsiyet);
            Listele();
            MessageBox.Show("Ekleme işlemi tamamlandı.");
        }

        private void btnOGuncelle_Click(object sender, EventArgs e)
        {
            string cns;
            if (rdbKadın.Checked == true)
            {
                cns = rdbKadın.Text;
            }
            else
            {
                cns = rdbErkek.Text;
            }
            ds.OgrenciGuncelle(txtOgrenciAd.Text, txtOgrenciSoyad.Text, byte.Parse(cmbOgrenciKulup.SelectedValue.ToString()),cns,int.Parse(txtOgrenciId.Text));
            Listele();
        }
        public string c;
        private void dgvOgrenciIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciId.Text = dgvOgrenciIslemleri.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOgrenciAd.Text = dgvOgrenciIslemleri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgrenciSoyad.Text = dgvOgrenciIslemleri.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbOgrenciKulup.Text = dgvOgrenciIslemleri.Rows[e.RowIndex].Cells[4].Value.ToString();
            c = dgvOgrenciIslemleri.Rows[e.RowIndex].Cells[3].Value.ToString();

            if(c=="Kadın")
            {
                rdbKadın.Checked = true;
            }
            else
            {
                rdbErkek.Checked = true;
            }
        }

        private void btnOSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtOgrenciId.Text));
            Listele();
        }

        private void btnOAra_Click(object sender, EventArgs e)
        {
            dgvOgrenciIslemleri.DataSource =  ds.OgrenciAra(txtOArama.Text);
        }
    }
}
