using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 结对编程
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
            DataSet ds = connect.querysql(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                Form1  f = new Form1 ();
                f.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }
    }
}
