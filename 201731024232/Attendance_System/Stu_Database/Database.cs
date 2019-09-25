using System;
using Stu_Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stu_Database
{
    public class Databse
    {
        //模拟数据库中的学生集合

        private static List<Entity> studengList;


        public static List<Entity> getAll()// 学生信息库
        {
            studengList = new List<Entity>();

            Entity stu1 = new Entity("001", "王川",0);
            studengList.Add(stu1);
            Entity stu2 = new Entity("002", "于丁", 0);
            studengList.Add(stu2);

            Entity stu3 = new Entity("003", "张莹", 0);
            studengList.Add(stu3);
            Entity stu4 = new Entity("004", "李楠", 0);
            studengList.Add(stu4);

            Entity stu5 = new Entity("005", "陈欣", 0);
            studengList.Add(stu5);
            Entity stu6 = new Entity("006", "马芸慧",0);
            studengList.Add(stu6);

            Entity stu7 = new Entity("007", "汪小萍", 0);
            studengList.Add(stu7);
            Entity stu8 = new Entity("008", "母丹", 0);
            studengList.Add(stu8);


            Entity stu9 = new Entity("009", "许博", 0);
            studengList.Add(stu9);
            Entity stu10 = new Entity("010", "芦文钰", 0);
            studengList.Add(stu10);

            Entity stu11 = new Entity("011", "马昊妍", 0);
            studengList.Add(stu11);
            Entity stu12 = new Entity("012", "李宣晓", 0);
            studengList.Add(stu12);

            Entity stu13 = new Entity("013", "李清兰", 0);
            studengList.Add(stu13);
            Entity stu14 = new Entity("014", "成湘", 0);
            studengList.Add(stu14);

            Entity stu15 = new Entity("015", "罗涵", 0);
            studengList.Add(stu15);
            Entity stu16 = new Entity("016", "肖逸菲", 0);
            studengList.Add(stu16);

            Entity stu17 = new Entity("017", "冯士坤", 0);
            studengList.Add(stu17);
            Entity stu18 = new Entity("018", "杨汶桐", 0);
            studengList.Add(stu18);

            Entity stu19 = new Entity("019", "张焱菁", 0);
            studengList.Add(stu19);
            Entity stu20 = new Entity("020", "雷槟源", 0);
            studengList.Add(stu20);

            Entity stu21 = new Entity("021", "李志", 0);
            studengList.Add(stu21);
            Entity stu22 = new Entity("022", "黄涛", 0);
            studengList.Add(stu22);

            Entity stu23 = new Entity("023", "宋杰", 0);
            studengList.Add(stu23);
            Entity stu24 = new Entity("024", "赵俊安", 0);
            studengList.Add(stu24);


            Entity stu25 = new Entity("025", "张新明", 0);
            studengList.Add(stu25);
            Entity stu26 = new Entity("026", "张旭", 0);
            studengList.Add(stu26);

            Entity stu27 = new Entity("027", "王旭", 0);
            studengList.Add(stu27);
            Entity stu28 = new Entity("028", "李朋珂", 0);
            studengList.Add(stu28);

            Entity stu29 = new Entity("029", "张微玖", 0);
            studengList.Add(stu29);
            Entity stu30 = new Entity("030", "何明钦", 0);
            studengList.Add(stu30);

            Entity stu31 = new Entity("031", "姜玖林", 0);
            studengList.Add(stu31);
            Entity stu32 = new Entity("032", "涂才森", 0);
            studengList.Add(stu32);



            Entity stu33 = new Entity("033", "陈林", 0);
            studengList.Add(stu33);
            Entity stu34 = new Entity("034", "曾正男", 0);
            studengList.Add(stu34);

            Entity stu35 = new Entity("035", "江天宇", 0);
            studengList.Add(stu35);
            Entity stu36 = new Entity("036", "魏恩博", 0);
            studengList.Add(stu36);

            Entity stu37 = new Entity("037", "邹扬锋", 0);
            studengList.Add(stu37);
            Entity stu38 = new Entity("038", "曾琅", 0);
            studengList.Add(stu38);

            Entity stu39 = new Entity("039", "周成杰", 0);
            studengList.Add(stu39);

            Entity stu40 = new Entity("040", "马驰", 0);
            studengList.Add(stu40);

            Entity stu41 = new Entity("041", "宋树钱", 0);
            studengList.Add(stu41);
            Entity stu42 = new Entity("042", "马驰", 0);
            studengList.Add(stu42);
            Entity stu43 = new Entity("043", "任星辰", 0);
            studengList.Add(stu43);

            Entity stu44 = new Entity("044", "严一笑", 0);
            studengList.Add(stu44);
            Entity stu45 = new Entity("045", "孙颖", 0);
            studengList.Add(stu45);
            Entity stu46 = new Entity("046", "吴明益", 0);
            studengList.Add(stu46);
            Entity stu47 = new Entity("047", "黄耀萱", 0);
            studengList.Add(stu47);
            Entity stu48 = new Entity("048", "王静宜", 0);
            studengList.Add(stu48);
            Entity stu49 = new Entity("049", "蔡玉蓝", 0);
            studengList.Add(stu49);

            Entity stu50 = new Entity("050", "姜仪", 0);
            studengList.Add(stu50);

            Entity stu51 = new Entity("051", "郑雪", 0);
            studengList.Add(stu51);
            Entity stu52 = new Entity("052", "刘俊", 0);
            studengList.Add(stu52);
            Entity stu53 = new Entity("053", "何玉姣", 0);
            studengList.Add(stu53);
            Entity stu54 = new Entity("054", "匡小娟", 0);
            studengList.Add(stu54);
            Entity stu55 = new Entity("055", "王春兰", 0);
            studengList.Add(stu55);
            Entity stu56 = new Entity("056", "顾毓", 0);
            studengList.Add(stu56);
            Entity stu57 = new Entity("057", "师志杰", 0);
            studengList.Add(stu57);
            Entity stu58 = new Entity("058", "许佳文", 0);
            studengList.Add(stu58);
            Entity stu59 = new Entity("059", "雷安勇", 0);
            studengList.Add(stu59);

            Entity stu60 = new Entity("060", "张伟", 0);
            studengList.Add(stu60);


            Entity stu61 = new Entity("061", "袁志杰", 0);
            studengList.Add(stu61);
            Entity stu62 = new Entity("062", "何全江", 0);
            studengList.Add(stu62);
            Entity stu63 = new Entity("063", "舒鹏飞", 0);
            studengList.Add(stu63);
            Entity stu64 = new Entity("064", "何辉", 0);
            studengList.Add(stu64);
            Entity stu65 = new Entity("065", "李全喜", 0);
            studengList.Add(stu65);
            Entity stu66 = new Entity("066", "谢凯宇", 0);
            studengList.Add(stu66);
            Entity stu67 = new Entity("067", "黄本巍", 0);
            studengList.Add(stu67);
            Entity stu68 = new Entity("068", "罗俊杰", 0);
            studengList.Add(stu68);
            Entity stu69 = new Entity("069", "何宸锐", 0);
            studengList.Add(stu69);
            Entity stu70 = new Entity("070", "付昶宇", 0);
            studengList.Add(stu70);
            Entity stu71 = new Entity("071", "傅伟鑫", 0);
            studengList.Add(stu71);

            Entity stu72 = new Entity("072", "王云飞", 0);
            studengList.Add(stu72);

            Entity stu73 = new Entity("073", "李元港", 0);
            studengList.Add(stu73);

            Entity stu74 = new Entity("074", "赵荣泽", 0);
            studengList.Add(stu74);

            Entity stu75 = new Entity("075", "吴郑浩", 0);
            studengList.Add(stu75);

            Entity stu76 = new Entity("076", "何继武", 0);
            studengList.Add(stu76);

            Entity stu77 = new Entity("077", "郑博", 0);
            studengList.Add(stu77);

            Entity stu78 = new Entity("078", "王万成", 0);
            studengList.Add(stu78);

            Entity stu79 = new Entity("079", "陈杰", 0);
            studengList.Add(stu79);

            Entity stu80 = new Entity("080", "胡志伟", 0);
            studengList.Add(stu80);

            Entity stu81 = new Entity("081", "涂林", 0);
            studengList.Add(stu81);
            Entity stu82 = new Entity("082", "孟诚成", 0);
            studengList.Add(stu82);
            Entity stu83 = new Entity("083", "廖志丹", 0);
            studengList.Add(stu83);
            Entity stu84 = new Entity("084", "杨也", 0);
            studengList.Add(stu84);


            return studengList;
        }
    }
}
