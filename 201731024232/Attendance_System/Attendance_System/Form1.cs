using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        private void Timer1_Tick_1(object sender, EventArgs e)//设置时钟
        {
            if (this.Opacity < 1)
                this.Opacity += 0.01;
            else
                this.Close();
            progressBar1.Value = (int)(Opacity * 100);
        }
    }
}
