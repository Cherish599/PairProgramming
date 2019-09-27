using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaoLayer;
using DataBase;
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
            StudentDataset yy = new StudentDataset();
            StudentDAO yyy = new StudentDAO();
        }
    }
}
