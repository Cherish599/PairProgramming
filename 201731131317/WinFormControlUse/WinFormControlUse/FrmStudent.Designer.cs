namespace WinformControlUse
{
    partial class FrmStudent
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
            this.panel19 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLoadStu = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressName = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Button();
            this.timerCallName = new System.Windows.Forms.Timer(this.components);
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.Info;
            this.panel19.Controls.Add(this.label1);
            this.panel19.Location = new System.Drawing.Point(12, 13);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(737, 69);
            this.panel19.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生列表";
            // 
            // dgvStuList
            // 
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvStuList.Location = new System.Drawing.Point(12, 88);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.RowTemplate.Height = 30;
            this.dgvStuList.Size = new System.Drawing.Size(737, 235);
            this.dgvStuList.TabIndex = 1;
            this.dgvStuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuList_CellContentClick);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.btnLoadStu);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(12, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 74);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnLoadStu
            // 
            this.btnLoadStu.Location = new System.Drawing.Point(600, 22);
            this.btnLoadStu.Name = "btnLoadStu";
            this.btnLoadStu.Size = new System.Drawing.Size(92, 40);
            this.btnLoadStu.TabIndex = 2;
            this.btnLoadStu.Text = "加载学生";
            this.btnLoadStu.UseVisualStyleBackColor = true;
            this.btnLoadStu.Click += new System.EventHandler(this.btnLoadStu_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(314, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(167, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressName
            // 
            this.progressName.Location = new System.Drawing.Point(12, 329);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(737, 58);
            this.progressName.TabIndex = 3;
            this.progressName.Click += new System.EventHandler(this.progressName_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Location = new System.Drawing.Point(12, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 151);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(302, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(277, 115);
            this.lblName.TabIndex = 0;
            this.lblName.UseVisualStyleBackColor = true;
            this.lblName.Click += new System.EventHandler(this.lBlName_Click);
            // 
            // timerCallName
            // 
            this.timerCallName.Tick += new System.EventHandler(this.timerCallName_Tick_1);
            // 
            // FrmStudent
            // 
            this.ClientSize = new System.Drawing.Size(761, 670);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.progressName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvStuList);
            this.Controls.Add(this.panel19);
            this.Name = "FrmStudent";
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoadStu;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button lblName;
        private System.Windows.Forms.Timer timerCallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

