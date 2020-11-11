namespace EducationManagementSystem
{
    partial class frm_LogIn
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
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_StudentNo = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(42, 168);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(75, 23);
            this.btn_LogIn.TabIndex = 0;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_StudentNo
            // 
            this.lbl_StudentNo.AutoSize = true;
            this.lbl_StudentNo.Location = new System.Drawing.Point(40, 30);
            this.lbl_StudentNo.Name = "lbl_StudentNo";
            this.lbl_StudentNo.Size = new System.Drawing.Size(41, 12);
            this.lbl_StudentNo.TabIndex = 1;
            this.lbl_StudentNo.Text = "学号：";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(40, 78);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(41, 12);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "密码：";
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(114, 21);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(100, 21);
            this.txt_StudentNo.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(114, 69);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 21);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(139, 168);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入用户名与密码！";
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_StudentNo);
            this.Controls.Add(this.btn_LogIn);
            this.Name = "frm_LogIn";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_StudentNo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label label1;
    }
}