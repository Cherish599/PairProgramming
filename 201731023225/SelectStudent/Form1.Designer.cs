namespace SelectStudent
{
    partial class Form1
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
            this.Read = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(385, 209);
            this.Read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(123, 29);
            this.Read.TabIndex = 0;
            this.Read.Text = "读取学生文件";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(16, 211);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(360, 25);
            this.TxtName.TabIndex = 1;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(385, 175);
            this.Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(121, 29);
            this.Select.TabIndex = 0;
            this.Select.Text = "随机点名";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("宋体", 80F);
            this.Student.Location = new System.Drawing.Point(16, 11);
            this.Student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(325, 134);
            this.Student.TabIndex = 2;
            this.Student.Text = "姓名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 260);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Read);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "随机点名软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label Student;
    }
}

