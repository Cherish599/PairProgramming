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
using System.Collections;

namespace WinformControlUse
{
    public partial class testQuanity : Form
    {
        List<Student> stuList;
        public testQuanity()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);

        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            //获取学生数据源
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();
            DataTable dt = new DataTable();
            dt.Columns.Add("stuID", Type.GetType("System.String"));
            dt.Columns.Add("stuName", Type.GetType("System.String"));
            ArrayList alist = new ArrayList();
            int t = int.Parse(textBox1.Text);
            for (int i = 0; i < t; i++)//防止随机到同一位同学
            {                
                Random r = new Random(GetRandomSeed());
                int m = r.Next(stuList.Count);
                if (!alist.Contains(m))
                    dt.Rows.Add(stuList[m].Id, stuList[m].Name);
                else t++;
                alist.Add(m);
                
            }
            dgvRandom.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRandom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butResult1_Click(object sender, EventArgs e)
        {
            int m = 0;
            int n = 0;
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();
            //统计学生缺席情况
            for (int i = 0; i < dgvRandom.Rows.Count; i++)
            {
                string _selectValue = dgvRandom.Rows[i].Cells["stuCheck1"].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                    m++;
            }
            for (int i = 0; i < dgvRandom.Rows.Count; i++)
            {
                string _selectValue = dgvRandom.Rows[i].Cells["stuCause1"].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                    n++;
            }
            MessageBox.Show("本次随机点到学生：" + int.Parse(textBox1.Text) + "人，缺席：" + m + "人，请假人数：" + n + "人");

        }
    }
}
