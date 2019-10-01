using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DaoLayer;
using StuData;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class FrmStudent : Form
    {
        List<Student> stuList;

        public FrmStudent()
        {
            InitializeComponent();
        }

        void iniControl()
        {
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnLoadStu.Enabled = true;
        }

        void setControlVisible()
        {
            btnStart.Visible = true;
            btnStop.Visible = true;
            btnLoadStu.Visible = false;
        }

        private void btnLoadStu_Click_1(object sender, EventArgs e)
        {
            
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();

            
            int stuCounts = stuList.Count;
            progressName.Maximum = stuCounts;


           
            DataTable dt = new DataTable();
            dt.Columns.Add("stuID", Type.GetType("System.String"));
            dt.Columns.Add("stuName", Type.GetType("System.String"));
            dt.Columns.Add("stuSex", Type.GetType("System.String"));

            
            foreach (Student stu in stuList)
            {
                dt.Rows.Add(stu.Id , stu.Name, stu.Sex);
                progressName.Value += 1;
                Thread.Sleep(500);
            }


            dgvStuList.DataSource = dt;

            setControlVisible();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }

        private void timerCallName_Tick_1(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(stuList.Count);
            labName.Text = stuList[i].Name;
        }

        private void FrmStudent_Load_1(object sender, EventArgs e)
        {
            iniControl();
        }
    }
}