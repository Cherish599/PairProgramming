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
using DataBase;

namespace WinformControlUse
{
    public partial class stuEdit : Form
    {
        List<Student> stuList;
        public stuEdit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            int i = int.Parse(stuId1.Text);
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();
            stuName1.Text = stuList[i].Name;
        }

        private void ButPlus_Click(object sender, EventArgs e)
        {
            StudentDataset stuD = new StudentDataset();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(stuId1.Text);
        }
    }
}
