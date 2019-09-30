using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaoLayer;

namespace 单元测试
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num  = new DaoLayer.StudentDAO().getStudentRecordsNums();
            Assert.Equals(num,84);
        }
    }
}
