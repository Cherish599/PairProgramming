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

namespace PairPrograming
{
    public partial class Form1 : Form
    {
        List<Student> stuList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressName.Step = 1;
            progressName.Minimum = 0;
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();
            DataTable dt = new DataTable();
            dt.Columns.Add("stuID", Type.GetType("System.String"));
            dt.Columns.Add("stuName", Type.GetType("System.String"));
            dt.Columns.Add("缺勤此次数");
            progressName.Maximum = stuList.Count;
            foreach (Student stu in stuList)
            {
                dt.Rows.Add(stu.Id, stu.Name);
                progressName.PerformStep();
            }
            dataGridView1.DataSource = dt;
        }

        private void Rdchose_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int tmp = rd.Next(1, 84);
            Thread.Sleep(1);
            chosedstuin.Text = string.Format("学号:{0}  名字:{1}", stuList[tmp].Id,stuList[tmp].Name);
        }
    }
}
