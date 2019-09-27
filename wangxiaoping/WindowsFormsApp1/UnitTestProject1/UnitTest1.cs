using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBase;
using DaoLayer;
using Entity;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student ss = new Student();
            StudentDataset st = new StudentDataset();
            StudentDAO sd = new StudentDAO();
        }
    }
}
