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
    public partial class Formd : Form
    {
        public Formd()
        {
            InitializeComponent();
        }

        private void progressBar2_Click_1(object sender, EventArgs e)
        {
            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                this.Close();
            progressBar2.Value = (int)(Opacity * 100);
           
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
