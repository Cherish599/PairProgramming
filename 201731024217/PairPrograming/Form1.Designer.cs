namespace PairPrograming
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rdchose = new System.Windows.Forms.Button();
            this.absence = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chosedstuin = new System.Windows.Forms.Label();
            this.progressName = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(731, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // Rdchose
            // 
            this.Rdchose.Location = new System.Drawing.Point(600, 328);
            this.Rdchose.Name = "Rdchose";
            this.Rdchose.Size = new System.Drawing.Size(75, 23);
            this.Rdchose.TabIndex = 1;
            this.Rdchose.Text = "随机抽取";
            this.Rdchose.UseVisualStyleBackColor = true;
            this.Rdchose.Click += new System.EventHandler(this.Rdchose_Click);
            // 
            // absence
            // 
            this.absence.Location = new System.Drawing.Point(600, 369);
            this.absence.Name = "absence";
            this.absence.Size = new System.Drawing.Size(75, 23);
            this.absence.TabIndex = 2;
            this.absence.Text = "缺勤处理";
            this.absence.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 29);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生名单";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.chosedstuin);
            this.panel2.Location = new System.Drawing.Point(72, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 64);
            this.panel2.TabIndex = 4;
            // 
            // chosedstuin
            // 
            this.chosedstuin.AutoSize = true;
            this.chosedstuin.Location = new System.Drawing.Point(29, 26);
            this.chosedstuin.Name = "chosedstuin";
            this.chosedstuin.Size = new System.Drawing.Size(0, 15);
            this.chosedstuin.TabIndex = 0;
            // 
            // progressName
            // 
            this.progressName.Location = new System.Drawing.Point(12, 281);
            this.progressName.Name = "progressName";
            this.progressName.Size = new System.Drawing.Size(731, 40);
            this.progressName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 428);
            this.Controls.Add(this.progressName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.absence);
            this.Controls.Add(this.Rdchose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "点到机";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Rdchose;
        private System.Windows.Forms.Button absence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label chosedstuin;
        private System.Windows.Forms.ProgressBar progressName;
    }
}

