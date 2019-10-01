using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         private void button1_Click(object sender, EventArgs e)
        {
            string id, pwd;
            id = textBox1.Text;
            pwd = textBox1.Text;
            if (id == "123")
            {
                FrmStudent f = new FrmStudent();
                f.Show();

            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
