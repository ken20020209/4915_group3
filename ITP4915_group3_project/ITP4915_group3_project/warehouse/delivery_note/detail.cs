using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.delivery_note
{
    public partial class detail : UserControl
    {
        public Control panel;
        int deliveryID;
        public detail(Control panel, int deliveryID)
        {
            InitializeComponent();

            this.panel = panel;
            this.panel.Controls.Add(this);
            this.BringToFront();
            this.deliveryID = deliveryID;

            this.delivery_requestTableAdapter.Fill(this.delivery_dbDataSet.delivery_request);
            /*this.itemTableAdapter.Fill(this.delivery_dbDataSet.item);
            this.statusTableAdapter.Fill(this.delivery_dbDataSet.status);
            this.restaurantTableAdapter.Fill(this.delivery_dbDataSet.restaurant);
            this.warehouseTableAdapter.Fill(this.delivery_dbDataSet.warehouse);
            this.userTableAdapter.Fill(this.delivery_dbDataSet.user);*/

            delivery_requestBindingSource.Filter = $"delivery_request_ID = {deliveryID}";

            //DataRowView dataRowView = (DataRowView)addressBindingSource.Current;
            delivery_dbDataSet.delivery_requestRow dataRow = delivery_requestTableAdapter.GetData().FindBydelivery_request_ID(deliveryID);
            
            if (dataRow.status_ID == 3100)
            {
                kryptonButtonSign.Visible = false;
            }
            else
            {
                kryptonButtonSign.Visible = true;
            }
        }

        private void kryptonLabel8_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(this);
        }

        private void kryptonButtonSign_Click(object sender, EventArgs e)
        {
            new sign_confirm(deliveryID).ShowDialog();
        }

        private void delivery_requestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.delivery_requestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.delivery_dbDataSet);

        }
    }
}
