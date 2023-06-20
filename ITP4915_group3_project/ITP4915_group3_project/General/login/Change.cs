using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITP4915_group3_project
{
    public partial class Forget : KryptonForm
    {
        public Forget()
        {
            InitializeComponent();
        }

        private void Forget_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            if(kryptonTextBoxOldPwd.Text==kryptonTextBoxNewPwd.Text)
            {
                MessageBox.Show("can't use same password");
                return;
            }
            if(kryptonTextBoxNewPwd.Text!=kryptonTextBoxConPwd.Text || kryptonTextBoxNewPwd.Text=="")
            {
                MessageBox.Show("won't confirm password");
                return;
            }
            humanResources_dbDataSet.userRow[] rows = (humanResources_dbDataSet.userRow[])userTableAdapter.GetData().Select($"user_name='{kryptonTextBoxUserName.Text}' and password='{kryptonTextBoxOldPwd.Text}'");

            if(rows.Length==0)
            {
                MessageBox.Show("won't old password or user name");
                return;
            }
            rows[0].password = kryptonTextBoxNewPwd.Text;
            userTableAdapter.Update(rows[0]);
            MessageBox.Show("change password success");
        }
    }
}
