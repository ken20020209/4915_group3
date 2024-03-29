﻿using System;
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
        private string keyword;
        private int category;

        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);

            this.dataTable_warehouse_stock_searchTableAdapter.FillBy(this.warehouse_dbDataSet.DataTable_warehouse_stock_search);
            dataTable_warehouse_stock_searchBindingSource.Filter = $"warehouse_ID={warehouse.warehouse_ID} and qty < expected_inventory";
            kryptonLabelLowStock.Text = dataTable_warehouse_stock_searchBindingSource.Count.ToString();


            dataTable_warehouse_stock_searchBindingSource.Filter = $"warehouse_ID={warehouse.warehouse_ID}";
            kryptonLabelTotalItem.Text = dataTable_warehouse_stock_searchBindingSource.Count.ToString();

            search();
        }

        private void search()
        {
            keyword = "%" + kryptonTextBoxSearch.Text + "%";
            this.dataTable_warehouse_stock_searchTableAdapter.Fill(this.warehouse_dbDataSet.DataTable_warehouse_stock_search, keyword);
            string result = dataTable_warehouse_stock_searchBindingSource.Count.ToString();
            kryptonLabelResult.Text = "RESULT(" + result + ")";
        }

        private void kryptonTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (kryptonTextBoxSearch.TextLength > 0)
            {
                search();
            }else {
                this.dataTable_warehouse_stock_searchTableAdapter.FillBy(this.warehouse_dbDataSet.DataTable_warehouse_stock_search);
                dataTable_warehouse_stock_searchBindingSource.Filter = $"warehouse_ID={warehouse.warehouse_ID}";
                string result = dataTable_warehouse_stock_searchBindingSource.Count.ToString();
                kryptonLabelResult.Text = "RESULT(" + result + ")";
            }
                
        }

        private void dataTable_warehouse_stock_searchKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            new detail(this, int.Parse(dataTable_warehouse_stock_searchKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonComboBox1.Text == "Food")
                category = 1;
            else if (kryptonComboBox1.Text == "Drink")
                category = 2;
            else
                category = 3;
            dataTable_warehouse_stock_searchBindingSource.Filter = $"category_ID = {category} and warehouse_ID={warehouse.warehouse_ID}";

        }
    }
}
