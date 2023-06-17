using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.request_order
{
    public partial class detail : UserControl
    {
        public detail(Control panelContent,int requestID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();

            this.purchasers_requestTableAdapter.FillBy_ID(this.purchase_dbDataSet.purchasers_request, requestID);
            this.restaurantTableAdapter.Fill(this.purchase_dbDataSet.restaurant);
            this.userTableAdapter.Fill(this.purchase_dbDataSet.user);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);

        }

        private void kryptonButtonProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
