using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.create
{
    public partial class select_item : UserControl
    {
        public select_item()
        {
            InitializeComponent();
            this.restaurant_stock_itemTableAdapter.Fill(this._4523_g1_project_dbDataSet.restaurant_stock_item);
        }

        private void kryptonButtonCountinue_Click(object sender, EventArgs e)
        {
            new complete_detail(this);
            
        }
    }
}
