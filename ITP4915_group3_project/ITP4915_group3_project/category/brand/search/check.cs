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
        public static Control panel;

        public check(Control panel)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            this.partner_brandTableAdapter.Fill(this.category_dbDataSet.partner_brand);
            kryptonLabelResult.Text = $"RESULT ({partner_brandBindingSource.Count})";


        }
        private void search()
        {
            string keyword = "'%" + kryptonTextBox16.Text + "%'";
            partner_brandBindingSource.Filter = $" type like {keyword} or name like {keyword}";
            try
            {
                partner_brandBindingSource.Filter += $" or partner_brand_ID = {int.Parse(kryptonTextBox16.Text)}";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            kryptonLabelResult.Text = $"RESULT ({partner_brandBindingSource.Count})";
        }

        private void partner_brandKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            detail stockDetail = new detail(this, int.Parse(partner_brandKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }

}
