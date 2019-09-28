using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace SelectStudent
{
    public partial class Form1 : Form
    {

        string[] StudentName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OFD.Filter = "(*.txt)|*.txt";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string strNames = OFD.FileName;
                //将文件名添加到 textbox中
                TxtName.Text = strNames;
            }
            StudentName = File.ReadAllLines(TxtName.Text);
            //读取完成txt中的姓名，txt中姓名由换行隔开
        }

        private void Select_Click(object sender, EventArgs e)
        {
            Random RD= new Random();

            Name.Text=
        }
    }
}
