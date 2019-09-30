using System;
using Xunit;
using DaoLayer;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DaoLayer.StudentDAO dao = new DaoLayer.StudentDAO();
            Assert.Equal(dao.getStudentRecordsNums(), 84);
        }
    }
}
