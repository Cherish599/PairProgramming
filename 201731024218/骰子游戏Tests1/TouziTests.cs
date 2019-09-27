using Microsoft.VisualStudio.TestTools.UnitTesting;
using 骰子游戏;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 骰子游戏.Tests
{
    [TestClass()]
    public class TouziTests
    {
        Touzi touzi = new Touzi();
        [TestMethod()]
        //测试Dice方法是否总是能赋予Num一个1到6的值
        public void DiceTest()
        {
            bool judge = true;
            for (int i = 0; i < 10; i++)
            {
                touzi.Dice();
                if (touzi.Num<1||touzi.Num>6)
                {
                    judge = false;
                }
            }
            Assert.IsTrue(judge);
        }
    }
}