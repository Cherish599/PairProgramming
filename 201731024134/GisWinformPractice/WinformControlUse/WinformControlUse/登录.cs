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
            if (name.Equals("swpu") && password.Equals("123456"))
            {
                FrmStudent frm = new FrmStudent();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
