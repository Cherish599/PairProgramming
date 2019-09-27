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

        public FrmStudent()
        {
            InitializeComponent();
        }

        void iniControl()
        {
            btnStart.Visible = false;
            btnLoadStu.Enabled = true;
            butResult.Visible = false;
        }

        void setControlVisible()
        {
            btnStart.Visible = true;
            btnLoadStu.Visible = false;
            butResult.Visible = true;
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
                Thread.Sleep(50);                
            }
            dgvStuList.DataSource = dt;
            setControlVisible();
            stuNum.Text = stuCounts.ToString();
            

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
            testQuanity t = new testQuanity();
            t.ShowDialog();
        }


        private void progressName_Click(object sender, EventArgs e)
        {
        }

        private void dgvStuList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stuNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void butResult_Click(object sender, EventArgs e)
        {
            int m = 0;
            int n = 0;
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();

            for (int i = 0; i < dgvStuList.Rows.Count; i++)
                {
                    string _selectValue = dgvStuList.Rows[i].Cells["stuCheck"].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                    m++;
                }
            for (int i = 0; i < dgvStuList.Rows.Count; i++)
            {
                string _selectValue = dgvStuList.Rows[i].Cells["stuCause"].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                    n++;
            }
            MessageBox.Show("本次应到学生：" + stuList.Count + "人，缺席：" + m + "人，请假人数："+n+"人");
            
        }
    }
}
