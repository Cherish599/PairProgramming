using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using System.Collections.Generic;
using DaoLayer;
using DataBase;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
          public static Student studengname;
        [TestMethod]
        public void TestMethod1()
        {
            StudentDAO jy = new StudentDAO();
            StudentDataset wmy = new StudentDataset();
            Student ct = new Student();
        }
    }
}
