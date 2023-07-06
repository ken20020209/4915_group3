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
    public partial class update : UserControl
    {

        public Control detail;
        public int itemID, warehouseID;
        public update(Control panel, int itemID)
        {
            InitializeComponent();
            detail = panel;
            detail.Controls.Add(this);
            this.itemID = itemID;
            warehouseID = warehouse.warehouse_ID;
            this.BringToFront();

            this.dataTable_warehouse_stock_detailTableAdapter.Fill(this.warehouse_dbDataSet.DataTable_warehouse_stock_detail);
            dataTable_warehouse_stock_detailBindingSource.Filter = $"warehouse_ID={warehouseID} and item_ID={itemID}";
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouse_dbDataSet.EndInit();

            this.warehouse_itemTableAdapter.UpdateQuery(int.Parse(kryptonTextBox6.Text), itemID, warehouseID);
            MessageBox.Show("save success");
            detail.Controls.Clear();
            new search_stock.check(detail);
        }

        private void kryptonLabel12_Click(object sender, EventArgs e)
        {
            detail.Controls.Clear();
            new search_stock.check(detail);
        }
    }
}
