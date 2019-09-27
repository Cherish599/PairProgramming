using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBase;
using Entity;
using DaoLayer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StudentDataset SD = new StudentDataset();
            StudentDAO SDao = new StudentDAO();
            Student St = new Student();
        }
    }
}
