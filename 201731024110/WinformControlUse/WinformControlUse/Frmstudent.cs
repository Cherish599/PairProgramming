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
   
    public partial class Frmstudent : Form
    {
        List<Student> stuList;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvStuList;
        private DataGridViewTextBoxColumn stuID;
        private DataGridViewTextBoxColumn stuName;
        private ProgressBar progressName;
        private Panel panel2;
        private Button btnLoadStu;
        private Button btnStop;
        private Button btnStart;
        private Panel panel;
        private System.Windows.Forms.Timer timerCallName;
        private Button lblName;
        private DataGridView queke;
        private DataGridViewTextBoxColumn sno;
        private DataGridViewTextBoxColumn sname;
        private IContainer components;
        

        public Frmstudent()
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

        //public void btnLoadStu_Click(object sender, EventArgs e)
        //{

        //    //获取学生数据源
        //    StudentDAO stuDao = new StudentDAO();
        //    stuList = stuDao.getAllStudents();

        //    //进度条设置
        //    int stuCounts = stuList.Count;//及时学生人数
        //    progressName.Maximum = stuCounts;


        //    //构造数据源
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("stuID", Type.GetType("System.String"));
        //    dt.Columns.Add("stuName", Type.GetType("System.String"));

        //    //数据加载以进度条方式展现
        //    foreach (Student stu in stuList)
        //    {
        //        dt.Rows.Add(stu.Id, stu.Name);
        //        progressName.Value += 1;//一个学生，进度条加1；
        //        Thread.Sleep(100);
        //    }

        //    dgvStuList.DataSource = dt;

        //    // setControlVisible();

        //}

        //public void FrmStudent_Load(object sender, EventArgs e)
        //{
        //    iniControl();
        //}

        //public void timerCallName_Tick(object sender, EventArgs e)
        //{
        //    Random ra = new Random();
        //    int i = ra.Next(stuList.Count);
        //    panel.Text = stuList[i].Name;
        //}

        //public void btnStart_Click(object sender, EventArgs e)
        //{
        //    timerCallName.Start();
        //}

        //public void btnStop_Click(object sender, EventArgs e)
        //{
        //    timerCallName.Stop();
        //}

        //public void panel4_Paint(object sender, PaintEventArgs e)
        //{

        //}

        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.stuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressName = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadStu = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Button();
            this.timerCallName = new System.Windows.Forms.Timer(this.components);
            this.queke = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生列表";
            // 
            // dgvStuList
            // 
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuID,
            this.stuName});
            this.dgvStuList.Location = new System.Drawing.Point(0, 40);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.RowTemplate.Height = 23;
            this.dgvStuList.Size = new System.Drawing.Size(657, 150);
            this.dgvStuList.TabIndex = 1;
            // 
            // stuID
            // 
            this.stuID.DataPropertyName = "stuID";
            this.stuID.HeaderText = "学号";
            this.stuID.Name = "stuID";
            this.stuID.Width = 300;
            // 
            // stuName
            // 
            this.stuName.DataPropertyName = "stuName";
            this.stuName.HeaderText = "姓名";
            this.stuName.Name = "stuName";
            this.stuName.Width = 300;
            // 
            // progressName
            // 
            this.progressName.Location = new System.Drawing.Point(0, 187);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(657, 27);
            this.progressName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoadStu);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnLoadStu
            // 
            this.btnLoadStu.Location = new System.Drawing.Point(496, 6);
            this.btnLoadStu.Name = "btnLoadStu";
            this.btnLoadStu.Size = new System.Drawing.Size(75, 23);
            this.btnLoadStu.TabIndex = 0;
            this.btnLoadStu.Text = "加载学生";
            this.btnLoadStu.UseVisualStyleBackColor = true;
            this.btnLoadStu.Click += new System.EventHandler(this.btnLoadStu_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(231, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(100, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.lblName);
            this.panel.Location = new System.Drawing.Point(0, 258);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(657, 76);
            this.panel.TabIndex = 4;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(0, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(657, 68);
            this.lblName.TabIndex = 0;
            this.lblName.UseVisualStyleBackColor = false;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // timerCallName
            // 
            this.timerCallName.Interval = 50;
            this.timerCallName.Tick += new System.EventHandler(this.timerCallName_Tick_1);
            // 
            // queke
            // 
            this.queke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.sname});
            this.queke.Location = new System.Drawing.Point(0, 335);
            this.queke.Name = "queke";
            this.queke.RowTemplate.Height = 27;
            this.queke.Size = new System.Drawing.Size(657, 74);
            this.queke.TabIndex = 5;
            this.queke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sno
            // 
            this.sno.DataPropertyName = "sno";
            this.sno.HeaderText = "学号";
            this.sno.Name = "sno";
            // 
            // sname
            // 
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "姓名";
            this.sname.Name = "sname";
            // 
            // Frmstudent
            // 
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.queke);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressName);
            this.Controls.Add(this.dgvStuList);
            this.Controls.Add(this.panel1);
            this.Name = "Frmstudent";
            this.Text = "学生点名系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queke)).EndInit();
            this.ResumeLayout(false);

        }
        public void btnLoadStu_Click_1(object sender, EventArgs e)
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
                Thread.Sleep(100);
            }


            dgvStuList.DataSource = dt;
        }
        string a = null;
        string b = null;
        int i;
        public void timerCallName_Tick_1(object sender, EventArgs e)
        {
            Random ra = new Random();
            i = ra.Next(stuList.Count);
            lblName.Text = stuList[i].Name;
        }
        public void btnStart_Click_1(object sender, EventArgs e)
        {
            timerCallName.Start();
        }
        
        public void btnStop_Click_1(object sender, EventArgs e)
        {
            timerCallName.Stop();
            if (MessageBox.Show("学生是否缺课", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                List<Students> List = new List<Students>();
                a = stuList[i].Id;
                b = stuList[i].Name;
                Students stu = new Students(a, b);

                List.Add(stu);

                DataTable DT = new DataTable();
                DT.Columns.Add("sno", Type.GetType("System.String"));
                DT.Columns.Add("sname", Type.GetType("System.String"));
                DT.Rows.Add(stu.Id, stu.Name);

                queke.DataSource = DT;
            }
        }

        //public void btnLoadStu_Click_1(object sender, EventArgs e)
        //{

        //    //获取学生数据源
        //    StudentDAO stuDao = new StudentDAO();
        //    stuList = stuDao.getAllStudents();

        //    //进度条设置
        //    int stuCounts = stuList.Count;//及时学生人数
        //    progressName.Maximum = stuCounts;


        //    //构造数据源
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("stuID", Type.GetType("System.String"));
        //    dt.Columns.Add("stuName", Type.GetType("System.String"));

        //    //数据加载以进度条方式展现
        //    foreach (Student stu in stuList)
        //    {
        //        dt.Rows.Add(stu.Id, stu.Name);
        //        progressName.Value += 1;//一个学生，进度条加1；
        //        Thread.Sleep(100);
        //    }

        //    dgvStuList.DataSource = dt;

        //    setControlVisible();
        //}
        //string a = null;
        //string b = null;
        //int i = 0;
        //public void timerCallName_Tick_1(object sender, EventArgs e)
        //{
        //    Random ra = new Random();
        //    int i = ra.Next(stuList.Count);
        //    lblName.Text = stuList[i].Name;
        //}

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
