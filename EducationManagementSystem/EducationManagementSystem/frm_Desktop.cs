using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class frm_Desktop : Form
    {
        private string _StudentNo;
        public frm_Desktop(string studentNo)
        {
            InitializeComponent();
            this._StudentNo = studentNo;
        }

        private void btn_Notice_Click(object sender, EventArgs e)
        {
            frm_Notice frm_Notice = new frm_Notice();
            frm_Notice.Show();
            this.Close();
        }

        private void btn_StudentInformation_Click(object sender, EventArgs e)
        {
            frm_StudentInformation frm_StudentInformation = new frm_StudentInformation(this._StudentNo);
            frm_StudentInformation.Show();
            this.Close();
        }
    }
}
