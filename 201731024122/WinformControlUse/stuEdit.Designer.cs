namespace WinformControlUse
{
    partial class stuEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.stuId1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stuName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stuAbsence1 = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.remark1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butConfirm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stuId1
            // 
            this.stuId1.Location = new System.Drawing.Point(61, 124);
            this.stuId1.Name = "stuId1";
            this.stuId1.Size = new System.Drawing.Size(100, 21);
            this.stuId1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // stuName1
            // 
            this.stuName1.Enabled = false;
            this.stuName1.Location = new System.Drawing.Point(357, 124);
            this.stuName1.Name = "stuName1";
            this.stuName1.ReadOnly = true;
            this.stuName1.Size = new System.Drawing.Size(100, 21);
            this.stuName1.TabIndex = 3;
            this.stuName1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "缺席次数";
            // 
            // stuAbsence1
            // 
            this.stuAbsence1.Enabled = false;
            this.stuAbsence1.Location = new System.Drawing.Point(645, 124);
            this.stuAbsence1.Name = "stuAbsence1";
            this.stuAbsence1.ReadOnly = true;
            this.stuAbsence1.Size = new System.Drawing.Size(100, 21);
            this.stuAbsence1.TabIndex = 6;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(117, 291);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 7;
            this.butSearch.Text = "搜索";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butPlus
            // 
            this.butPlus.Location = new System.Drawing.Point(319, 291);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(98, 23);
            this.butPlus.TabIndex = 8;
            this.butPlus.Text = "缺席次数加1";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.ButPlus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "缺席次数-1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // remark1
            // 
            this.remark1.Location = new System.Drawing.Point(61, 189);
            this.remark1.Name = "remark1";
            this.remark1.Size = new System.Drawing.Size(100, 21);
            this.remark1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "备注";
            // 
            // butConfirm1
            // 
            this.butConfirm1.Location = new System.Drawing.Point(333, 362);
            this.butConfirm1.Name = "butConfirm1";
            this.butConfirm1.Size = new System.Drawing.Size(75, 23);
            this.butConfirm1.TabIndex = 12;
            this.butConfirm1.Text = "确定";
            this.butConfirm1.UseVisualStyleBackColor = true;
            // 
            // stuEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butConfirm1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remark1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.stuAbsence1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stuName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuId1);
            this.Controls.Add(this.label1);
            this.Name = "stuEdit";
            this.Text = "stuEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuId1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stuAbsence1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox remark1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butConfirm1;
    }
}