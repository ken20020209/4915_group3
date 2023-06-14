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
        public Control panelContent;
        public check(Control panelContent)
        {
            InitializeComponent();

            this.panelContent = panelContent;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);

            purchasers_requestTableAdapter.Fill(this.restaurant_dbDataSet.purchasers_request, restaurant.restaurant_ID);
        }

        private void purchasers_requestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detail requestDetail = new detail(this,int.Parse(purchasers_requestDataGridView.Rows[e.RowIndex].Cells["purchasers_request_id"].Value.ToString()));
        }
    }
}
