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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from tblStu where stuNo='{0}' or stuName ='{1}'", textsno.Text, textsname.Text);
            DataSet ds = connect .querysql(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
