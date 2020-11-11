namespace EducationManagementSystem
{
    partial class frm_SignUp
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
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_StudentNo = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(236, 163);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 0;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_StudentNo
            // 
            this.lbl_StudentNo.AutoSize = true;
            this.lbl_StudentNo.Location = new System.Drawing.Point(69, 34);
            this.lbl_StudentNo.Name = "lbl_StudentNo";
            this.lbl_StudentNo.Size = new System.Drawing.Size(41, 12);
            this.lbl_StudentNo.TabIndex = 1;
            this.lbl_StudentNo.Text = "学号：";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(69, 73);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(41, 12);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "密码：";
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(129, 25);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(100, 21);
            this.txt_StudentNo.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(129, 63);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 21);
            this.txt_Password.TabIndex = 4;
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 235);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_StudentNo);
            this.Controls.Add(this.btn_SignUp);
            this.Name = "frm_SignUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_StudentNo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.TextBox txt_Password;
    }
}

