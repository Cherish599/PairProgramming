using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace WinformControlUse
{
    public partial class FrmStudent : Form
    {
       

        public FrmStudent()
        {
            //加载皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "\\Skins\\SportsBlue.ssk";
            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;
            InitializeComponent();
        }
        //隐藏开始点名和结束点名两个按钮
        void iniControl()
        {
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnopenfile.Enabled = true;
            btnshow.Enabled = true;         
        }
        //隐藏加载按钮
        void setControlVisible()
        {
            btnStart.Visible = true;
            btnStop.Visible = true;
               
        }

   
        private void btnopenfile_Click(object sender, EventArgs e)
        {
            try
            {
                //获取Excel文件路径和名称
                OpenFileDialog odXls = new OpenFileDialog();
                //指定相应的打开文档的目录  AppDomain.CurrentDomain.BaseDirectory定位到Debug目录，再根据实际情况进行目录调整
                string folderPath = AppDomain.CurrentDomain.BaseDirectory + @"databackup\";
                odXls.InitialDirectory = folderPath;
                // 设置文件格式  
                odXls.Filter = "Excel files office2003(*.xls)|*.xls|Excel office2010(*.xlsx)|*.xlsx|All files (*.*)|*.*";
                //openFileDialog1.Filter = "图片文件(*.jpg)|*.jpg|(*.JPEG)|*.jpeg|(*.PNG)|*.png";
                odXls.FilterIndex = 2;
                odXls.RestoreDirectory = true;
                if (odXls.ShowDialog() == DialogResult.OK)
                {
                    this.txtFilePath.Text = odXls.FileName;
                    this.txtFilePath.ReadOnly = true;
                    string sConnString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source={0};" + "Extended Properties='Excel 8.0;HDR=NO;IMEX=1';", odXls.FileName);
                    if ((System.IO.Path.GetExtension(txtFilePath.Text.Trim())).ToLower() == ".xls")
                    {
                        sConnString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "data source=" + odXls.FileName + ";Extended Properties=Excel 5.0;Persist Security Info=False";
                        //sConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFilePath.Text.Trim() + ";Extended Properties=\"Excel 8.0;HDR=" + strHead + ";IMEX=1\"";
                    }
                    using (OleDbConnection oleDbConn = new OleDbConnection(sConnString))
                    {
                        oleDbConn.Open();
                        DataTable dt = oleDbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                        //判断是否cmb中已有数据，有则清空
                        if (cmbtablename.Items.Count > 0)
                        {
                            cmbtablename.DataSource = null;
                            cmbtablename.Items.Clear();
                        }
                        //遍历dt的rows得到所有的TABLE_NAME，并Add到cmb中
                        foreach (DataRow dr in dt.Rows)
                        {
                            cmbtablename.Items.Add((String)dr["TABLE_NAME"]);
                        }
                        if (cmbtablename.Items.Count > 0)
                        {
                            cmbtablename.SelectedIndex = 0;
                        }
                        //加载Excel文件数据按钮
                        this.btnshow.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            #region 读取相应的表名的Excel文件中数据到当前DataGridview中显示
            OleDbConnection ole = null;
            OleDbDataAdapter da = null;
            DataTable dt = null;
            string strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source={0};" + "Extended Properties='Excel 8.0;HDR=NO;IMEX=1';", txtFilePath.Text.Trim());
            if ((System.IO.Path.GetExtension(txtFilePath.Text.Trim())).ToLower() == ".xls")
            {
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "data source=" + txtFilePath.Text.Trim() + ";Extended Properties=Excel 5.0;Persist Security Info=False";
                //sConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFilePath.Text.Trim() + ";Extended Properties=\"Excel 8.0;HDR=" + strHead + ";IMEX=1\"";
            }
            string sTableName = cmbtablename.Text.Trim();
            string strExcel = "select * from [" + sTableName + "]";
            try
            {
                ole = new OleDbConnection(strConn);
                ole.Open();
                da = new OleDbDataAdapter(strExcel, ole);
                dt = new DataTable();
                da.Fill(dt);
                this.dgvdata.DataSource = dt;
                //因为生成Excel的时候第一行是标题，所以要做如下操作：
                //1.修改DataGridView列头的名字，
                //2.数据列表中删除第一行
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    //dgvdata.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dgvdata.Columns[i].Name = dt.Columns[i].ColumnName;
                    dgvdata.Columns[i].HeaderCell.Value = dt.Rows[0][i].ToString();//c# winform 用代码修改DataGridView列头的名字，设置列名,修改列名
                }
                //DataGridView删除行
                dgvdata.Rows.Remove(dgvdata.Rows[0]);//删除第一行
                //dgvdata.Rows.Remove(dgvdata.CurrentRow);//删除当前光标所在行
                //dgvdata.Rows.Remove(dgvdata.Rows[dgvdata.Rows.Count - 1]);//删除最后一行
                //dgvdata.Rows.Clear();//删除所有行
                ole.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ole != null)
                    ole.Close();
            }
            #endregion

            setControlVisible();

        }


        private void FrmStudent_Load(object sender, EventArgs e)
        {
            iniControl();
        }

        private void timerCallName_Tick(object sender, EventArgs e)
        {
            
            Object obj= lblName.Text;
            String str = (String)obj;
            Random ra = new Random();
            int i = ra.Next(dgvdata.Rows.Count);
            lblName.Text = (String)dgvdata.Rows[i].Cells[1].Value;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }

       

        
    }
}
