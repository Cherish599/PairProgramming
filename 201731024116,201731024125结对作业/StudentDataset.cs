using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;
using Entity;

namespace DataBase
{
    public class StudentDataset
    {
        //模拟数据库中的学生集合

        private static List<Student> studengList;


        public static List<Student> getAll()
        {
            studengList=new List<Student>();

            Student stu1 = new Student("001", "王川","男","地理信息科学");
            studengList.Add(stu1);
            Student stu2 = new Student("002", "于丁", "男", "地理信息科学");
            studengList.Add(stu2);

            Student stu3 = new Student("003", "张莹", "女", "地理信息科学");
            studengList.Add(stu3);
            Student stu4 = new Student("004", "李楠", "女", "地理信息科学");
            studengList.Add(stu4);

            Student stu5 = new Student("005", "陈欣", "女","地理信息科学");
            studengList.Add(stu5);
            Student stu6 = new Student("006", "马芸慧", "女", "地理信息科学");
            studengList.Add(stu6);

            Student stu7 = new Student("007", "汪小萍", "女", "地理信息科学");
            studengList.Add(stu7);
            Student stu8 = new Student("008", "母丹", "女", "地理信息科学");
            studengList.Add(stu8);

            Student stu11 = new Student("011", "马昊妍", "女", "地理信息科学");
            studengList.Add(stu11);
            Student stu12 = new Student("012", "李宣晓", "女", "地理信息科学");
            studengList.Add(stu12);

            Student stu13 = new Student("013", "李清兰", "女", "地理信息科学");
            studengList.Add(stu13);
            Student stu14 = new Student("014", "成湘", "女", "地理信息科学");
            studengList.Add(stu14);

            Student stu15 = new Student("015", "罗涵", "女", "地理信息科学");
            studengList.Add(stu15);
            Student stu16 = new Student("016", "肖逸菲", "女", "地理信息科学");
            studengList.Add(stu16);

            Student stu17 = new Student("017", "冯士坤", "男", "地理信息科学");
            studengList.Add(stu17);
            Student stu18 = new Student("018", "杨汶桐", "男", "地理信息科学");
            studengList.Add(stu18);

            Student stu19 = new Student("019", "张焱菁", "男", "地理信息科学");
            studengList.Add(stu19);
            Student stu20 = new Student("020", "雷槟源", "男", "地理信息科学");
            studengList.Add(stu20);

            Student stu21 = new Student("021", "李志", "男", "地理信息科学");
            studengList.Add(stu21);
         
            Student stu25 = new Student("025", "张新明", "男", "地理信息科学");
            studengList.Add(stu25);
        
            Student stu28 = new Student("028", "李朋珂", "男", "地理信息科学");
            studengList.Add(stu28);

            Student stu29 = new Student("029", "张微玖", "男", "地理信息科学");
            studengList.Add(stu29);
            Student stu30 = new Student("030", "何明钦", "男", "地理信息科学");
            studengList.Add(stu30);

            Student stu31 = new Student("031", "姜玖林", "男", "地理信息科学");
            studengList.Add(stu31);

            Student stu37 = new Student("031", "邹扬锋", "男", "地理信息科学");
            studengList.Add(stu37);
            Student stu38 = new Student("032", "曾琅", "男", "地理信息科学");
            studengList.Add(stu38);

            Student stu39 = new Student("032", "周成杰", "男", "地理信息科学");
            studengList.Add(stu39);

            Student stu40 = new Student("032", "马驰", "男", "地理信息科学");
            studengList.Add(stu40);

            Student stu41 = new Student("032", "宋树钱", "男", "地理信息科学");
            studengList.Add(stu41);
        


            return studengList;
        }
    }
}
