using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.supplier.search
{
    public partial class edit : UserControl
    {
        Control panelContent;
        public edit(Control edit, int id)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            edit.Controls.Add(this);
            this.BringToFront();
            supplierTableAdapter.Fill(this.category_dbDataSet.supplier);
            addressTableAdapter.Fill(this.category_dbDataSet.address);
            supplierBindingSource.Filter = $"supplier_ID={id}";
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.addressBindingSource.EndEdit();
            this.supplier_contact_personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }
    }
}
