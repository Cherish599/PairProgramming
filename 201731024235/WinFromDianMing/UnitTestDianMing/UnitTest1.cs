using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFromDianMing;

namespace UnitTestDianMing
{
    [TestClass]
    public class UnitTestFormStudet
    {
        [TestMethod]
        public void TestFormStudet()
        {
            FormStudet Test = new FormStudet();
            Test.Show();
        }
    }
}
