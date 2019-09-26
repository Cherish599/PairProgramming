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
        int tmp;
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
                dt.Rows.Add(stu.Id, stu.Name, stu.TimeAbence);
                progressName.PerformStep();
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 120;
        }

        private void Rdchose_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            tmp = rd.Next(1, 84);
            Thread.Sleep(1);
            chosedstuin.Text = "学号:" + stuList[tmp].Id +" "+"姓名:"+stuList[tmp].Name;
        }

        private void absence_Click(object sender, EventArgs e)
        {
            stuList[tmp].TimeAbence++;
            int TimeAbsenceTmp = Convert.ToInt32(this.dataGridView1.Rows[tmp].Cells[2].Value);
            this.dataGridView1.Rows[tmp].Cells[2].Value = TimeAbsenceTmp + 1;
        }
    }
}
