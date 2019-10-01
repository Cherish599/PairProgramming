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
    public partial class @interface : Form
    {
        public @interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudent  frm = new FrmStudent ();
            frm.Owner = this;
            this.Hide();
            frm.ShowDialog();

        }
    }
}
