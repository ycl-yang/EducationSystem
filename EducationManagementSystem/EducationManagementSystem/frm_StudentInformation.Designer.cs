namespace EducationManagementSystem
{
    partial class frm_StudentInformation
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
            this.lbl_StudentNo = new System.Windows.Forms.Label();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.txt_Birthday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_StudentNo
            // 
            this.lbl_StudentNo.AutoSize = true;
            this.lbl_StudentNo.Location = new System.Drawing.Point(35, 21);
            this.lbl_StudentNo.Name = "lbl_StudentNo";
            this.lbl_StudentNo.Size = new System.Drawing.Size(41, 12);
            this.lbl_StudentNo.TabIndex = 0;
            this.lbl_StudentNo.Text = "学号：";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(35, 60);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(41, 12);
            this.lbl_StudentName.TabIndex = 1;
            this.lbl_StudentName.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级：";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(35, 134);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(41, 12);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "性别：";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Location = new System.Drawing.Point(12, 168);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(65, 12);
            this.lbl_Birthday.TabIndex = 4;
            this.lbl_Birthday.Text = "出生日期：";
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(93, 12);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(100, 21);
            this.txt_StudentNo.TabIndex = 5;
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(93, 51);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(100, 21);
            this.txt_StudentName.TabIndex = 6;
            // 
            // txt_Class
            // 
            this.txt_Class.Location = new System.Drawing.Point(93, 87);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(100, 21);
            this.txt_Class.TabIndex = 7;
            // 
            // txt_Gender
            // 
            this.txt_Gender.Location = new System.Drawing.Point(93, 125);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(100, 21);
            this.txt_Gender.TabIndex = 9;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(250, 206);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 10;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.Location = new System.Drawing.Point(93, 168);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.Size = new System.Drawing.Size(100, 21);
            this.txt_Birthday.TabIndex = 11;
            // 
            // frm_StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 280);
            this.Controls.Add(this.txt_Birthday);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_Class);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_StudentName);
            this.Controls.Add(this.lbl_StudentNo);
            this.Name = "frm_StudentInformation";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.frm_StudentInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentNo;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.TextBox txt_Class;
        private System.Windows.Forms.TextBox txt_Gender;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TextBox txt_Birthday;
    }
}