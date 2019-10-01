namespace WinFromDianMing
{
    partial class ShowRecordData
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
            this.lblRCdata = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRCdata
            // 
            this.lblRCdata.AutoSize = true;
            this.lblRCdata.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCdata.Location = new System.Drawing.Point(32, 15);
            this.lblRCdata.Name = "lblRCdata";
            this.lblRCdata.Size = new System.Drawing.Size(0, 20);
            this.lblRCdata.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除记录";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ShowRecordData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 375);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblRCdata);
            this.Location = new System.Drawing.Point(988, 242);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowRecordData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "点名记录";
            this.Load += new System.EventHandler(this.ShowRecordData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRCdata;
        private System.Windows.Forms.Button btnClear;
    }
}