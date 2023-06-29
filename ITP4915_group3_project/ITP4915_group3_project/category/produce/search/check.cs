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
        public static Control panel;
        internal static Control panelContent;
        public check(Control panel)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            this.itemTableAdapter.Fill(this.category_dbDataSet.item);
            kryptonLabel6.Text = $"RESULT ({itemBindingSource.Count})";
        }
        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            string keyword = "'%" + kryptonTextBox1.Text + "%'";
            itemBindingSource.Filter = $" size like {keyword} or item_name like {keyword}";
            try
            {
                itemBindingSource.Filter += $" or item_ID = {int.Parse(kryptonTextBox1.Text)}";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            kryptonLabel6.Text = $"RESULT ({itemBindingSource.Count})";
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
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {

            search();
        }

        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            search();
        }

        private void kryptonCheckButton3_Click(object sender, EventArgs e)
        {
            search();
        }

        private void kryptonCheckButton4_Click(object sender, EventArgs e)
        {
            search();
        }

        private void kryptonCheckButton5_Click(object sender, EventArgs e)
        {
            search();
        }

        private void kryptonCheckButton6_Click(object sender, EventArgs e)
        {
            search();
        }

        private void kryptonCheckButton7_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}