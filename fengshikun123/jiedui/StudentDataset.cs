using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using Entity;

namespace Base
{
    public class StudentDataset
    {
        //学生集合

        private static List<Student> studengList;//定义学生集合
        public static List<Student> getAll()//返回集合
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

            Student stu40 = new Student("040", "马驰");
            studengList.Add(stu40);

            Student stu41 = new Student("041", "宋树钱");
            studengList.Add(stu41);
            Student stu42 = new Student("042", "马驰");
            studengList.Add(stu42);
            Student stu43 = new Student("043", "任星辰");
            studengList.Add(stu43);

            Student stu44 = new Student("044", "严一笑");
            studengList.Add(stu44);
            Student stu45 = new Student("045", "孙颖");
            studengList.Add(stu45);
            Student stu46 = new Student("046", "吴明益");
            studengList.Add(stu46);
            Student stu47 = new Student("047", "黄耀萱");
            studengList.Add(stu47);
            Student stu48 = new Student("048", "王静宜");
            studengList.Add(stu48);
            Student stu49 = new Student("049", "蔡玉蓝");
            studengList.Add(stu49);

            Student stu50 = new Student("050", "姜仪");
            studengList.Add(stu50);

            Student stu51 = new Student("051", "郑雪");
            studengList.Add(stu51);
            Student stu52 = new Student("052", "刘俊");
            studengList.Add(stu52);
            Student stu53 = new Student("053", "何玉姣");
            studengList.Add(stu53);
            Student stu54 = new Student("054", "匡小娟");
            studengList.Add(stu54);
            Student stu55 = new Student("055", "王春兰");
            studengList.Add(stu55);
            Student stu56 = new Student("056", "顾毓");
            studengList.Add(stu56);
            Student stu57 = new Student("057", "师志杰");
            studengList.Add(stu57);
            Student stu58 = new Student("058", "许佳文");
            studengList.Add(stu58);
            Student stu59 = new Student("059", "雷安勇");
            studengList.Add(stu59);

            Student stu60 = new Student("060", "张伟");
            studengList.Add(stu60);


            Student stu61 = new Student("061", "袁志杰");
            studengList.Add(stu61);
            Student stu62 = new Student("062", "何全江");
            studengList.Add(stu62);
            Student stu63 = new Student("063", "舒鹏飞");
            studengList.Add(stu63);
            Student stu64 = new Student("064", "何辉");
            studengList.Add(stu64);
            Student stu65 = new Student("065", "李全喜");
            studengList.Add(stu65);
            Student stu66 = new Student("066", "谢凯宇");
            studengList.Add(stu66);
            Student stu67 = new Student("067", "黄本巍");
            studengList.Add(stu67);
            Student stu68 = new Student("068", "罗俊杰");
            studengList.Add(stu68);
            Student stu69 = new Student("069", "何宸锐");
            studengList.Add(stu69);
            Student stu70 = new Student("070", "付昶宇");
            studengList.Add(stu70);
            Student stu71 = new Student("071", "傅伟鑫");
            studengList.Add(stu71);

            Student stu72 = new Student("072", "王云飞");
            studengList.Add(stu72);

            Student stu73 = new Student("073", "李元港");
            studengList.Add(stu73);

            Student stu74 = new Student("074", "赵荣泽");
            studengList.Add(stu74);

            Student stu75 = new Student("075", "吴郑浩");
            studengList.Add(stu75);

            Student stu76 = new Student("076", "何继武");
            studengList.Add(stu76);

            Student stu77 = new Student("077", "郑博");
            studengList.Add(stu77);

            Student stu78 = new Student("078", "王万成");
            studengList.Add(stu78);

            Student stu79 = new Student("079", "陈杰");
            studengList.Add(stu79);

            Student stu80 = new Student("080", "胡志伟");
            studengList.Add(stu80);

            Student stu81 = new Student("081", "涂林");
            studengList.Add(stu81);
            Student stu82 = new Student("082", "孟诚成");
            studengList.Add(stu82);
            Student stu83 = new Student("083", "廖志丹");
            studengList.Add(stu83);
            Student stu84 = new Student("084", "杨也");
            studengList.Add(stu84);
            return studengList;
        }
    }
}
