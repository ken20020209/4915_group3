﻿using System;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.create
{
    public partial class select_item : UserControl
    {
        public requestOrder newOrder;
        public select_item()
        {
            InitializeComponent();

            this.newOrder = new requestOrder(restaurant.restaurant_ID, restaurant.restaurant_Name, General.login.Login.user_ID, General.login.Login.realName);
            this.requestOrder_restaurant_stockTableAdapter.Fill(this._4523_g1_project_dbDataSet.requestOrder_restaurant_stock,newOrder.restaurant_ID);
            
            foreach (DataGridViewRow row in requestOrder_restaurant_stockDataGridView.Rows)
            {
                // Replace the condition inside the if statement with your own logic for determining which rows to remove
                if (row.Cells["restaurant_ID"].Value.ToString() != newOrder.request_ID)
                {
                    requestOrder_restaurant_stockDataGridView.Rows.Remove(row);
                }
            }
            requestOrder_restaurant_stockDataGridView.Refresh();
        }

        private void kryptonButtonCountinue_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in requestOrder_restaurant_stockDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == "true")
                {
                    /*foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Extract the data from the cell
                        Console.WriteLine(cell.Value);

                    }*/
                    /*                  Console.WriteLine("test");*/
                    //cells[2] is id;
                    newOrder.item_ID.Add(row.Cells[2].Value.ToString());
                    newOrder.item_name.Add(row.Cells[3].Value.ToString());
                    //clls[
                }

            }
            /*       Console.WriteLine(item_ID.Count);*/

            new complete_detail(this, newOrder);

        }
    }
}
