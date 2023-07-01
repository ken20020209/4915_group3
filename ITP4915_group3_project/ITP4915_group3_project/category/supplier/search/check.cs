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
    public partial class check : UserControl
    {
        public static Control panel;

        public check(Control panel)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            this.supplierTableAdapter.Fill(this.category_dbDataSet.supplier);
            kryptonLabelResult.Text = $"RESULT ({supplierBindingSource.Count})";
        }
        private void search()
        {
            string keyword = "'%" + kryptonTextBox16.Text + "%'";
           supplierBindingSource.Filter = $" name like {keyword} or phone like {keyword}";
            try
            {
                supplierBindingSource.Filter += $" or supplier_ID = {int.Parse(kryptonTextBox16.Text)}";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            kryptonLabelResult.Text = $"RESULT ({supplierBindingSource.Count})";
        }
        private void supplierKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            detail stockDetail = new detail(this, int.Parse(supplierKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

        }
        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
