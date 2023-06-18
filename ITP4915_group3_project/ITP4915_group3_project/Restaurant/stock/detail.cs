using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.stock
{
    public partial class detail : UserControl
    {
        public Control check;
        public int itemID,restID;
        public detail(Control panel,int itemID,int restID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.itemID = itemID;
            this.restID = restID;
            this.BringToFront();

            this.restaurant_stock_itemTableAdapter.Fill(this.restaurant_dbDataSet.restaurant_stock_item);
            this.itemTableAdapter.Fill(this.restaurant_dbDataSet.item);
            this.partner_brandTableAdapter.Fill(this.restaurant_dbDataSet.partner_brand);
            this.item_categoryTableAdapter.Fill(this.restaurant_dbDataSet.item_category);

            restaurant_stock_itemBindingSource.Filter = $"restaurant_ID={restID} and item_ID={itemID}";
            Console.WriteLine(restaurant_stock_itemBindingSource.Filter);

        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }

        private void kryptonButtonEdit_Click(object sender, EventArgs e)
        {
            update updatePanel = new update(this, itemID);

        }
            
        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restaurant_dbDataSet.EndInit();


            this.restaurant_stock_itemTableAdapter.UpdateQuery(int.Parse(kryptonTextBoxQty.Text), kryptonRichTextBoxRemark.Text, restID, itemID);

            MessageBox.Show("save success");
        }
    }
}
