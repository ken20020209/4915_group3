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
        public int itemID;
        public detail(Control panel,int itemID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.itemID = itemID;
            this.BringToFront();
            this.restaurant_stock_detailTableAdapter.Fill(this.restaurant_dbDataSet.restaurant_stock_detail, restaurant.restaurant_ID, itemID);

        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }

        private void kryptonButtonEdit_Click(object sender, EventArgs e)
        {
            update updatePanel = new update(this, itemID);

        }
    }
}
