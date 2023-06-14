using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.create.BPA
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

            this.supplierTableAdapter.Fill(this.purchase_dbDataSet.supplier);
            
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.purchase_dbDataSet);

        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.itemTableAdapter.FillBy_supplierID(this.purchase_dbDataSet.item, int.Parse(supplierComboBox.SelectedValue.ToString()));
        }
    }
}
