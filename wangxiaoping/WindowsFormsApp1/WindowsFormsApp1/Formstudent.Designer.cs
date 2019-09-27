namespace WindowsFormsApp1
{
    partial class Formstudent
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
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.progressName = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadstu = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStuList
            // 
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuID,
            this.stuName});
            this.dgvStuList.Location = new System.Drawing.Point(21, 12);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.RowTemplate.Height = 23;
            this.dgvStuList.Size = new System.Drawing.Size(473, 137);
            this.dgvStuList.TabIndex = 0;
            this.dgvStuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuList_CellContentClick);
            // 
            // progressName
            // 
            this.progressName.Location = new System.Drawing.Point(21, 156);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(473, 23);
            this.progressName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnLoadstu);
            this.panel1.Location = new System.Drawing.Point(21, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 31);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(21, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnLoadstu
            // 
            this.btnLoadstu.Location = new System.Drawing.Point(377, 5);
            this.btnLoadstu.Name = "btnLoadstu";
            this.btnLoadstu.Size = new System.Drawing.Size(75, 23);
            this.btnLoadstu.TabIndex = 0;
            this.btnLoadstu.Text = "加载学生";
            this.btnLoadstu.UseVisualStyleBackColor = true;
            this.btnLoadstu.Click += new System.EventHandler(this.btnLoadstu_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(296, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(215, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(215, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(204, 100);
            this.lblName.TabIndex = 0;
            this.lblName.UseVisualStyleBackColor = false;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stuID
            // 
            this.stuID.DataPropertyName = "stuID";
            this.stuID.HeaderText = "学号";
            this.stuID.Name = "stuID";
            // 
            // stuName
            // 
            this.stuName.DataPropertyName = "stuName";
            this.stuName.HeaderText = "姓名";
            this.stuName.Name = "stuName";
            // 
            // Formstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 337);
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
        private System.Windows.Forms.ProgressBar progressName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoadstu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button lblName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
    }
}