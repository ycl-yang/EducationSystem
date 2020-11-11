namespace EducationManagementSystem
{
    partial class frm_Desktop
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
            this.btn_Notice = new System.Windows.Forms.Button();
            this.btn_StudentInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Notice
            // 
            this.btn_Notice.Location = new System.Drawing.Point(61, 35);
            this.btn_Notice.Name = "btn_Notice";
            this.btn_Notice.Size = new System.Drawing.Size(186, 91);
            this.btn_Notice.TabIndex = 0;
            this.btn_Notice.Text = "公告留言";
            this.btn_Notice.UseVisualStyleBackColor = true;
            this.btn_Notice.Click += new System.EventHandler(this.btn_Notice_Click);
            // 
            // btn_StudentInformation
            // 
            this.btn_StudentInformation.Location = new System.Drawing.Point(359, 35);
            this.btn_StudentInformation.Name = "btn_StudentInformation";
            this.btn_StudentInformation.Size = new System.Drawing.Size(191, 91);
            this.btn_StudentInformation.TabIndex = 1;
            this.btn_StudentInformation.Text = "个人信息";
            this.btn_StudentInformation.UseVisualStyleBackColor = true;
            this.btn_StudentInformation.Click += new System.EventHandler(this.btn_StudentInformation_Click);
            // 
            // frm_Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 292);
            this.Controls.Add(this.btn_StudentInformation);
            this.Controls.Add(this.btn_Notice);
            this.Name = "frm_Desktop";
            this.Text = "我的桌面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Notice;
        private System.Windows.Forms.Button btn_StudentInformation;
    }
}