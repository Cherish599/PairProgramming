using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLogin
{
    class Common
    {
        public static DataSet QuerySql(string sql)
        {

            SqlConnection conn = new SqlConnection("server=LAPTOP-K6RLAPNC;database=Demo;Trusted_Connection=true");
            conn.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}
