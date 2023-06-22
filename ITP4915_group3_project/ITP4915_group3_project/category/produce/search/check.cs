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
    public partial class check : UserControl
    {
        public Control panel;
        public string keyword;
        internal static Control panelContent;
        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.panel.Controls.Clear();
            this.panel.Controls.Add(this);
            search();
        }
        private void search()
        {
            keyword = "%" + kryptonTextBox1.Text + "%";
            this.itemTableAdapter.Fill(this.category_dbDataSet.item);
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

        }
        private void itemKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            detail stockDetail = new detail(this, int.Parse(itemKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}