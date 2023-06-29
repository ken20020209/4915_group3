using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.category.select
{
    public partial class check : UserControl
    {
        public static Control panel;
        internal static Control panelContent;

        public check(Control panel)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            this.item_categoryTableAdapter.Fill(this.category_dbDataSet.item_category);
            kryptonLabelResult.Text = $"RESULT ({item_categoryBindingSource.Count})";
        }
        private void search()
        {
            string keyword = "'%" + kryptonTextBox16.Text + "%'";
            item_categoryBindingSource.Filter = $" category_name like {keyword} or description like {keyword}";
            try
            {
                item_categoryBindingSource.Filter += $" or item_category_ID = {int.Parse(kryptonTextBox16.Text)}";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            kryptonLabelResult.Text = $"RESULT ({item_categoryBindingSource.Count})";
        }
        private void item_categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

        }
        private void item_categoryKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            detail stockDetail = new detail(this, int.Parse(item_categoryKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
