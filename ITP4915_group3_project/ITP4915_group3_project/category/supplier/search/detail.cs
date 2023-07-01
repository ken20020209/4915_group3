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
    public partial class detail : UserControl
    {
        private Control check;
        private int v;
        public detail(check check, int v)
        {
            this.check = check;
            this.v = v;
            InitializeComponent();
            check.Controls.Add(this);
            this.BringToFront();
            this.supplierTableAdapter.Fill(this.category_dbDataSet.supplier);
/*            this.addressTableAdapter.Fill(this.category_dbDataSet.address);
            this.supplier_contact_personTableAdapter.Fill(this.category_dbDataSet.supplier_contact_person);*/
            supplierBindingSource.Filter = $"supplier_id={v}";
        }
        private void kryptonLabel20_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
        private void kryptonLabel11_Click(object sender, EventArgs e)
        {
            supplierBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            MessageBox.Show("delete success");
            new delete_sucess().ShowDialog();
        }
        private void kryptonLabel10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            MessageBox.Show("Save success");
        }
    }
}
