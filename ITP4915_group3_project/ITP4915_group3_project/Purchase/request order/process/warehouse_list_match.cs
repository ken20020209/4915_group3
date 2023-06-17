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
    public partial class warehouse_list_match : UserControl
    {
        public int requestID;
        public warehouse_list_match(Control panelContent,int requestID)
        {
            
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.requestID = requestID;

            this.purchasers_requestTableAdapter.FillBy_ID(this.purchase_dbDataSet.purchasers_request, requestID);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);
            this.warehouse_itemTableAdapter.FillBy_lessEqual_qty(this.purchase_dbDataSet.warehouse_item, int.Parse(qtyKryptonTextBox.Text));



        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)warehouse_itemBindingSource.Current;
            //check warhouse qty
            if(dataRowView==null)
            {
                MessageBox.Show("warehouse haven't enougth qty ");
                return;
            }
            int warehouseQty = dataRowView.Row.Field<int>("qty");
            int requireQty = int.Parse(qtyKryptonTextBox.Text);
            int warehouseID = dataRowView.Row.Field<int>("warehouse_ID");
            int itemID = int.Parse(item_IDKryptonTextBox.Text);
            string remark = kryptonTextBoxRemark.Text;



            // update warehouse qty


/*          this.purchase_order_allTableAdapter.Insert(p1:null,p2:null,p3:null,p4: requestID,p5:null, p6: kryptonTextBoxRemark.Text);
*/
            dataRowView.Row.SetField<int>("qty", warehouseQty - requireQty);
            warehouse_itemTableAdapter.Update(dataRowView.Row);

            //create warheouse Despatch instruction
            this.warehousedispatchinstructionTableAdapter.Insert(warehouseID, null, remark, itemID, 3000, requestID);

            //update request stauts
            this.purchase_dbDataSet.purchasers_request.Rows[0].SetField<int>("status_ID", 1200);
            this.purchasers_requestTableAdapter.Update(this.purchase_dbDataSet.purchasers_request.Rows[0]);



            //back to seach page
            new process_success_warehouse().ShowDialog();
            

        }


    }
}
