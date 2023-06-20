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
 
    public partial class check : UserControl
    {
        public Control panel;
        public string keyword;
        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);

            search();

            dataTable_warehouse_stock_searchBindingSource.Filter = $"warehouse_ID={warehouse.warehouse_ID}";
            kryptonLabelTotalItem.Text = dataTable_warehouse_stock_searchBindingSource.Count.ToString();
        }

        private void search()
        {
            keyword = "%" + kryptonTextBoxSearch.Text + "%";
            this.dataTable_warehouse_stock_searchTableAdapter.Fill(this.warehouse_dbDataSet.DataTable_warehouse_stock_search, keyword);
        }

        private void kryptonTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
