using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaoLayer;
using Entity;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Formstudent : Form
    {
        List<Student> stuList;
        public Formstudent()
        {
            InitializeComponent();
        }

        private void dgvStuList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(stuList.Count);
            lblName.Text = stuList[i].Name;
        }

        private void btnLoadstu_Click(object sender, EventArgs e)
        {
            //获取学生数据源
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();

            //进度条设置
            int stuCounts = stuList.Count;//及时学生人数
            progressName.Maximum = stuCounts;


            //构造数据源
            DataTable dt = new DataTable();
            dt.Columns.Add("stuID", Type.GetType("System.String"));
            dt.Columns.Add("stuName", Type.GetType("System.String"));

            //数据加载以进度条方式展现
            foreach (Student stu in stuList)
            {
                dt.Rows.Add(stu.Id, stu.Name);
                progressName.Value += 1;//一个学生，进度条加1；
                Thread.Sleep(500);
            }

            dgvStuList.DataSource = dt;

            //setControlVisible();
        }
    }
}
