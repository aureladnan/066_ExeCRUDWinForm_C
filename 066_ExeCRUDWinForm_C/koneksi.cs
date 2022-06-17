using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _066_ExeCRUDWinForm_C
{
    class koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "data source = Tampan; database=NaotoCoffee; MultipleActiveResultSets=True; User ID=sa; Password=Apasaja12";
            return Conn;
        }
    }
}
