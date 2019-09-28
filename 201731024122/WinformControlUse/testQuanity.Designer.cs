namespace WinformControlUse
{
    partial class testQuanity
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butConfirm = new System.Windows.Forms.Button();
            this.dgvRandom = new System.Windows.Forms.DataGridView();
            this.butResult1 = new System.Windows.Forms.Button();
            this.stuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuCheck1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stuCause1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "随机数量";
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(315, 159);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 3;
            this.butConfirm.Text = "确定";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // dgvRandom
            // 
            this.dgvRandom.AllowUserToAddRows = false;
            this.dgvRandom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuId,
            this.stuName,
            this.stuCheck1,
            this.stuCause1});
            this.dgvRandom.Location = new System.Drawing.Point(396, 12);
            this.dgvRandom.Name = "dgvRandom";
            this.dgvRandom.RowTemplate.Height = 23;
            this.dgvRandom.Size = new System.Drawing.Size(404, 426);
            this.dgvRandom.TabIndex = 4;
            this.dgvRandom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRandom_CellContentClick);
            // 
            // butResult1
            // 
            this.butResult1.Location = new System.Drawing.Point(196, 236);
            this.butResult1.Name = "butResult1";
            this.butResult1.Size = new System.Drawing.Size(75, 23);
            this.butResult1.TabIndex = 5;
            this.butResult1.Text = "点到结果";
            this.butResult1.UseVisualStyleBackColor = true;
            this.butResult1.Click += new System.EventHandler(this.butResult1_Click);
            // 
            // stuId
            // 
            this.stuId.DataPropertyName = "stuId";
            this.stuId.HeaderText = "学号";
            this.stuId.Name = "stuId";
            this.stuId.ReadOnly = true;
            this.stuId.Width = 75;
            // 
            // stuName
            // 
            this.stuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuName.DataPropertyName = "stuName";
            this.stuName.HeaderText = "姓名";
            this.stuName.Name = "stuName";
            this.stuName.ReadOnly = true;
            // 
            // stuCheck1
            // 
            this.stuCheck1.HeaderText = "是否缺席";
            this.stuCheck1.Name = "stuCheck1";
            this.stuCheck1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stuCheck1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stuCheck1.Width = 80;
            // 
            // stuCause1
            // 
            this.stuCause1.HeaderText = "是否请假";
            this.stuCause1.Name = "stuCause1";
            this.stuCause1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stuCause1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stuCause1.Width = 80;
            // 
            // testQuanity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butResult1);
            this.Controls.Add(this.dgvRandom);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "testQuanity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数量选择";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.DataGridView dgvRandom;
        private System.Windows.Forms.Button butResult1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stuCheck1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stuCause1;
    }
}