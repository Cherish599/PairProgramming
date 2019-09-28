﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataBase;

namespace DaoLayer
{
    public class StudentDAO
    {

        public List<Student> getAllStudents()
        {
            List<Student> studengList = StudentDataset.getAll();
            return studengList;
        }
    }
}
