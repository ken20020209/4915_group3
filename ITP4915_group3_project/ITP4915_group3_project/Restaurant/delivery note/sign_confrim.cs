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
    public partial class sign_confrim : Form
    {
        int deliveryID;
        public sign_confrim(int deliveryID)
        {
            InitializeComponent();
            this.deliveryID = deliveryID;
        }

        private void kryptonButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButtonYes_Click(object sender, EventArgs e)
        {
            restaurant_dbDataSet.delivery_requestRow dataRow = delivery_requestTableAdapter.GetData().FindBydelivery_request_ID(deliveryID);
            dataRow.status_ID = 2100;
            delivery_requestTableAdapter.Update(dataRow);

            restaurant_dbDataSet.restaurant_stock_itemRow restaurant_Stock_ItemRow = restaurant_stock_itemTableAdapter.GetData().FindByrestaurant_IDitem_ID(restaurant.restaurant_ID,dataRow.item_ID); 
            if(restaurant_Stock_ItemRow != null)
            {
                restaurant_Stock_ItemRow.qty += dataRow.quantity;
                restaurant_stock_itemTableAdapter.Update(restaurant_Stock_ItemRow);
            }
            
            new sign_success(this);
            
        }
    }
}
