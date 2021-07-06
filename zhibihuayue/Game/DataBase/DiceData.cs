using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;
using Entity;
namespace DataBase
{
    public class DiceData
    {
        private static List<Dice> diceList;


        public static List<Dice> getAll()
        {
            diceList = new List<Dice>();

            Dice num1 = new Dice("1");
            diceList.Add(num1);
            Dice num2 = new Dice("2");
            diceList.Add(num2);
            Dice num3 = new Dice("3");
            diceList.Add(num3);
            Dice num4 = new Dice("4");
            diceList.Add(num4);
            Dice num5 = new Dice("5");
            diceList.Add(num5);
            Dice num6 = new Dice("6");
            diceList.Add(num6);


            return diceList;
        }
    }
}
