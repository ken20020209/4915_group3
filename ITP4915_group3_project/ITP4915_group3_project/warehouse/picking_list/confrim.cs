using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.picking_list
{
    public partial class confrim : Form
    {
        int listID; Control panel;
        public confrim(Control panel, int listID)
        {
            InitializeComponent();
            this.listID = listID;
            this.panel = panel;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            warehouse_dbDataSet.warehousedispatchinstructionRow instructRow = warehousedispatchinstructionTableAdapter.GetData().FindByInstruction_ID(listID);
            int prid = instructRow.Purchasers_Request_id;

            warehousedispatchinstructionTableAdapter.DeleteQuery(listID);

            warehouse_dbDataSet.purchasers_requestRow requestRow = purchasers_requestTableAdapter.GetData().FindBypurchasers_request_id(prid);
            int delivery_ID = 3;
            int receive_ID = requestRow.restaurant_ID + 5;
            int item_ID = requestRow.item_ID;
            int qty = requestRow.qty;
            int status = 2000;
            DateTime create_date = DateTime.Now;
            DateTime delivery_date = requestRow.expected_delivery_date;

            delivery_requestTableAdapter.InsertQuery(delivery_ID, receive_ID, item_ID, qty, status,create_date, delivery_date, null, null, 2);
            this.tableAdapterManager.UpdateAll(this.warehouse_dbDataSet);

            new picking_list.check(panel);
            this.Close();

        }

      
    }
}
