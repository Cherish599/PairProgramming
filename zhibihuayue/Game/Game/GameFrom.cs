using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DaoLayer;
using Entity;
namespace Game
{
    public partial class GameFrom : Form
    {
        List<Dice> diceList;
        int i = 0;
        public GameFrom()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Dice2_TextChanged(object sender, EventArgs e)
        {

        }





        private void Label3_Click(object sender, EventArgs e)
        {


        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
 

        private void Label3_Click_1(object sender, EventArgs e)
        {
     
        }
     

        private void Button1_Click(object sender, EventArgs e)
        {
            if(i==0)
            {
                new False().Show();
                return;
            }
            Rollpic.Visible = true; 
            Random random = new Random();
            int n = random.Next(1, 6);
            if(n==1)
            {
                Num.Text = "   1";
            }
            if (n == 2)
            {
                Num.Text = "   2";
            }
            if (n == 3)
            {
                Num.Text = "   3";
            }
            if (n == 4)
            {
                Num.Text = "   4";
            }
            if (n == 5)
            {
                Num.Text = "   5";
            }
            if (n == 6)
            {
                Num.Text = "   6";

            }


            if (n == i)
            {
                Res.Text="你猜对了";
            }
            if (n > i)
            {
                Res.Text = "你猜小了";
            }
            if (n == i)
            {
                Res.Text = "你猜大了";
            }
        }

        private void Dice1_Click_1(object sender, EventArgs e)
        {
            gues.Text = " 1";
            i = 1;
        }

        private void Dice2_Click(object sender, EventArgs e)
        {
            gues.Text = " 2";
            i = 2;
        }

        private void Dice3_Click(object sender, EventArgs e)
        {
            gues.Text = " 3";
            i = 1;
        }

        private void Dice4_Click(object sender, EventArgs e)
        {
            gues.Text = " 5";
            i = 1;
        }

        private void Dice5_Click(object sender, EventArgs e)
        {
            gues.Text = " 5";
            i = 1;
        }

        private void Dice6_Click(object sender, EventArgs e)
        {
            gues.Text = " 6";
            i = 6;
        }

        public void Rollpic_Click(object sender, EventArgs e)
        {
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            i = 0;

            gues.Text = "预测";
            Res.Text = "游戏结果";
            Num.Text = "";
            Rollpic.Visible = false;
        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
