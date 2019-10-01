using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformControlUse
{
    public partial class Forml : Form
    {
        public Forml()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "陈杰" && textBox2.Text == "123"|| textBox1.Text == "何辉" && textBox2.Text == "456")
            {
                
                FrmStudent f = new FrmStudent();
                f.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
