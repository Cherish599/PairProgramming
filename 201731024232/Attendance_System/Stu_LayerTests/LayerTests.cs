using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stu_Layer;
using Stu_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stu_Layer.Tests
{
    [TestClass()]
    public class LayerTests
    {
        [TestMethod()]
        public void getStudentRecordsNumsTest()
        {
            Layer test = new Layer();
            
            Assert.IsNotNull(test.getAllStudents());//测试是否为空

            Assert.ReferenceEquals(test,test.getAllStudents());//测试实例是否是相同实例
        }
    }
}