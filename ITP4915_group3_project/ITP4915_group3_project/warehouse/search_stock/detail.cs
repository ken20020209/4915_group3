using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.search_stock
{
    public partial class detail : UserControl
    {
        public Control check;
        public int itemID, warehouseID;



        public detail(Control panel, int itemID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.itemID = itemID;
            warehouseID = warehouse.warehouse_ID;
            this.BringToFront();

            this.dataTable_warehouse_stock_detailTableAdapter.Fill(this.warehouse_dbDataSet.DataTable_warehouse_stock_detail);
            this.item_categoryTableAdapter.Fill(this.warehouse_dbDataSet.item_category);

            dataTable_warehouse_stock_detailBindingSource.Filter = $"warehouse_ID={warehouseID} and item_ID={itemID}";
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }

    }
}
