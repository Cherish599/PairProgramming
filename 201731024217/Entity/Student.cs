using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Student()
        {

        }

        private int timeAbsence;

        public int TimeAbence
        {
            get { return timeAbsence; }
            set { timeAbsence = value; }
        }


        public Student(String id, String name, int timeabsence)
        {
            this.id = id;
            this.name = name;
            this.timeAbsence = timeabsence;
        }

    }
}
