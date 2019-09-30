using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinformControlUse;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FrmStudent frm = new FrmStudent();
            object sender = null;
            EventArgs e = null;
            frm.btnshow_Click(sender,e);
            frm.btnopenfile_Click(null,null);
          

        }
    }
}
