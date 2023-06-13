using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.stock
{
    public partial class check : UserControl
    {
        public check()
        {
            InitializeComponent();
            this.requestOrder_restaurant_stockTableAdapter.Fill(this._4523_g1_project_dbDataSet.requestOrder_restaurant_stock,restaurant.restaurant_ID);

        }

        private void requestOrder_restaurant_stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detail stockDetail = new detail(this, int.Parse(requestOrder_restaurant_stockDataGridView.Rows[e.RowIndex].Cells["item_ID"].Value.ToString()));
        }
    }
}
