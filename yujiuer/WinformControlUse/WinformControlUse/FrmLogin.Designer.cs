namespace WinformControlUse
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Esc = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.TBpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Esc
            // 
            this.Esc.Location = new System.Drawing.Point(192, 185);
            this.Esc.Name = "Esc";
            this.Esc.Size = new System.Drawing.Size(75, 23);
            this.Esc.TabIndex = 7;
            this.Esc.Text = "取消";
            this.Esc.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(45, 185);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 8;
            this.Login.Text = "登陆";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // TBpwd
            // 
            this.TBpwd.Location = new System.Drawing.Point(126, 103);
            this.TBpwd.Name = "TBpwd";
            this.TBpwd.PasswordChar = '*';
            this.TBpwd.Size = new System.Drawing.Size(128, 21);
            this.TBpwd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(126, 48);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(128, 21);
            this.TBname.TabIndex = 6;
            this.TBname.TextChanged += new System.EventHandler(this.TBname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.Esc);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TBpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Esc;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox TBpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label1;
    }
}