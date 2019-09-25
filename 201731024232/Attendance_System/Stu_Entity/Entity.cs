using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stu_Entity
{
    public class Entity
    {
        private String id;

        public String Id//学号
        {
            get { return id; }
            set { id = value; }
        }


        private String name;

        public String Name//姓名
        {
            get { return name; }
            set { name = value; }
        }

        private int abse;

        public int Abse//缺勤次数
        {
            get { return abse; }
            set { abse = value; }
        }

        public Entity()
        {

        }
        public Entity(String id, String name,int Abs)
        {
            this.id = id;
            this.name = name;
            this.abse = abse;
        }
    }
}
