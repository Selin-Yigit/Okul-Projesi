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
    public partial class FrmKulupFormu : Form
    {
        public FrmKulupFormu()
        {
            InitializeComponent();
        }
        SqlBaglantisi conn = new SqlBaglantisi();

        public void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kulupler", conn.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKulup.DataSource = dt;
            conn.Baglanti().Close();
        }
        private void FrmKlupFormu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("insert into Tbl_Kulupler (KulupAdi) values (@k1)",conn.Baglanti());
            cmdEkle.Parameters.AddWithValue("@k1", txtKulupAd.Text);
            cmdEkle.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Ekleme işelmi tamamlanmıştır.");
            Listele();
        }

        private void btnKGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdUpdate = new SqlCommand("update Tbl_Kulupler set KulupAdi = @k1 where KulupId = @k2", conn.Baglanti());
            cmdUpdate.Parameters.AddWithValue("@k1", txtKulupAd.Text);
            cmdUpdate.Parameters.AddWithValue("@k2", txtKulupId.Text);
            cmdUpdate.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Güncelleme işelmi tamamlanmıştır.");
            Listele();
        }

        private void dgvKulup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupId.Text = dgvKulup.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAd.Text = dgvKulup.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnKSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_Kulupler where KulupId = @k", conn.Baglanti());
            cmd.Parameters.AddWithValue("@k", txtKulupId.Text);
            cmd.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Silme işelmi tamamlanmıştır.");
            Listele();
        }
    }
}
