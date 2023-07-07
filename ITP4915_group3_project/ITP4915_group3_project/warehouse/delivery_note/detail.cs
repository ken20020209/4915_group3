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
            /*            this.panel.Controls.Clear();*/
            this.panel.Controls.Add(this);
            this.BringToFront();
            this.deliveryID = deliveryID;

            this.delivery_requestTableAdapter.Fill(this.restaurant_dbDataSet.delivery_request);
            this.itemTableAdapter.Fill(this.restaurant_dbDataSet.item);
            this.addressTableAdapter.Fill(this.restaurant_dbDataSet.address);

            delivery_requestBindingSource.Filter = $"delivery_request_ID={deliveryID}";

            DataRowView dataRowView = (DataRowView)addressBindingSource.Current;
            restaurant_dbDataSet.addressRow addressRow = (restaurant_dbDataSet.addressRow)dataRowView.Row;

            string address = "";
            address += addressRow.unit + " " + addressRow.floor;
            address += "\n" + addressRow.building;
            address += "\n" + addressRow.street;
            address += "\n" + addressRow.district;

            kryptonRichTextBoxShipFrom.Text = address;

            dataRowView = (DataRowView)addressBindingSource1.Current;
            addressRow = (restaurant_dbDataSet.addressRow)dataRowView.Row;

            address = "";
            address += addressRow.unit + " " + addressRow.floor;
            address += "\n" + addressRow.building;
            address += "\n" + addressRow.street;
            address += "\n" + addressRow.district;

            kryptonRichTextBoxShipTo.Text = address;
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(this);
        }

    }
}
