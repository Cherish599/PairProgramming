namespace WinFromDianMing
{
    partial class FormStudet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGVList = new System.Windows.Forms.DataGridView();
            this.StudentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudengName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.progressName = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnLoadStu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timerCountStu = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVList)).BeginInit();
            this.pnlProgress.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生列表";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGVList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 222);
            this.panel2.TabIndex = 1;
            // 
            // dataGVList
            // 
            this.dataGVList.AllowUserToAddRows = false;
            this.dataGVList.AllowUserToDeleteRows = false;
            this.dataGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNum,
            this.StudengName,
            this.StuSex});
            this.dataGVList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVList.Location = new System.Drawing.Point(0, 0);
            this.dataGVList.Name = "dataGVList";
            this.dataGVList.ReadOnly = true;
            this.dataGVList.RowTemplate.Height = 27;
            this.dataGVList.Size = new System.Drawing.Size(594, 222);
            this.dataGVList.TabIndex = 0;
            // 
            // StudentNum
            // 
            this.StudentNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentNum.DataPropertyName = "stuID";
            this.StudentNum.HeaderText = "学号";
            this.StudentNum.Name = "StudentNum";
            this.StudentNum.ReadOnly = true;
            this.StudentNum.Width = 66;
            // 
            // StudengName
            // 
            this.StudengName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudengName.DataPropertyName = "stuName";
            this.StudengName.HeaderText = "姓名";
            this.StudengName.Name = "StudengName";
            this.StudengName.ReadOnly = true;
            // 
            // StuSex
            // 
            this.StuSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuSex.DataPropertyName = "stuSex";
            this.StuSex.HeaderText = "性别";
            this.StuSex.Name = "StuSex";
            this.StuSex.ReadOnly = true;
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.progressName);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.Location = new System.Drawing.Point(0, 252);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(594, 30);
            this.pnlProgress.TabIndex = 2;
            // 
            // progressName
            // 
            this.progressName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressName.Location = new System.Drawing.Point(0, 0);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(594, 30);
            this.progressName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.btnRecord);
            this.panel4.Controls.Add(this.btnLoadStu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(357, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 83);
            this.panel4.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Location = new System.Drawing.Point(83, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 32);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.MouseCaptureChanged += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(83, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord.Location = new System.Drawing.Point(174, 6);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(46, 70);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "点名记录";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnLoadStu
            // 
            this.btnLoadStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoadStu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadStu.Location = new System.Drawing.Point(21, 6);
            this.btnLoadStu.Name = "btnLoadStu";
            this.btnLoadStu.Size = new System.Drawing.Size(46, 70);
            this.btnLoadStu.TabIndex = 0;
            this.btnLoadStu.Text = "加载学生";
            this.btnLoadStu.UseVisualStyleBackColor = false;
            this.btnLoadStu.Click += new System.EventHandler(this.btnLoadStu_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aqua;
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 282);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 83);
            this.panel5.TabIndex = 4;
            // 
            // timerCountStu
            // 
            this.timerCountStu.Tick += new System.EventHandler(this.timerCountStu_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(99, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 38);
            this.lblName.TabIndex = 0;
            // 
            // FormStudet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 365);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(612, 412);
            this.Name = "FormStudet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结对点名系统";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVList)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGVList;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar progressName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnLoadStu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timerCountStu;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudengName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuSex;
        private System.Windows.Forms.Label lblName;
    }
}