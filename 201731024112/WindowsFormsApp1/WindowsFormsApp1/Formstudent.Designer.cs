namespace WindowsFormsApp1
{
    partial class Formstudent
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressName = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadStu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStuList
            // 
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvStuList.Location = new System.Drawing.Point(12, 12);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.RowTemplate.Height = 30;
            this.dgvStuList.Size = new System.Drawing.Size(787, 170);
            this.dgvStuList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stuID";
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "stuName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // progressName
            // 
            this.progressName.Location = new System.Drawing.Point(12, 189);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(787, 39);
            this.progressName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnLoadStu);
            this.panel1.Location = new System.Drawing.Point(12, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 60);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(23, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 120);
            this.panel2.TabIndex = 3;
            // 
            // btnLoadStu
            // 
            this.btnLoadStu.Location = new System.Drawing.Point(647, 17);
            this.btnLoadStu.Name = "btnLoadStu";
            this.btnLoadStu.Size = new System.Drawing.Size(97, 40);
            this.btnLoadStu.TabIndex = 0;
            this.btnLoadStu.Text = "加载学生";
            this.btnLoadStu.UseVisualStyleBackColor = true;
            this.btnLoadStu.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(503, 17);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(376, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 43);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(398, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(192, 82);
            this.lblName.TabIndex = 0;
            this.lblName.UseVisualStyleBackColor = true;
            // 
            // Formstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressName);
            this.Controls.Add(this.dgvStuList);
            this.Name = "Formstudent";
            this.Text = "学生随机点名系统";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ProgressBar progressName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadStu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button lblName;
    }
}

