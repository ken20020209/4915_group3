using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.delivery_note
{
    public partial class check : UserControl
    {
        public Control panel;
        int deliveryID;
        public check(Control panel , int deliveryID)
        {
            InitializeComponent();

            this.panel = panel;
/*            this.panel.Controls.Clear();*/
            this.panel.Controls.Add(this);
            this.BringToFront();
            this.deliveryID = deliveryID;

            this.delivery_requestTableAdapter.Fill(this.restaurant_dbDataSet.delivery_request);
            this.itemTableAdapter.Fill(this.restaurant_dbDataSet.item);
            this.restaurant_stock_itemTableAdapter.Fill(this.restaurant_dbDataSet.restaurant_stock_item);
            this.addressTableAdapter.Fill(this.restaurant_dbDataSet.address);

            delivery_requestBindingSource.Filter = $"delivery_request_ID={deliveryID}";

            Console.WriteLine(addressBindingSource.Current.GetType());

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


            kryptonTextBoxStatus.Text = (this.delivery_requestTableAdapter.GetData().FindBydelivery_request_ID(deliveryID).status_ID == 2000 ? "wait to sign" : "complete");
            if (kryptonButtonSign.Text == "complete")
            {
                kryptonButtonSign.Visible = false;
            }

        }



        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(this);
        }

        private void kryptonButtonSign_Click(object sender, EventArgs e)
        {
            new sign_confrim(deliveryID).ShowDialog();
        }
    }
}
