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
    public partial class frm_StudentInformation : Form
    {
        private string studentNumber;
        public frm_StudentInformation()
        {
            InitializeComponent();
            this.FormClosed += Frm_StudentInformation_FormClosed;
        }

        private void Frm_StudentInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        public frm_StudentInformation(string studentNo):this()
        {
            this.studentNumber = studentNo;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_StudentInformation_Load(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT *
                    FROM dbo.tb_Student AS S
                    WHERE S.No = '{this.studentNumber}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txt_StudentNo.Text = sqlHelper["No"].ToString();
                this.txt_StudentName.Text = sqlHelper["Name"].ToString();
                this.txt_Gender.Text = sqlHelper["Gender"].ToString();
                this.txt_Class.Text = sqlHelper["ClassNo"].ToString();
                this.txt_Birthday.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
            }
        }
    }
}
