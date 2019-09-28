using System;
using System.Windows;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using DaoLayer;
using DataBase;
using PairPrograming;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form1 = new Form1();
            form1.unitest_formLoad();
            form1.unitest_rdChoseStu();
            form1.unitest_Absence();
            int tmp = form1.preAssert();
            Assert.AreEqual(1, tmp);
            form1.unitest_cancelAbsence();
            tmp = form1.preAssert();
            Assert.AreEqual(0, tmp);
        }
    }
}
