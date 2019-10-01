namespace WinformControlUse
{
    partial class FrmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.stuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.progressName = new System.Windows.Forms.ProgressBar();
            this.btnLoadStu = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerCallName = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生列表";
            // 
            // dgvStuList
            // 
            this.dgvStuList.AllowUserToAddRows = false;
            this.dgvStuList.AllowUserToDeleteRows = false;
            this.dgvStuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStuList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuID,
            this.stuName,
            this.stuSex});
            this.dgvStuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStuList.Location = new System.Drawing.Point(0, 0);
            this.dgvStuList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.ReadOnly = true;
            this.dgvStuList.RowHeadersWidth = 55;
            this.dgvStuList.RowTemplate.Height = 23;
            this.dgvStuList.Size = new System.Drawing.Size(964, 303);
            this.dgvStuList.TabIndex = 1;
            this.dgvStuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStuList_CellContentClick);
            // 
            // stuID
            // 
            this.stuID.DataPropertyName = "stuID";
            this.stuID.HeaderText = "学号";
            this.stuID.Name = "stuID";
            this.stuID.ReadOnly = true;
            // 
            // stuName
            // 
            this.stuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuName.DataPropertyName = "stuName";
            this.stuName.HeaderText = "姓名";
            this.stuName.Name = "stuName";
            this.stuName.ReadOnly = true;
            // 
            // stuSex
            // 
            this.stuSex.DataPropertyName = "stuSex";
            this.stuSex.HeaderText = "性别";
            this.stuSex.Name = "stuSex";
            this.stuSex.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 33);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStuList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 303);
            this.panel2.TabIndex = 3;
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlProgress.Controls.Add(this.progressName);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.Location = new System.Drawing.Point(0, 336);
            this.pnlProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(964, 40);
            this.pnlProgress.TabIndex = 4;
            // 
            // progressName
            // 
            this.progressName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressName.Location = new System.Drawing.Point(0, 0);
            this.progressName.Margin = new System.Windows.Forms.Padding(4);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(964, 40);
            this.progressName.TabIndex = 1;
            this.progressName.Click += new System.EventHandler(this.ProgressName_Click);
            // 
            // btnLoadStu
            // 
            this.btnLoadStu.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadStu.ForeColor = System.Drawing.Color.Red;
            this.btnLoadStu.Location = new System.Drawing.Point(798, 5);
            this.btnLoadStu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadStu.Name = "btnLoadStu";
            this.btnLoadStu.Size = new System.Drawing.Size(153, 31);
            this.btnLoadStu.TabIndex = 0;
            this.btnLoadStu.Text = "点击加载学生";
            this.btnLoadStu.UseVisualStyleBackColor = true;
            this.btnLoadStu.Click += new System.EventHandler(this.btnLoadStu_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.Location = new System.Drawing.Point(4, 5);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(124, 4);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 31);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerCallName
            // 
            this.timerCallName.Interval = 50;
            this.timerCallName.Tick += new System.EventHandler(this.timerCallName_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnLoadStu);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 376);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 40);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 416);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(964, 200);
            this.panel4.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblName.Location = new System.Drawing.Point(416, 68);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 78);
            this.lblName.TabIndex = 7;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 616);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生随机点名系统";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Button btnLoadStu;
        private System.Windows.Forms.ProgressBar progressName;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerCallName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuSex;
    }
}