using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.search
{


    public partial class detail : UserControl
    {

        restaurant_dbDataSet.purchasers_requestRow purchasers_RequestRow;
        Control checkUserControl;
        int requestOrder_ID;
        public detail(Control panel, int requestOrder_ID)
        {
            InitializeComponent();
            panel.Controls.Add(this);
            checkUserControl = panel;
            this.BringToFront();
            this.requestOrder_ID = requestOrder_ID;
            this.purchasers_requestTableAdapter.Fill(this.restaurant_dbDataSet.purchasers_request, restaurant.restaurant_ID);
            this.restaurant_stock_itemTableAdapter.Fill(this.restaurant_dbDataSet.restaurant_stock_item);
            this.restaurantTableAdapter.Fill(this.restaurant_dbDataSet.restaurant);
            this.userTableAdapter.Fill(this.restaurant_dbDataSet.user);
            this.itemTableAdapter.Fill(this.restaurant_dbDataSet.item);
            this.statusTableAdapter.Fill(this.restaurant_dbDataSet.status);



            purchasers_requestBindingSource.Filter = $"purchasers_request_ID={requestOrder_ID}";



            purchasers_RequestRow = (restaurant_dbDataSet.purchasers_requestRow)((DataRowView)purchasers_requestBindingSource.Current).Row;
            priority_idKryptonComboBox.Text = (purchasers_RequestRow.priority_id == 1 ? "urgent" : "normal");

            if (purchasers_RequestRow.status_ID != 1000)
            {
                kryptonButtonDelete.Visible = false;
                kryptonButtonSave.Visible = false;
            }



        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            checkUserControl.Controls.Remove(this);
        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            /*            this.restaurant_dbDataSet.EndInit();*/
            purchasers_RequestRow.priority_id = (int)(priority_idKryptonComboBox.Text == "urgent" ? 1 : 0);
            purchasers_RequestRow.qty = int.Parse(kryptonTextBoxQty.Text);
            purchasers_RequestRow.remarks = kryptonRichTextBoxRemark.Text;
            purchasers_RequestRow.expected_delivery_date = expected_delivery_dateKryptonDateTimePicker.Value;
/*            this.tableAdapterManager.UpdateAll(this.restaurant_dbDataSet);
            this.purchasers_requestTableAdapter.Update(purchasers_RequestRow);*/
            this.purchasers_requestTableAdapter.UpdateQuery(purchasers_RequestRow.qty, purchasers_RequestRow.priority_id, purchasers_RequestRow.expected_delivery_date, purchasers_RequestRow.remarks, requestOrder_ID);
            MessageBox.Show("save success");
        }

        private void kryptonButtonDelete_Click(object sender, EventArgs e)
        {
            purchasers_requestBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.restaurant_dbDataSet);
/*            MessageBox.Show("delete success");*/
            new delete_sucess().ShowDialog();
        }


    }
        
}
