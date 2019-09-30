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
using System.IO;

namespace WinformControlUse
{
    public partial class FrmStudent : Form
    {
       public  List<Student> stuList;

        public FrmStudent()
        {
            InitializeComponent();
        }

        void IniControl()
        {
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnLoadStu.Enabled = true;            
        }

        void SetControlVisible()
        {
            btnStart.Visible = true;
            btnStop.Visible = true;
            btnLoadStu.Visible = false;           
        }

        private void BtnLoadStu_Click(object sender, EventArgs e)
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
                Thread.Sleep(10);                
            }            
            
            dgvStuList.DataSource = dt;

            SetControlVisible();

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            IniControl();
        }
        //修改代码
        int i = 0;
        public  void   TimerCallName_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
             i = ra.Next(stuList.Count);
            lblName.Text = stuList[i].Name;                                                 
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
            //调用记录缺课次数的方法
            AbsentTems();
        }

        //记录学生缺课名单及其次数
        public  void  AbsentTems()
        {
            string Str = stuList[i].Name;
           
            if (MessageBox.Show("该学生是否缺课？", "Absent OR Not?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {             
               
                if (Str.EndsWith ("S")==true  )
                {
                    stuList[i].Name += "T";
                    string Strpath3 = @"F:\软件工程文件\GisWinformPractice\WinformControlUse\TestFile\ThirdAbsent";
                    File.AppendAllText(Strpath3, Str + " ");
                    MessageBox.Show("取消考试资格来年重修！！！");
                }
               
               else  if (Str.EndsWith ("F") == true )
                {
                    //第四次尝试修改
                    stuList[i].Name += "S";
                    string Strpath2 = @"F:\软件工程文件\GisWinformPractice\WinformControlUse\TestFile\SecondAbsent";
                    File.AppendAllText(Strpath2, Str + " ");
                    MessageBox.Show("第二次缺课，离重修更进一步！！");
                }

                else 
                {
                    stuList[i].Name += "F";
                    string Strpath1 = @"F:\软件工程文件\GisWinformPractice\WinformControlUse\TestFile\FirstAbsent";
                    File.AppendAllText(Strpath1, Str + " ");
                    MessageBox.Show("第一次缺课，第一次重修半价哦！");
                }
            }     
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
