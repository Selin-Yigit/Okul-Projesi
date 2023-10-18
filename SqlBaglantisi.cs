using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OkulProjesi
{
    internal class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-H345E0I;Initial Catalog=OkulProjesi;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
