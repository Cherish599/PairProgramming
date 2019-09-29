using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 结对编程
{
    class connect
    {
        public static int ExecuteSQL(string sql)
        {
            string str = "server=DESKTOP-63R5DGR\\SQLEXPRESS;database=Demo;Trusted_Connection=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            SqlCommand comm = new SqlCommand(sql, conn);
            int iRet = comm.ExecuteNonQuery();
            conn.Close();
            return iRet;
        }
        public static DataSet querysql(string sql)
        {

            SqlConnection conn = new SqlConnection("server=DESKTOP-63R5DGR\\SQLEXPRESS;database=Demo;Trusted_Connection=true");
            conn.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            conn.Close();

            return ds;
        }
    }
}
