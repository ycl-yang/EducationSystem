namespace EducationManagementSystem
{
    partial class frm_EducationManagement
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
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.btn_Desktop = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_TrainingManagement = new System.Windows.Forms.Button();
            this.btn_Examination = new System.Windows.Forms.Button();
            this.btn_Practice = new System.Windows.Forms.Button();
            this.btn_Evaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(23, 12);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(161, 21);
            this.txt_StudentName.TabIndex = 0;
            this.txt_StudentName.TextChanged += new System.EventHandler(this.txt_StudentName_TextChanged);
            // 
            // btn_Desktop
            // 
            this.btn_Desktop.Location = new System.Drawing.Point(23, 69);
            this.btn_Desktop.Name = "btn_Desktop";
            this.btn_Desktop.Size = new System.Drawing.Size(161, 78);
            this.btn_Desktop.TabIndex = 1;
            this.btn_Desktop.Text = "我的桌面";
            this.btn_Desktop.UseVisualStyleBackColor = true;
            this.btn_Desktop.Click += new System.EventHandler(this.btn_Desktop_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(241, 69);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(154, 78);
            this.btn_Status.TabIndex = 2;
            this.btn_Status.Text = "学籍成绩";
            this.btn_Status.UseVisualStyleBackColor = true;
            // 
            // btn_TrainingManagement
            // 
            this.btn_TrainingManagement.Location = new System.Drawing.Point(458, 69);
            this.btn_TrainingManagement.Name = "btn_TrainingManagement";
            this.btn_TrainingManagement.Size = new System.Drawing.Size(164, 78);
            this.btn_TrainingManagement.TabIndex = 3;
            this.btn_TrainingManagement.Text = "培养管理";
            this.btn_TrainingManagement.UseVisualStyleBackColor = true;
            // 
            // btn_Examination
            // 
            this.btn_Examination.Location = new System.Drawing.Point(23, 201);
            this.btn_Examination.Name = "btn_Examination";
            this.btn_Examination.Size = new System.Drawing.Size(161, 81);
            this.btn_Examination.TabIndex = 4;
            this.btn_Examination.Text = "考试报名";
            this.btn_Examination.UseVisualStyleBackColor = true;
            // 
            // btn_Practice
            // 
            this.btn_Practice.Location = new System.Drawing.Point(241, 201);
            this.btn_Practice.Name = "btn_Practice";
            this.btn_Practice.Size = new System.Drawing.Size(154, 81);
            this.btn_Practice.TabIndex = 5;
            this.btn_Practice.Text = "实践环节";
            this.btn_Practice.UseVisualStyleBackColor = true;
            // 
            // btn_Evaluate
            // 
            this.btn_Evaluate.Location = new System.Drawing.Point(458, 201);
            this.btn_Evaluate.Name = "btn_Evaluate";
            this.btn_Evaluate.Size = new System.Drawing.Size(164, 81);
            this.btn_Evaluate.TabIndex = 6;
            this.btn_Evaluate.Text = "教学评价";
            this.btn_Evaluate.UseVisualStyleBackColor = true;
            // 
            // frm_EducationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.btn_Evaluate);
            this.Controls.Add(this.btn_Practice);
            this.Controls.Add(this.btn_Examination);
            this.Controls.Add(this.btn_TrainingManagement);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.btn_Desktop);
            this.Controls.Add(this.txt_StudentName);
            this.Name = "frm_EducationManagement";
            this.Text = "综合教务管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Button btn_Desktop;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_TrainingManagement;
        private System.Windows.Forms.Button btn_Examination;
        private System.Windows.Forms.Button btn_Practice;
        private System.Windows.Forms.Button btn_Evaluate;
    }
}