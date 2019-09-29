using Microsoft.VisualStudio.TestTools.UnitTesting;
using 结对编程;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 结对编程.Tests
{
    [TestClass()]
    public class Form2Tests
    {
        [TestMethod()]
        public void timerCallName_TickTest()
        {
            string sql = string.Format("select * from tblStu");
            DataSet ds = connect.querysql("select * from tblStu");
            string A = Convert.ToString(ds.Tables[0].Rows[11]["stuName"]);
            StringAssert.Contains("张焱菁", A);
            //Assert.Fail();     
        }
    }
}