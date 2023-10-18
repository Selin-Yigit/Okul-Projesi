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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi conn = new SqlBaglantisi();
        public string ogrNo;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select DersAdi, Sinav1, Sinav2, Sinav3, Proje, Ortalama, Durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.DersId = Tbl_Dersler.DersId where OgrenciId = @o1", conn.Baglanti());
            cmd.Parameters.AddWithValue("@o1",ogrNo);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOgrenciNotlari.DataSource = dt;
            conn.Baglanti().Close();

        }
    }
}
