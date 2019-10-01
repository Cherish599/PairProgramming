using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;

namespace DataBase
{
    public class StudentDataset
    {
        private static List<Student> studengList;


        public static List<Student> getAll()
        {
            studengList = new List<Student>();

            Student stu1 = new Student("001", "王川", "男");
            studengList.Add(stu1);
            Student stu2 = new Student("002", "于丁", "男");
            studengList.Add(stu2);

            Student stu3 = new Student("003", "张莹", "女");
            studengList.Add(stu3);
            Student stu4 = new Student("004", "李楠", "女");
            studengList.Add(stu4);

            Student stu5 = new Student("005", "陈欣", "女");
            studengList.Add(stu5);
            Student stu6 = new Student("006", "马芸慧", "女");
            studengList.Add(stu6);

            Student stu7 = new Student("007", "汪小萍", "女");
            studengList.Add(stu7);
            Student stu8 = new Student("008", "母丹", "女");
            studengList.Add(stu8);


            Student stu9 = new Student("009", "许博", "女");
            studengList.Add(stu9);
            Student stu10 = new Student("010", "芦文钰", "女");
            studengList.Add(stu10);

            Student stu11 = new Student("011", "马昊妍", "女");
            studengList.Add(stu11);
            Student stu12 = new Student("012", "李宣晓", "女");
            studengList.Add(stu12);

            Student stu13 = new Student("013", "李清兰", "女");
            studengList.Add(stu13);
            Student stu14 = new Student("014", "成湘", "女");
            studengList.Add(stu14);

            Student stu15 = new Student("015", "罗涵", "女");
            studengList.Add(stu15);
            Student stu16 = new Student("016", "肖逸菲", "女");
            studengList.Add(stu16);

            Student stu17 = new Student("017", "冯士坤", "男");
            studengList.Add(stu17);
            Student stu18 = new Student("018", "杨汶桐", "男");
            studengList.Add(stu18);

            Student stu19 = new Student("019", "张焱菁", "男");
            studengList.Add(stu19);
            Student stu20 = new Student("020", "雷槟源", "男");
            studengList.Add(stu20);

            Student stu21 = new Student("021", "李志", "男");
            studengList.Add(stu21);
            Student stu22 = new Student("022", "黄涛", "男");
            studengList.Add(stu22);

            Student stu23 = new Student("023", "宋杰", "男");
            studengList.Add(stu23);
            Student stu24 = new Student("024", "赵俊安", "男");
            studengList.Add(stu24);


            Student stu25 = new Student("025", "张新明", "男");
            studengList.Add(stu25);
            Student stu26 = new Student("026", "张旭", "男");
            studengList.Add(stu26);

            Student stu27 = new Student("027", "王旭", "男");
            studengList.Add(stu27);
            Student stu28 = new Student("028", "李朋珂", "男");
            studengList.Add(stu28);

            Student stu29 = new Student("029", "张微玖", "男");
            studengList.Add(stu29);
            Student stu30 = new Student("030", "何明钦", "男");
            studengList.Add(stu30);

            Student stu31 = new Student("031", "姜玖林", "男");
            studengList.Add(stu31);
            Student stu32 = new Student("032", "涂才森", "男");
            studengList.Add(stu32);



            Student stu33 = new Student("033", "陈林", "男");
            studengList.Add(stu33);
            Student stu34 = new Student("034", "曾正男", "男");
            studengList.Add(stu34);

            Student stu35 = new Student("035", "江天宇", "男");
            studengList.Add(stu35);
            Student stu36 = new Student("036", "魏恩博", "男");
            studengList.Add(stu36);

            Student stu37 = new Student("037", "邹扬锋", "男");
            studengList.Add(stu37);
            Student stu38 = new Student("038", "曾琅", "男");
            studengList.Add(stu38);

            Student stu39 = new Student("039", "周成杰", "男");
            studengList.Add(stu39);

            Student stu40 = new Student("040", "马驰", "男");
            studengList.Add(stu40);

            Student stu41 = new Student("041", "宋树钱", "男");
            studengList.Add(stu41);
            Student stu42 = new Student("042", "马驰", "男");
            studengList.Add(stu42);
            Student stu43 = new Student("043", "任星辰", "男");
            studengList.Add(stu43);

            Student stu44 = new Student("044", "严一笑", "男");
            studengList.Add(stu44);
            Student stu45 = new Student("101", "孙颖", "女");
            studengList.Add(stu45);
            Student stu46 = new Student("102", "吴明益", "女");
            studengList.Add(stu46);
            Student stu47 = new Student("103", "黄耀萱", "女");
            studengList.Add(stu47);
            Student stu48 = new Student("104", "王静宜", "女");
            studengList.Add(stu48);
            Student stu49 = new Student("105", "蔡玉蓝", "女");
            studengList.Add(stu49);

            Student stu50 = new Student("106", "姜仪", "女");
            studengList.Add(stu50);

            Student stu51 = new Student("107", "郑雪", "女");
            studengList.Add(stu51);
            Student stu52 = new Student("108", "刘俊", "女");
            studengList.Add(stu52);
            Student stu53 = new Student("109", "何玉姣", "女");
            studengList.Add(stu53);
            Student stu54 = new Student("110", "匡小娟", "女");
            studengList.Add(stu54);
            Student stu55 = new Student("111", "王春兰", "女");
            studengList.Add(stu55);
            Student stu56 = new Student("112", "顾毓", "女");
            studengList.Add(stu56);
            Student stu57 = new Student("113", "师志杰", "男");
            studengList.Add(stu57);
            Student stu58 = new Student("114", "许佳文", "男");
            studengList.Add(stu58);
            Student stu59 = new Student("115", "雷安勇", "男");
            studengList.Add(stu59);

            Student stu60 = new Student("116", "张伟", "男");
            studengList.Add(stu60);


            Student stu61 = new Student("117", "袁志杰", "男");
            studengList.Add(stu61);
            Student stu62 = new Student("118", "何全江", "男");
            studengList.Add(stu62);
            Student stu63 = new Student("119", "舒鹏飞", "男");
            studengList.Add(stu63);
            Student stu64 = new Student("120", "何辉", "男");
            studengList.Add(stu64);
            Student stu65 = new Student("121", "李全喜", "男");
            studengList.Add(stu65);
            Student stu66 = new Student("122", "谢凯宇", "男");
            studengList.Add(stu66);
            Student stu67 = new Student("123", "黄本巍", "男");
            studengList.Add(stu67);
            Student stu68 = new Student("124", "罗俊杰", "男");
            studengList.Add(stu68);
            Student stu69 = new Student("125", "何宸锐", "男");
            studengList.Add(stu69);
            Student stu70 = new Student("126", "付昶宇", "男");
            studengList.Add(stu70);
            Student stu71 = new Student("127", "傅伟鑫", "男");
            studengList.Add(stu71);

            Student stu72 = new Student("128", "王云飞", "男");
            studengList.Add(stu72);

            Student stu73 = new Student("129", "李元港", "男");
            studengList.Add(stu73);

            Student stu74 = new Student("130", "赵荣泽", "男");
            studengList.Add(stu74);

            Student stu75 = new Student("131", "吴郑浩", "男");
            studengList.Add(stu75);

            Student stu76 = new Student("132", "何继武", "男");
            studengList.Add(stu76);

            Student stu77 = new Student("133", "郑博", "男");
            studengList.Add(stu77);

            Student stu78 = new Student("134", "王万成", "男");
            studengList.Add(stu78);

            Student stu79 = new Student("135", "陈杰", "男");
            studengList.Add(stu79);

            Student stu80 = new Student("136", "胡志伟", "男");
            studengList.Add(stu80);

            Student stu81 = new Student("137", "涂林", "男");
            studengList.Add(stu81);
            Student stu82 = new Student("138", "孟诚成", "男");
            studengList.Add(stu82);
            Student stu83 = new Student("139", "廖志丹", "男");
            studengList.Add(stu83);
            Student stu84 = new Student("140", "杨也", "女");
            studengList.Add(stu84);


            return studengList;
        }
    }
}
