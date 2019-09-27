using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stu_Entity;
using Stu_Database;

namespace Stu_Layer
{
    public class Layer
    {
        public List<Entity> getAllStudents()
        {
            List<Entity> studengList = Databse.getAll();
            return studengList;
        }

    }
}
