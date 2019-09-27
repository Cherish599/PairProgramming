using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Stu_Entity;
using Stu_Layer;


namespace Attendance_System
{
    public partial class Form2 : Form
    {
        public int i;
        List<Entity> stuList;
        Layer Stulayer = new Layer();


        public Form2()
        {
            InitializeComponent();
            Layer Stulayer = new Layer();
            stuList = Stulayer.getAllStudents();//获取学生数据

            DataTable dt = new DataTable();
            dt.Columns.Add("stuNo", Type.GetType("System.String"));
            dt.Columns.Add("stuName", Type.GetType("System.String"));
            dt.Columns.Add("abs", Type.GetType("System.String"));//构造数据源

            foreach (Entity  stu in stuList)
            {
                dt.Rows.Add(stu.Id, stu.Name,stu.Abse);
            }


            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        public void TimerCallName_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
             i = ra.Next(stuList.Count);
            label2.Text = stuList[i].Name;

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }

        private void BtnAbs_Click(object sender, EventArgs e)
        {

            stuList[i].Abse= stuList[i].Abse+1;
            MessageBox.Show("添加成功！");
        }
    }
}
