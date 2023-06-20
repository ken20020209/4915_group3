using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.humanResources.user.search
{
    public partial class detail : UserControl
    {
        Control panelContent;
        public detail(Control panelContent,int userid)
        {
            InitializeComponent();
            userTableAdapter.Fill(this.humanResources_dbDataSet.user);
            roleTableAdapter.Fill(this.humanResources_dbDataSet.role);

            this.panelContent = panelContent;
            panelContent.Controls.Add(this);
            this.BringToFront();
            try
            {
                role_nameComboBox.Text = this.humanResources_dbDataSet.role.FindByrole_id(this.humanResources_dbDataSet.user.FindByuser_id(userid).role_id).role_name;
            }
            catch (Exception ex) // process record with role id
            {
                ex.ToString();
            }
            userBindingSource.Filter = $"user_id={userid}";
        }



        private void role_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            role_idKryptonTextBox.Text = role_nameComboBox.SelectedValue.ToString();
        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.humanResources_dbDataSet);

            MessageBox.Show("save success");
        }

        private void kryptonButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.RemoveCurrent();
            }
            catch(Exception ex)
            {
                MessageBox.Show("so work depend on he/his");
            }
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.humanResources_dbDataSet);
            new check(check.panel);
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);
        }
    }
}
