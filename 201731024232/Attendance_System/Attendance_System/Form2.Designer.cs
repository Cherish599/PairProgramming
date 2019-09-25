namespace Attendance_System
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerCallName = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuNo,
            this.stuName,
            this.abs});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(802, 189);
            this.dataGridView1.TabIndex = 1;
            // 
            // stuNo
            // 
            this.stuNo.DataPropertyName = "stuNo";
            this.stuNo.HeaderText = "学号";
            this.stuNo.Name = "stuNo";
            // 
            // stuName
            // 
            this.stuName.DataPropertyName = "stuName";
            this.stuName.HeaderText = "姓名";
            this.stuName.Name = "stuName";
            // 
            // abs
            // 
            this.abs.DataPropertyName = "abs";
            this.abs.HeaderText = "缺勤次数";
            this.abs.Name = "abs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-6, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 115);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnAbs);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Location = new System.Drawing.Point(-6, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 92);
            this.panel3.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnStart.Location = new System.Drawing.Point(96, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始点名";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.Red;
            this.btnAbs.Location = new System.Drawing.Point(576, 7);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(108, 46);
            this.btnAbs.TabIndex = 2;
            this.btnAbs.Text = "缺勤";
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.BtnAbs_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStop.Location = new System.Drawing.Point(348, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 46);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止点名";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // timerCallName
            // 
            this.timerCallName.Tick += new System.EventHandler(this.TimerCallName_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(324, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 44);
            this.label2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "学生考勤系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn abs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerCallName;
        private System.Windows.Forms.Label label2;
    }
}