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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerCallName.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }

        private void timerCallName_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(30);
            string sql = string.Format("select * from tblStu");
            DataSet ds = connect.querysql(sql);
            Label1.Text = Convert.ToString(ds.Tables[0].Rows[i]["stuName"]);
            
        }
    }
}
