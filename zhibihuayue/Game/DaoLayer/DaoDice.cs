using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DataBase;
namespace DaoLayer
{
    class DaoDice
    {
        public class StudentDAO
        {
            public int getDiceRecordsNums()
            {
                List<Dice> DiceList = DiceData.getAll();
                return DiceList.Count;
            }

            public List<Dice> getAllDice()
            {
                List<Dice> diceList = DiceData.getAll();
                return diceList;
            }

        }
    }
}
