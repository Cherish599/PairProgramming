using RecordData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromDianMing
{
    public partial class ShowRecordData : Form
    {
        string data = null;
        public ShowRecordData(string data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void ShowRecordData_Load(object sender, EventArgs e)
        {
           lblRCdata.Text = data;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            data = null;
            lblRCdata.Text = data;
            DialogResult = DialogResult.OK;
            btnClear.Enabled = false;
        }

    }
}
