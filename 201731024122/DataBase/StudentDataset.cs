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

            Student stu1 = new Student("001", "王川");
            studengList.Add(stu1);
            Student stu2 = new Student("002", "于丁");
            studengList.Add(stu2);

            Student stu3 = new Student("003", "张莹");
            studengList.Add(stu3);
            Student stu4 = new Student("004", "李楠");
            studengList.Add(stu4);

            Student stu5 = new Student("005", "陈欣");
            studengList.Add(stu5);
            Student stu6 = new Student("006", "马芸慧");
            studengList.Add(stu6);

            Student stu7 = new Student("007", "汪小萍");
            studengList.Add(stu7);
            Student stu8 = new Student("008", "母丹");
            studengList.Add(stu8);


            Student stu9 = new Student("009", "许博");
            studengList.Add(stu9);
            Student stu10 = new Student("010", "芦文钰");
            studengList.Add(stu10);

            Student stu11 = new Student("011", "马昊妍");
            studengList.Add(stu11);
            Student stu12 = new Student("012", "李宣晓");
            studengList.Add(stu12);

            Student stu13 = new Student("013", "李清兰");
            studengList.Add(stu13);
            Student stu14 = new Student("014", "成湘");
            studengList.Add(stu14);

            Student stu15 = new Student("015", "罗涵");
            studengList.Add(stu15);
            Student stu16 = new Student("016", "肖逸菲");
            studengList.Add(stu16);

            Student stu17 = new Student("017", "冯士坤");
            studengList.Add(stu17);
            Student stu18 = new Student("018", "杨汶桐");
            studengList.Add(stu18);

            Student stu19 = new Student("019", "张焱菁");
            studengList.Add(stu19);
            Student stu20 = new Student("020", "雷槟源");
            studengList.Add(stu20);

            Student stu21 = new Student("021", "李志");
            studengList.Add(stu21);
            Student stu22 = new Student("022", "黄涛");
            studengList.Add(stu22);

            Student stu23 = new Student("023", "宋杰");
            studengList.Add(stu23);
            Student stu24 = new Student("024", "赵俊安");
            studengList.Add(stu24);


            Student stu25 = new Student("025", "张新明");
            studengList.Add(stu25);
            Student stu26 = new Student("026", "张旭");
            studengList.Add(stu26);

            Student stu27 = new Student("027", "王旭");
            studengList.Add(stu27);
            Student stu28 = new Student("028", "李朋珂");
            studengList.Add(stu28);

            Student stu29 = new Student("029", "张微玖");
            studengList.Add(stu29);
            Student stu30 = new Student("030", "何明钦");
            studengList.Add(stu30);

            Student stu31 = new Student("031", "姜玖林");
            studengList.Add(stu31);
            Student stu32 = new Student("032", "涂才森");
            studengList.Add(stu32);

            Student stu33 = new Student("033", "陈林");
            studengList.Add(stu33);
            Student stu34 = new Student("034", "曾正男");
            studengList.Add(stu34);

            Student stu35 = new Student("035", "江天宇");
            studengList.Add(stu35);
            Student stu36 = new Student("036", "魏恩博");
            studengList.Add(stu36);

            Student stu37 = new Student("037", "邹扬锋");
            studengList.Add(stu37);
            Student stu38 = new Student("038", "曾琅");
            studengList.Add(stu38);

            Student stu39 = new Student("039", "周成杰");
            studengList.Add(stu39);

            return studengList;
        }
    }
}
