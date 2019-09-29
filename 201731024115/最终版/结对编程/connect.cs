using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 结对编程
{
  public  class connect
    { 
        public static DataSet querysql(string sql)
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
