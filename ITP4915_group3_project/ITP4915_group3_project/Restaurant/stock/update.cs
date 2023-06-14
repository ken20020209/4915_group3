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
    public partial class update : UserControl
    {
        public detail detail;
        public int itemID;
        public update(detail panel,int itemID)
        {
            InitializeComponent();
            this.restaurant_stock_detailTableAdapter.Fill(this.restaurant_dbDataSet.restaurant_stock_detail, restaurant.restaurant_ID, itemID);
            detail = panel;
            detail.Controls.Add(this);
            this.itemID = itemID;
            this.BringToFront();
            
        }



        private void kryptonLabelback_Click(object sender, EventArgs e)
        {
            detail.check.Controls.Remove(detail);
        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            restaurant_dbDataSet.restaurant_stock_itemDataTable db = new restaurant_dbDataSet.restaurant_stock_itemDataTable();
            restaurant_dbDataSetTableAdapters.restaurant_stock_itemTableAdapter item = new restaurant_dbDataSetTableAdapters.restaurant_stock_itemTableAdapter();
            item.Fill(db);
            item.UpdateQuery(int.Parse(qtyTextBox.Text), kryptonRichTextBoxRemark.Text, restaurant.restaurant_ID, itemID);


        }
    }
}
