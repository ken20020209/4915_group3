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
    public partial class detail : UserControl
    {
        public Control check;
        public int listID, warehouseID;
        public detail(Control panel, int listID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.listID = listID;
            warehouseID = warehouse.warehouse_ID;
            this.BringToFront();

            this.delivery_requestTableAdapter.Fill(this.warehouse_dbDataSet.delivery_request);
            this.itemTableAdapter.Fill(this.warehouse_dbDataSet.item);

            delivery_requestBindingSource.Filter = $"delivery_request_ID = {listID}";
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            new confrim(listID).ShowDialog();
        }

        private void kryptonLabel7_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
    }
}
