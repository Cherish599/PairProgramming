using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entity;
using System.Collections.Generic;

namespace WinformControlUseUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public static List<Student> studengList;
        [TestMethod]
        public void studengListTest()
        {
            studengList = new List<Student>();
            Student stu1 = new Student("001", "王川");
            studengList.Add(stu1);
        }
    }
}
