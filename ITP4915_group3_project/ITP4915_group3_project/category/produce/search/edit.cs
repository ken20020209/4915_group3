using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.produce.search
{
    public partial class edit : UserControl
    {
        Control panelContent;
        public edit(Control edit,int id)
        {
            InitializeComponent();
            edit.Controls.Add(this);
            this.BringToFront();
            supplierTableAdapter.Fill(this.category_dbDataSet.supplier);
            itemTableAdapter.Fill(this.category_dbDataSet.item);
            itemBindingSource.Filter = $"item_ID={id}";
            supplierBindingSource.Filter = $"supplier_ID={id}";
        }
        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }
    }
}
