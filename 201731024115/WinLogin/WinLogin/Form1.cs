using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLogin
{
    public partial class WinLogin : Form
    {
        public WinLogin()
        {
            InitializeComponent();
        }

        private void btmLogin_Click(object sender, EventArgs e)
        {

            string sql = string.Format("select * from tbluser where username='{0}' and userpwd='{1}'", txtName.Text, txtPwd.Text);
            DataSet ds = Common.QuerySql(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                FrmStudent f = new FrmStudent();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btmCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
