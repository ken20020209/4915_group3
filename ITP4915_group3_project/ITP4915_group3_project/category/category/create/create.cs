using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.category.create
{
    public partial class create : UserControl 
    {
        Control panelContent;
        public create(Control panelContent)
        {
            this.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();


            this.item_categoryTableAdapter.Fill(this.category_dbDataSet.item_category);

            item_categoryBindingSource.AddNew();
            item_categoryBindingSource.MoveLast();

        }
        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_categoryBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("create success");
            item_categoryBindingSource.AddNew();
            item_categoryBindingSource.MoveLast();
        }
    }
}
