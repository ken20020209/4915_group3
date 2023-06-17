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
            this.bpa_remain_qtyTableAdapter.FillBy_lessEqual_qty(this.purchase_dbDataSet.bpa_remain_qty, int.Parse(qtyKryptonTextBox.Text));

        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)bpa_remain_qtyBindingSource.Current;
            //check remain qty
            if (dataRowView == null)
            {
                MessageBox.Show("BPA haven't enougth qty ");
                return;
            }
            //craete blankey release
            DataRow row = dataRowView.Row;
            int line_id = row.Field<int>("lines_ID");
            DateTime curdate = DateTime.Now;
            DateTime expected = kryptonDateTimePickerExpected.Value;
            int item_qty =int.Parse( qtyKryptonTextBox.Text);

            blanket_releaseTableAdapter.Insert(line_id, curdate, expected, item_qty);

            //insert purchase order all
            int br_id = blanket_releaseTableAdapter.GetData().Last().release_ID;
            string remark = kryptonTextBoxRemark.Text;
            purchase_order_allTableAdapter.Insert(br_id, null, null, requestID, null, remark);

            //update request stauts
            this.purchase_dbDataSet.purchasers_request.Rows[0].SetField<int>("status_ID", 1200);
            this.purchasers_requestTableAdapter.Update(this.purchase_dbDataSet.purchasers_request.Rows[0]);

            MessageBox.Show("process success");
            Parent.Parent.Parent.Controls.Clear();

        }


    }
}
