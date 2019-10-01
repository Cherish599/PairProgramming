using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StuData;
using StuDataBase;

namespace DaoLayer
{
    public class StudentDAO
    {
        public int getStudentRecordsNums()
        {
            List<Student> studentList = StudentDataset.getAll();
            return studentList.Count;
        }

        public List<Student> getAllStudents()
        {
            List<Student> studentList = StudentDataset.getAll();
            return studentList;
        }
    }

   
    
}
