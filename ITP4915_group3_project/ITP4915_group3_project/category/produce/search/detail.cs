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
            this.itemTableAdapter.Fill(this.category_dbDataSet.item);
            itemBindingSource.Filter = $"item_id={v}";
            supplierBindingSource.Filter = $"supplier_id={v}";
        }
        private void kryptonLabel12_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
        private void kryptonLabel11_Click(object sender, EventArgs e)
        {
            itemBindingSource.RemoveCurrent();
            supplierBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            MessageBox.Show("delete success");
            new delete_sucess().ShowDialog();
        }
        private void kryptonLabel10_Click(object sender, EventArgs e)
        {
            new search.edit(check, v);
        }
    }
}
