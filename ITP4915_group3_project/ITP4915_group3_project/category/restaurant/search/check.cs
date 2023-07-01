using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.restaurant.search
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
            this.restaurantTableAdapter.Fill(this.category_dbDataSet.restaurant);
           
        }


        private void restaurantKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            stock.check stockDetail = new stock.check(this, int.Parse(restaurantKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restaurantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }
    }
}
