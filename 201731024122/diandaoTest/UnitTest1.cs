using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinformControlUse;
using Entity;
using DaoLayer;
using System.Collections.Generic;
using System.Collections;
using DataBase;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<Student> stuList;
        List<Student> Test1 = null;
        [TestMethod]              /**测试随机点到的同学是否是有重复，且是否为”真随机点到“
                                    由于Winform和任务台不一样在此重新写一个相同的功能方法给任务台
                                 **/
        public void TestMethod1()
        {
            for (int time = 100; time > 0; time--)//随机点到30次
            {
                int p = 30;//随机点到30人，全班一共39人
                Test1 = new List<Student>();
                studentDAO stuDao = new studentDAO();
                stuList = stuDao.getAllStudents();
                if (p > stuList.Count || p < 0)
                {
                    Console.WriteLine("输入有误！");
                }
                else
                {
                    for (int i = 0; i < p; i++)//防止随机到同一位同学
                    {
                        Random r = new Random(GetRandomSeed());
                        int m = r.Next(stuList.Count);
                        if (Test1 == null || !Test1.Contains(stuList[m]))
                            Test1.Add(stuList[m]);
                        else
                            p++;         //若已经随机到这位同学，则再随即一次

                    }
                }
                for (int i = 0; i < Test1.Count; i++) //检验结果是否含有重复的同学
                {
                    for (int j = i + 1; j < Test1.Count; j++)
                    {
                        if (Test1[i] == Test1[j])
                        {
                            Assert.IsFalse(true);
                        }
                    }
                }
            }
        }
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);

        }
    }

}