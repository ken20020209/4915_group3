using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.warehouse.search
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
            this.warehouseTableAdapter.Fill(this.category_dbDataSet.warehouse);
            
        }
        private void item_categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouseBindingSource.EndEdit();
            this.warehouseTableAdapter.Update(this.category_dbDataSet);
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }

        private void warehouseKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            stock.check stockDetail = new stock.check(this, int.Parse(warehouseKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
    }
}
