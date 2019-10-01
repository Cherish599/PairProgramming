using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Student
    {
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String sex;
        public String Sex
        {
            get { return sex; }
            set { sex= value; }
        }

        public Student()
        { 
        
        }
        public Student(String id, String name,String sex)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
        }
    }
}
