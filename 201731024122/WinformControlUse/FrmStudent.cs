using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

using DaoLayer;
using Entity;
using System.Threading;


namespace WinformControlUse
{
    public partial class FrmStudent : Form
    {
        ArrayList absenceName = new ArrayList();
        ArrayList askForLeaveName = new ArrayList();
        List<Student> stuList;
        public FrmStudent()
        {
            InitializeComponent();
            timer1.Start();
        }

        void iniControl()
        {
            btnStart.Visible = false;
            btnLoadStu.Enabled = true;
            butResult.Visible = false;
            butSave.Visible = false;
        }

        void setControlVisible()
        {
            btnStart.Visible = true;
            btnLoadStu.Visible = false;
            butResult.Visible = true;
            butSave.Visible = true;
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
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();
          

            for (int i = 0; i < dgvStuList.Rows.Count; i++)
                {
                    string _selectValue = dgvStuList.Rows[i].Cells["stuCheck"].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                {
                    absenceName.Add(stuList[i].Name);
                }
                }
            for (int i = 0; i < dgvStuList.Rows.Count; i++)
            {
                string _selectValue = dgvStuList.Rows[i].Cells["stuCause"].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                {
                    askForLeaveName.Add(stuList[i].Name);
                }
            }

            MessageBox.Show("本次应到学生：" + stuList.Count + "人，缺席：" + absenceName.Count + "人，请假人数："+ askForLeaveName.Count +"人");
            //测试代码
            FileStream fs = File.Create(@"C:/test.txt");
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(absenceName.Count);
            sw.Close();
            fs.Close();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //文件保存的路径
            saveFileDialog1.FilterIndex = 1;
            //默认选为txt文件
            saveFileDialog1.RestoreDirectory = true;
            //默认保存路径为桌面
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {
                //写入结果
                myStream = new StreamWriter(saveFileDialog1.FileName);
                myStream.WriteLine("本次应到学生：" + stuList.Count + "人，缺席：" + absenceName.Count + "人，请假人数：" + absenceName.Count + "人"); 
                myStream.Write("缺席学生姓名：");
                foreach (string i in absenceName)
                {
                    myStream.Write(i + ",");
                }
                myStream.Write("。请假学生姓名：");
                foreach (string i in askForLeaveName)
                {
                    myStream.Write(i + ",");
                }
                myStream.Write("。");
                myStream.WriteLine(DateTime.Now);
                myStream.Close();//关闭流

            }

        }
        private void label3_Click(object sender, EventArgs e)
        { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
