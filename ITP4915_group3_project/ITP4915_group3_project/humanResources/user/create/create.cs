using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.humanResources.user.create
{
    public partial class create : UserControl
    {
        public Control panelContent;
        public create(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();

            //laod data
            this.userTableAdapter.Fill(this.humanResources_dbDataSet.user);
            this.roleTableAdapter.Fill(this.humanResources_dbDataSet.role);

            userBindingSource.AddNew();
            userBindingSource.MoveLast();

        }

        private void kryptonButtonSubmit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.humanResources_dbDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("create success");
            userBindingSource.AddNew();
            userBindingSource.MoveLast();
        }

        private void role_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            role_idKryptonTextBox.Text = role_nameComboBox.SelectedValue.ToString();
        }
    }
}
