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
    public partial class check : UserControl
    {
        public Control panel;
        public string keyword;
        public check(Control panel)
        {
            InitializeComponent();

            this.panel = panel;
            this.panel.Controls.Clear();
            this.panel.Controls.Add(this);

            search();

            dataTable_restaurant_stock_searchBindingSource.Filter = $"restaurant_ID={restaurant.restaurant_ID} and qty<expected_inventory";
            kryptonLabelLowStock.Text = dataTable_restaurant_stock_searchBindingSource.Count.ToString();

            dataTable_restaurant_stock_searchBindingSource.Filter = $"restaurant_ID={restaurant.restaurant_ID}";
            kryptonLabelTotalItem.Text = dataTable_restaurant_stock_searchBindingSource.Count.ToString();

            


            

        }


        private void search()
        {
            keyword = "%" + kryptonTextBoxSearch.Text + "%";
            this.dataTable_restaurant_stock_searchTableAdapter.Fill(this.restaurant_dbDataSet.DataTable_restaurant_stock_search,keyword);
        }

        private void dataTable_restaurant_stock_searchKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1||e.ColumnIndex!=0)
            {
                return;
            }
            detail stockDetail = new detail(this,int.Parse(dataTable_restaurant_stock_searchKryptonDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn28"].Value.ToString()),restaurant.restaurant_ID);
        }

        private void kryptonTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
