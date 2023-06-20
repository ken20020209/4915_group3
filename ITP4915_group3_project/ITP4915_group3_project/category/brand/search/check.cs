using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.brand.search
{
    public partial class check : UserControl
    {
        public Control panel;
        public string keyword;

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
            keyword = "%" + kryptonTextBox16.Text + "%";
            this.partner_brandTableAdapter.Fill(this.category_dbDataSet.partner_brand);
        }
        private void dataTable_partner_brandKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            detail stockDetail = new detail(this, int.Parse(partner_brandKryptonDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }
        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }

}
