using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Dice
    {
        private String num;
        public String Num
        {
            get { return num; }
            set { num= value; }
        }


        public Dice()
        {

        }
        public Dice(String num)
        {
            this.num = num;
        }
    }
}
