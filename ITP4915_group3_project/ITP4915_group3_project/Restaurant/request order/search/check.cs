using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.search
{
    public partial class check : UserControl
    {
        public check()
        {
            InitializeComponent();

            purchasers_requestTableAdapter.Fill(this._4523_g1_project_dbDataSet.purchasers_request, restaurant.restaurant_ID);
        }

        private void purchasers_requestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detail requestDetail = new detail(this,int.Parse(purchasers_requestDataGridView.Rows[e.RowIndex].Cells["purchasers_request_id"].Value.ToString()));
        }
    }
}
