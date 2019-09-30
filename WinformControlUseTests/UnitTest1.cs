using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaoLayer;
using Entity;
using System.Threading;
using System.IO;
using System.Windows.Forms;

using WinformControlUse;


namespace WinformControlUseTests
{           
        [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TimerCallName_Tick(object sender, EventArgs e)
        {
            FrmStudent StuName=new FrmStudent ();
            Random ra = new Random();
            int i = ra.Next(StuName . stuList.Count);
           StuName . lblName.Text = StuName.stuList[i].Name;

        }        
        public void TestMethod1()
        {
            FrmStudent frmstudent = new FrmStudent ();
            frmstudent.AbsentTems();
        }
    }
}
