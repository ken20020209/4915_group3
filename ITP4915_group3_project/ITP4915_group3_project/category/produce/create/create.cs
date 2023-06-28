using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.produce.create
{
    public partial class create : UserControl
    {
        private Control panelContent;
        public create(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();


            this.itemTableAdapter.Fill(this.category_dbDataSet.item);

            itemBindingSource.AddNew();
            itemBindingSource.MoveLast();
            supplierBindingSource.AddNew();
            supplierBindingSource.MoveLast();
        }
        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.supplierBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("create success");
            itemBindingSource.AddNew();
            itemBindingSource.MoveLast();
            supplierBindingSource.AddNew();
            supplierBindingSource.MoveLast();
        }
    }
}
