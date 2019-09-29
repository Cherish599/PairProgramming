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
    public partial class 登录 : Form
    {
        public 登录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (name.Equals("201731024119") && password.Equals("123456"))
            {
                MessageBox.Show("登录成功");
                FrmStudent frm = new FrmStudent();
                frm.Show();

            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
