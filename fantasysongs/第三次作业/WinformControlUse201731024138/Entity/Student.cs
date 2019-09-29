using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Student
    {
        private String num;

        public String Num
        {
            get { return num; }
            set { num = value; }
        }
        
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

        public Student()
        { 
        
        }
        public Student(String num,String id, String name)
        {
            this.num = num;
            this.id = id;
            this.name = name;
        }
    }
}
