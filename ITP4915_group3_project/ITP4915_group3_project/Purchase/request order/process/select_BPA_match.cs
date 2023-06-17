using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.request_order.process
{
    public partial class select_BPA_match : UserControl
    {
        public int requestID;
        public select_BPA_match(Control panelContent, int requestID)
        {

            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.requestID = requestID;

            this.purchasers_requestTableAdapter.FillBy_ID(this.purchase_dbDataSet.purchasers_request, requestID);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);

        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
