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
    public partial class frm_EducationManagement : Form
    {
        private string _StudentNo;
        public frm_EducationManagement(string studentNo)
        {
            InitializeComponent();
            this._StudentNo = studentNo;
        }

        private void btn_Desktop_Click(object sender, EventArgs e)
        {
            frm_Desktop frm_Desktop = new frm_Desktop(this._StudentNo);
            frm_Desktop.Show();
            this.Close();
        }

        private void txt_StudentName_TextChanged(object sender, EventArgs e)
        {
            this.txt_StudentName.Text = _StudentNo;
        }
    }
}
