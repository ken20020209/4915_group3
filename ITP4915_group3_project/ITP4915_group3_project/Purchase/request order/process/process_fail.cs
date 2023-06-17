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
    public partial class process_fail : Form
    {
        public int requestID;
        public Control panelContent;
        public process_fail(Control panelContent,int requestID)
        {
            InitializeComponent();
            this.requestID = requestID;
            this.panelContent = panelContent;
        }

        private void kryptonButtonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void kryptonButtonProcessLater_Click(object sender, EventArgs e)
        {
            this.purchasers_requestTableAdapter.FillBy_ID(this.purchase_dbDataSet.purchasers_request, requestID);
            this.purchase_dbDataSet.purchasers_request.Rows[0]["status_ID"] = 1100;
            this.purchasers_requestTableAdapter.Update(this.purchase_dbDataSet.purchasers_request);


            new check(check.panelContent);

            this.Close();
        }
    }
}
