using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinformControlUse;
using System.IO;

namespace diandaoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            FileStream fs = File.OpenRead(@"C:/test.txt");
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            int absencenum = Convert.ToInt32(s);
           
            sr.Close();
            fs.Close();
            Assert.AreEqual(absencenum, 5);
        }

     
    }
}
