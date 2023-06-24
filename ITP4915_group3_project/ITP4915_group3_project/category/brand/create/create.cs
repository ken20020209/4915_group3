using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.brand.create
{
    public partial class create : UserControl
    {
        private Control check;

        public create(Control panelContent)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partner_brandBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("create success");
            partner_brandBindingSource.AddNew();
            partner_brandBindingSource.MoveLast();
        
        }
        private void kryptonLabelback_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
    }
}
