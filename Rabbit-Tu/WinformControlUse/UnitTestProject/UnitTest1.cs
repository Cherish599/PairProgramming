using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaoLayer;
using Entity;
using WinformControlUse;
using DataBase;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student st = new Student("201731024129", "涂才森");

        }
    }
}
