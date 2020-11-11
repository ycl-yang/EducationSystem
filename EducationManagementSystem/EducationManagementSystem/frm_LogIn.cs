using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace EducationManagementSystem
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT 1 FROM tb_LogIn
                   WHERE No='{this.txt_StudentNo.Text.Trim()}'
                   AND Password='{this.txt_Password.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result == 1)
            {
                MessageBox.Show("登录成功！");
                frm_EducationManagement frm_EducationManagement = new frm_EducationManagement(this.txt_StudentNo.Text.Trim());
                frm_EducationManagement.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txt_Password.Focus();
                this.txt_Password.SelectAll();
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp signUpForm = new frm_SignUp();
            signUpForm.ShowDialog();
        }
    }
}
