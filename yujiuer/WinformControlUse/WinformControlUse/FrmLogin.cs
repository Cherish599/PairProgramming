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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string name = this.TBname.Text;
            string password = this.TBpwd.Text;
            if (name.Equals("黄老师") && password.Equals("123"))
            {
                FrmStudent frm = new FrmStudent();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }
        private void Esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
