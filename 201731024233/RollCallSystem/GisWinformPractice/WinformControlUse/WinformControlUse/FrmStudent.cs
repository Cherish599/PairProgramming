using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DaoLayer;
using Entity;
using System.Threading;

namespace WinformControlUse
{
    public partial class FrmStudent : Form
    {
        List<Student> stuList;

        bool flag = true;

        public FrmStudent()
        {
            InitializeComponent();
        }

        void iniControl()
        {
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnLoadStu.Enabled = true;
            sortBtn.Visible = false;
            autoButton.Visible = false;
        }

        void setControlVisible()
        {
            btnStart.Visible = true;
            btnStop.Visible = true;
            btnLoadStu.Visible = false;
            sortBtn.Visible = true;
            autoButton.Visible = true;
        }

        private void btnLoadStu_Click(object sender, EventArgs e)
        {          

            //获取学生数据源
            StudentDAO stuDao = new StudentDAO();
            stuList=stuDao.getAllStudents();

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
                dt.Rows.Add(stu.Id,stu.Name);
                progressName.Value += 1;//一个学生，进度条加1；
            }            
            
            dgvStuList.DataSource = dt;

            setControlVisible();

            this.studentsNum.Text = stuDao.getStudentRecordsNums().ToString();

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            iniControl();
        }

        private void timerCallName_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(stuList.Count);
            lblName.Text = stuList[i].Name;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            progressName.Value =0;
            //获取学生数据源
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();
            if (flag)
            {
                stuList.Sort((x, y) =>
                {
                    if (int.Parse(x.Id) < int.Parse(y.Id)) 
                    {
                        return -1;
                    }
                    else if (int.Parse(x.Id) > int.Parse(y.Id))
                    {
                        return 1;
                    }
                    else
                        return 0;
                }); 
                flag = false;
            }
            else {
                stuList.Sort((x, y) =>
                {
                    if (int.Parse(x.Id) > int.Parse(y.Id))
                    {
                        return -1;
                    }
                    else if (int.Parse(x.Id) < int.Parse(y.Id))
                    {
                        return 1;
                    }
                    else
                        return 0;
                });
                flag = true;
            }

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
            }

            dgvStuList.DataSource = dt;

            setControlVisible();

            //显式学生人数
            this.studentsNum.Text = "学生人数：" + stuDao.getStudentRecordsNums();
        }

        private void studentsNum_Click(object sender, EventArgs e)
        {

        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
            Thread thread3 = new Thread(() => {
                string curTime = (DateTime.Now.Second + 3).ToString();
                while (DateTime.Now.Second.ToString() != curTime)
                {
                }
                timerCallName.Stop();
            });
            thread3.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
