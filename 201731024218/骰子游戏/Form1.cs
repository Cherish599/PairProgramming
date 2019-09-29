using System;
using System.Drawing;
using System.Windows.Forms;

namespace 骰子游戏
{
    public partial class Form1 : Form
    {
        Touzi touzi = new Touzi();
        int DaOrXiao=1;          //表示猜测是大还是小，1为大，2为小
        int result;             //表示结果是大还是小 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL =  @"音乐\卢冠廷 - 賭神.mp3";
        }


        //点击大，将猜测结果变为大，lable1的文本变为：当前选择：大
        private void PbDa_Click(object sender, EventArgs e)
        {
            DaOrXiao = 1;
            label1.Text = "当前选择：大";
        }


        //点击小，将猜测结果变为小，lable1的文本变为：当前选择：小
        private void PbXiao_Click(object sender, EventArgs e)
        {
            DaOrXiao = 0;
            label1.Text = "当前选择：小";
        }

        //点击开始是将BGM变为赌神，启用时钟
        private void BtnStart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL =@"音乐\卢冠廷 - 賭神.mp3";
            timer1.Enabled = true;
        }


        //随机一个骰子点数并将图片变为对应的图片
        private void Timer1_Tick(object sender, EventArgs e)
        {
            touzi.Dice();
            string picPAth;
            switch (touzi.Num)
            {
                case 1:
                    picPAth = @"图片\1.jpg";
                    result = 0;
                    break;
                case 2:
                    picPAth = @"图片\2.jpg";
                    result = 0;
                    break;
                case 3:
                    picPAth = @"图片\3.jpg";
                    result = 0;
                    break;
                case 4:
                    picPAth = @"图片\4.jpg";
                    result = 1;
                    break;
                case 5:
                    picPAth = @"图片\5.jpg";
                    result = 1;
                    break;
                case 6:
                    picPAth= @"图片\6.jpg";
                    result = 1;
                    break;
                default:picPAth = null;
                    break;
            }
            Bitmap bp = new Bitmap(picPAth);
            pictureBox1.Image = bp;
        }


        //点击停时，时钟停止，判断输赢并播放对应BGM
        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (result==DaOrXiao)
            {
                axWindowsMediaPlayer1.URL = @"音乐\Ozo - Epic Sax Guy.mp3";
                Bitmap bm = new Bitmap(@"图片\win.gif");
                pictureBox2.Image = bm;
            }
            else
            {
                axWindowsMediaPlayer1.URL = @"音乐\阿炳 - 二泉映月.mp3";
                Bitmap bm = new Bitmap(@"图片\lose.gif");
                pictureBox2.Image = bm;
            }
        }
    }
}
