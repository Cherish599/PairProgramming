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
            this.Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(289, 167);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(92, 23);
            this.Read.TabIndex = 0;
            this.Read.Text = "读取学生文件";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 169);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(271, 21);
            this.TxtName.TabIndex = 1;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(289, 140);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(91, 23);
            this.Select.TabIndex = 0;
            this.Select.Text = "随机点名";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("宋体", 80F);
            this.Name.Location = new System.Drawing.Point(12, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(369, 107);
            this.Name.TabIndex = 2;
            this.Name.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 208);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Read);
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
        private System.Windows.Forms.Label Name;
    }
}

