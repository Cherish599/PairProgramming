using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformControlUse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            string url = "https://ss1.baidu.com/6ONXsjip0QIZ8tyhnq/it/u=3385483474,3738423908&fm=58&bpow=1276&bpoh=1280.jpg";
            this.pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressbarLogin.Value < progressbarLogin.Maximum)
            {
                progressbarLogin.Value++;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                MessageBox.Show(tutorId.Text[0].ToString()+"老师，欢迎使用本系统");
                FrmStudent f1 = new FrmStudent();
                f1.ShowDialog();
                //进度条加载完弹出使用界面
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (tutorId.Text == "")
                MessageBox.Show("用户名不能为空!", "提示");
            else
            {
                progressbarLogin.Value = 0;
                progressbarLogin.Minimum = 0;
                progressbarLogin.Maximum = 10;
                timer1.Enabled = true;//启动计时器
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
