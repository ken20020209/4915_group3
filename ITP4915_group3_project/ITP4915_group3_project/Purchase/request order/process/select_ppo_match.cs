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
    public partial class select_ppo_match : UserControl
    {
        public int requestID;
        public select_ppo_match(Control panelContent, int requestID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.requestID = requestID;


            this.purchasers_requestTableAdapter.FillBy_ID(this.purchase_dbDataSet.purchasers_request, requestID);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);
            this.match_ppoTableAdapter.Fill(this.purchase_dbDataSet.match_ppo, int.Parse(qtyKryptonTextBox.Text));
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)match_ppoBindingSource.Current;
            
            //check remain qty
            if (dataRowView == null)
            {
                MessageBox.Show("PPO haven't enougth qty ");
                return;
            }
            DataRow row = dataRowView.Row;
            //insert purchase order all

            int sr_id = row.Field<int>("release_ID");
            string remark = kryptonTextBoxRemark.Text;
            purchase_order_allTableAdapter.Insert(null, sr_id, null, requestID, null, remark);

            //update request stauts
            this.purchase_dbDataSet.purchasers_request.Rows[0].SetField<int>("status_ID", 1200);
            this.purchasers_requestTableAdapter.Update(this.purchase_dbDataSet.purchasers_request.Rows[0]);

            MessageBox.Show("process success");
            Parent.Parent.Parent.Controls.Clear();
        }


    }
}
