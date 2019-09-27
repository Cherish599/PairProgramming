using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 骰子游戏
{
    public class Touzi
    {
        private int num=6;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        Random rd = new Random();

        //掷骰子，使骰子获得随机点数
        public void Dice()
        {
            num = rd.Next(1, 7);
        }
    }
}
