using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.timerCallName.Enabled = true;
            this.progressName.Enabled = true;
        }

        private void timerCallName_Tick(object sender, EventArgs e)
        {
            progressName.Maximum = 12;
            for (; this.progressName.Value < 12;)
                this.progressName.Value += 1;



            string sql = string.Format("select * from tblStu");
            DataSet ds = connect.querysql(sql);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
