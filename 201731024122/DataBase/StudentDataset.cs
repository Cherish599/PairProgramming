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

            Student stu1 = new Student("201731024256", "王川");
            studengList.Add(stu1);
            Student stu2 = new Student("201731024545", "于丁");
            studengList.Add(stu2);

            Student stu3 = new Student("201731024165", "张莹");
            studengList.Add(stu3);
            Student stu4 = new Student("201731024101 ", "李楠");
            studengList.Add(stu4);

            Student stu5 = new Student("201731024102", "陈欣");

            studengList.Add(stu5);
            Student stu6 = new Student("201731024103", "马芸慧");
            studengList.Add(stu6);

            Student stu7 = new Student("201731024104", "汪小萍");
            studengList.Add(stu7);
            Student stu8 = new Student("201731024105", "母丹");
            studengList.Add(stu8);


            Student stu9 = new Student("201731024106", "许博");
            studengList.Add(stu9);
            Student stu10 = new Student("201731024107", "芦文钰");
            studengList.Add(stu10);

            Student stu11 = new Student("201731024108", "马昊妍");
            studengList.Add(stu11);
            Student stu12 = new Student("201731024109", "李宣晓");
            studengList.Add(stu12);

            Student stu13 = new Student("201731024110", "李清兰");
            studengList.Add(stu13);
            Student stu14 = new Student("201731024111", "成湘");
            studengList.Add(stu14);

            Student stu15 = new Student("201731024112", "罗涵");
            studengList.Add(stu15);
            Student stu16 = new Student("201731024113", "肖逸菲");
            studengList.Add(stu16);

            Student stu17 = new Student("201731024103", "冯士坤");
            studengList.Add(stu17);
            Student stu18 = new Student("201731024114", "杨汶桐");
            studengList.Add(stu18);

            Student stu19 = new Student("201731024115", "张焱菁");
            studengList.Add(stu19);
            Student stu20 = new Student("201731024116", "雷槟源");
            studengList.Add(stu20);

            Student stu21 = new Student("201731024117", "李志");
            studengList.Add(stu21);
            Student stu22 = new Student("201731024118", "黄涛");
            studengList.Add(stu22);

            Student stu23 = new Student("201731024119", "宋杰");
            studengList.Add(stu23);
            Student stu24 = new Student("201731024120", "赵俊安");
            studengList.Add(stu24);


            Student stu25 = new Student("201731024122", "张新明");
            studengList.Add(stu25);
            Student stu26 = new Student("201731024123 ","张旭");
            studengList.Add(stu26);

            Student stu27 = new Student("201731024124", "王旭");
            studengList.Add(stu27);
            Student stu28 = new Student("201731024125", "李朋珂");
            studengList.Add(stu28);

            Student stu29 = new Student("201731024126", "张微玖");
            studengList.Add(stu29);
            Student stu30 = new Student("201731024127", "何明钦");
            studengList.Add(stu30);

            Student stu31 = new Student("201731024128", "姜玖林");
            studengList.Add(stu31);
            Student stu32 = new Student("201731024129", "涂才森");
            studengList.Add(stu32);

            Student stu33 = new Student("201731024130", "陈林");
            studengList.Add(stu33);
            Student stu34 = new Student("201731024131", "曾正男");
            studengList.Add(stu34);

            Student stu35 = new Student("201731024133", "江天宇");
            studengList.Add(stu35);
            Student stu36 = new Student("201731024134", "魏恩博");
            studengList.Add(stu36);

            Student stu37 = new Student("201731024135", "邹扬锋");
            studengList.Add(stu37);
            Student stu38 = new Student("201731024136", "曾琅");
            studengList.Add(stu38);

            Student stu39 = new Student("201731024137", "周成杰");
            studengList.Add(stu39);

            return studengList;
        }
    }
}
