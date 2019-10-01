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
using RecordData;

namespace WinFromDianMing
{
    public partial class FormStudet : Form
    {
        List<Student> stuList;
        public FormStudet()
        {
            InitializeComponent();
        }
        void iniControl()
        {
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnRecord.Visible = false;
            btnLoadStu.Enabled = true;
        }

        void setControlVisible()
        {
            btnStart.Visible = true;
            btnStop.Visible = true;
            btnRecord.Visible = true;
            btnLoadStu.Visible = false;
        }

        private void btnLoadStu_Click(object sender, EventArgs e)
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
            dt.Columns.Add("stuSex", Type.GetType("System.String"));

            //数据加载以进度条方式展现
            foreach (Student stu in stuList)
            {
                dt.Rows.Add(stu.Id, stu.Name, stu.Sex);
                progressName.Value += 1;//一个学生，进度条加1；
                Thread.Sleep(50);
            }

            dataGVList.DataSource = dt;

            setControlVisible();

        }

        DianMingRecord DianMiandata = new DianMingRecord();//一个记录对象

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            iniControl();
        }

        private void timerCountStu_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(stuList.Count);
            lblName.Text = stuList[i].Name;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerCountStu.Start();
            btnRecord.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCountStu.Stop();
            DianMiandata.DMrecord(lblName.Text);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string data = DianMiandata.ShowRecord();
            ShowRecordData SData = new ShowRecordData(data);            
            btnRecord.Enabled = false;
            DialogResult dr = SData.ShowDialog();
            if (dr == DialogResult.OK)
            { ClearData(); SData.Show(); }
        }

        public void ClearData()
        {
            for (int L = 0; L < DianMiandata.recordData.Length; L++)
                DianMiandata.recordData[L] = null;
        }
    }
}
