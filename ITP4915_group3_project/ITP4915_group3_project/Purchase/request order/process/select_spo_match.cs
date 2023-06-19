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
    public partial class select_spo_match : UserControl
    {
        public int requestID;
        public select_spo_match(Control panelContent, int requestID)
        {

            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.requestID = requestID;

            this.purchasers_requestTableAdapter.FillBy_ID(this.purchase_dbDataSet.purchasers_request, requestID);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);
            this.spo_linesTableAdapter.Fill(this.purchase_dbDataSet.spo_lines);


        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)spo_linesBindingSource.Current;
            //check remain qty
            if (dataRowView == null)
            {
                MessageBox.Show("SPO haven't enougth qty ");
                return;
            }
            //craete spo release
            DataRow row = dataRowView.Row;

            int header_ID = row.Field<int>("header_ID");
            spo_releaseTableAdapter.Insert(header_ID);

            //insert purchase order all
            int relase_ID = spo_releaseTableAdapter.GetData().Last().release_ID;
            string remark = kryptonTextBoxRemark.Text;

            purchase_order_allTableAdapter.Insert(null, null, relase_ID, requestID, null, remark);

            //update request status
            this.purchase_dbDataSet.purchasers_request.Rows[0].SetField<int>("status_ID", 1200);
            this.purchasers_requestTableAdapter.Update(this.purchase_dbDataSet.purchasers_request.Rows[0]);

            //show success
            MessageBox.Show("process success");
            new check(check.panelContent);

        }

        private void kryptonLabelBack_Click_1(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
