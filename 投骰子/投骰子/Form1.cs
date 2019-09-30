using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 投骰子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random rd = new Random();//创建一个可以生成随机的对象
           
            for (int i = 1; i <= 100; i++)
            {
               
                int point = rd.Next(1, 7);
                switch (point)
                {
                    case 1: { point1++; break; }
                    case 2: { point2++; break; }
                    case 3: { point3++; break; }
                    case 4: { point4++; break; }
                    case 5: { point5++; break; }
                    case 6: { point6++; break; }
                    default:
                        break;
                }
                //比较那个出现的次数最多
            }
            int[] array = new int[] { point1, point2, point3, point4, point5, point6 };
            if (point1==array.Max())
            {
                textBox8.Text = "成功！出现最多的点数为：1";
            }
            else { textBox8.Text = "失败！"; }
           
           
            
            
           
            textBox1.Text = "1点出现的次数为：" + point1;
            textBox2.Text = "2点出现的次数为：" + point2;
            textBox3.Text = "3点出现的次数为：" + point3;
            textBox4.Text = "4点出现的次数为：" + point4;
            textBox5.Text = "5点出现的次数为：" + point5;
            textBox6.Text = "6点出现的次数为：" + point6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random rd = new Random();//创建一个可以生成随机的对象
            
            for (int i = 1; i <= 100; i++)
            {

                int point = rd.Next(1, 7);
                switch (point)
                {
                    case 1: { point1++; break; }
                    case 2: { point2++; break; }
                    case 3: { point3++; break; }
                    case 4: { point4++; break; }
                    case 5: { point5++; break; }
                    case 6: { point6++; break; }
                    default:
                        break;
                }
                //比较那个出现的次数最多
            }
            int[] array = new int[] { point1, point2, point3, point4, point5, point6 };
            if (point2 == array.Max())
            {
                textBox8.Text = "成功！出现最多的点数为：2";
            }
            else { textBox8.Text = "失败！"; }
            textBox1.Text = "1点出现的次数为：" + point1;
            textBox2.Text = "2点出现的次数为：" + point2;
            textBox3.Text = "3点出现的次数为：" + point3;
            textBox4.Text = "4点出现的次数为：" + point4;
            textBox5.Text = "5点出现的次数为：" + point5;
            textBox6.Text = "6点出现的次数为：" + point6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random rd = new Random();//创建一个可以生成随机的对象
           
            for (int i = 1; i <= 100; i++)
            {

                int point = rd.Next(1, 7);
                switch (point)
                {
                    case 1: { point1++; break; }
                    case 2: { point2++; break; }
                    case 3: { point3++; break; }
                    case 4: { point4++; break; }
                    case 5: { point5++; break; }
                    case 6: { point6++; break; }
                    default:
                        break;
                }
                //比较那个出现的次数最多
            }
            int[] array = new int[] { point1, point2, point3, point4, point5, point6 };
            if (point3 == array.Max())
            {
                textBox8.Text = "成功！出现最多的点数为：3";
            }
            else { textBox8.Text = "失败！"; }
            textBox1.Text = "1点出现的次数为：" + point1;
            textBox2.Text = "2点出现的次数为：" + point2;
            textBox3.Text = "3点出现的次数为：" + point3;
            textBox4.Text = "4点出现的次数为：" + point4;
            textBox5.Text = "5点出现的次数为：" + point5;
            textBox6.Text = "6点出现的次数为：" + point6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random rd = new Random();//创建一个可以生成随机的对象
            
            for (int i = 1; i <= 100; i++)
            {

                int point = rd.Next(1, 7);
                switch (point)
                {
                    case 1: { point1++; break; }
                    case 2: { point2++; break; }
                    case 3: { point3++; break; }
                    case 4: { point4++; break; }
                    case 5: { point5++; break; }
                    case 6: { point6++; break; }
                    default:
                        break;
                }
                //比较那个出现的次数最多
            }
            int[] array = new int[] { point1, point2, point3, point4, point5, point6 };
            if (point4 == array.Max())
            {
                textBox8.Text = "成功！出现最多的点数为：4";
            }
            else { textBox8.Text = "失败！"; }
            textBox1.Text = "1点出现的次数为：" + point1;
            textBox2.Text = "2点出现的次数为：" + point2;
            textBox3.Text = "3点出现的次数为：" + point3;
            textBox4.Text = "4点出现的次数为：" + point4;
            textBox5.Text = "5点出现的次数为：" + point5;
            textBox6.Text = "6点出现的次数为：" + point6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random rd = new Random();//创建一个可以生成随机的对象
            
            for (int i = 1; i <= 100; i++)
            {

                int point = rd.Next(1, 7);
                switch (point)
                {
                    case 1: { point1++; break; }
                    case 2: { point2++; break; }
                    case 3: { point3++; break; }
                    case 4: { point4++; break; }
                    case 5: { point5++; break; }
                    case 6: { point6++; break; }
                    default:
                        break;
                }
                //比较那个出现的次数最多
            }
            int[] array = new int[] { point1, point2, point3, point4, point5, point6 };
            if (point5 == array.Max())
            {
                textBox8.Text = "成功！出现最多的点数为：5";
            }
            else { textBox8.Text = "失败！"; }
            textBox1.Text = "1点出现的次数为：" + point1;
            textBox2.Text = "2点出现的次数为：" + point2;
            textBox3.Text = "3点出现的次数为：" + point3;
            textBox4.Text = "4点出现的次数为：" + point4;
            textBox5.Text = "5点出现的次数为：" + point5;
            textBox6.Text = "6点出现的次数为：" + point6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random rd = new Random();//创建一个可以生成随机的对象
            
            for (int i = 1; i <= 100; i++)
            {

                int point = rd.Next(1, 7);
                switch (point)
                {
                    case 1: { point1++; break; }
                    case 2: { point2++; break; }
                    case 3: { point3++; break; }
                    case 4: { point4++; break; }
                    case 5: { point5++; break; }
                    case 6: { point6++; break; }
                    default:
                        break;
                }
                //比较那个出现的次数最多
            }
            int[] array = new int[] { point1, point2, point3, point4, point5, point6 };
            if (point6 == array.Max())
            {
                textBox8.Text = "成功！出现最多的点数为：6";
            }
            else { textBox8.Text = "失败！"; }
            textBox1.Text = "1点出现的次数为：" + point1;
            textBox2.Text = "2点出现的次数为：" + point2;
            textBox3.Text = "3点出现的次数为：" + point3;
            textBox4.Text = "4点出现的次数为：" + point4;
            textBox5.Text = "5点出现的次数为：" + point5;
            textBox6.Text = "6点出现的次数为：" + point6;
        }
    }
}
